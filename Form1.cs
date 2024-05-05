﻿using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TableComparator.Classes;

namespace TableComparator
{
    public partial class Form1 : Form
    {
        // при вставке нового массива значений последняя строка переносится в низ
        // при повторном расчете он происходит слишком быстро, что странно
        // реализовать через паттерн наблюдатель работу с таблицей, а не юзать ее напрямую
        // доработать функционал кнопок и чекбоксов

        public Form1()
        {
            InitializeComponent();
        }

        public delegate void ErrorHandler(string message, Exception exception);
        public static ErrorHandler ErrHandler;
        private Thread ThreadCalc = null;
        private CancellationTokenSource CancellationTokenSource;

        private static void PasteTSV(DataGridView grid)
        {
            char[] rowSplitter = { '\r', '\n' };
            char[] columnSplitter = { '\t' };

            // Get the text from clipboard
            IDataObject dataInClipboard = Clipboard.GetDataObject();
            string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);

            // Split it into lines
            string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

            // Get the row and column of selected cell in grid
            int r, c;
            try
            {
                r = grid.SelectedCells[0].RowIndex;
                c = grid.SelectedCells[0].ColumnIndex;
            }
            catch
            {
                r = 0; c = 0;
            }

            // Add rows into grid to fit clipboard lines
            if (grid.Rows.Count < (r + rowsInClipboard.Length))
            {
                grid.Rows.Add(r + rowsInClipboard.Length - grid.Rows.Count);
            }

            // Loop through the lines, split them into cells and place the values in the corresponding cell.
            for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)
            {
                // Split row into cell values
                string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);

                // Cycle through cell values
                for (int iCol = 0; iCol < valuesInRow.Length; iCol++)
                {

                    // Assign cell value, only if it within columns of the grid
                    if (grid.ColumnCount - 1 >= c + iCol)
                    {
                        DataGridViewCell cell = grid.Rows[r + iRow].Cells[c + iCol];

                        if (!cell.ReadOnly)
                        {
                            cell.Value = valuesInRow[iCol];
                        }
                    }
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            grid.Columns[0].Width = (grid.Width / 3) - 15;
            grid.Columns[1].Width = (grid.Width / 3) - 15;
            grid.Columns[2].Width = (grid.Width / 3) - 15;
        }

        private void grid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.grid.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.grid.Rows[index].HeaderCell.Value = indexStr;
        }

        private void grid_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Shift && e.KeyCode == Keys.Insert) || (e.Control && e.KeyCode == Keys.V))
            {
                PasteTSV(grid);
            }

            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell cell in grid.SelectedCells)
                    cell.Value = "";
            }
            if (e.KeyCode == Keys.Back)
            {
                if (grid.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in grid.SelectedRows)
                    {
                        if (row.Index == grid.RowCount - 1) break; // because grid.AllowUserToAddRows = true by default. Cant del last row
                        grid.Rows.RemoveAt(row.Index);
                        grid.Refresh();
                    }
                }
                grid.Refresh();
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                PasteTSV(grid);
            }

        }

        private void bCopyResult_Click(object sender, EventArgs e)
        {
            var newline = Environment.NewLine;
            var tab = "\t";
            var clipboard_string = "";
            Clipboard.Clear();

            for (int i = 0; i < grid.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(grid.Rows[i].Cells["col3"].Value?.ToString()))
                    clipboard_string += grid.Rows[i].Cells["col3"].Value + newline;
                else break;

                //for (int i = 0; i < row.Cells.Count; i++)
                //{
                // for more cells, than 1
                //if (i == (row.Cells.Count - 1))
                //    clipboard_string += row.Cells[i].Value + newline;
                //else
                //    clipboard_string += row.Cells[i].Value + tab;
                //}
            }
            try
            {
                Clipboard.SetText(clipboard_string);
            }
            catch
            {
                ErrHandler?.Invoke("Ошибка копирования", null);
                return;
            }
        }

        private void bCompare_Click(object sender, EventArgs e)
        {
            CancellationTokenSource = new CancellationTokenSource();
            switch (cmFilterMethod.SelectedIndex)
            {
                case 0:
                    ThreadCalc = new Thread(() =>
                    {
                        Comparator.CompareLineByLine(grid, "col1", "col2", "col3", CancellationTokenSource.Token);
                    }); break;
                case 1:
                    ThreadCalc = new Thread(() =>
                    {
                        Comparator.CompareEachWithEachAndRecolor(grid, "col1", "col2", "col3", CancellationTokenSource.Token);
                    }); break;
                default:
                    return;
            }
            progressBar1.Value = 0;
            richTextBox1.Clear();

            ThreadCalc.Start();
            bCompare.Enabled = false;
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            HandlerCalcFinished(null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Comparator.ProgressChange = sendParam => HandleEvent(progressBar1, HandlerProgressChange, sendParam);
            Comparator.CalcEvent = sendParam => HandleEvent(richTextBox1, HandlerCalcEvent, sendParam);
            Comparator.CalcFinished = () => HandleEvent(bCompare, HandlerCalcFinished, null);

            cmFilterMethod.SelectedIndex = 0;
        }

        // костыль
        /// <summary>
        /// bStop_PerformanceClick if InvokeRequired
        /// </summary>
        private void HandlerCalcFinished(object pass)
        {
            if (CancellationTokenSource != null)
            {
                CancellationTokenSource.Cancel();
                CancellationTokenSource.Dispose();
                CancellationTokenSource = null;
                ThreadCalc = null;
            }
            bCompare.Enabled = true;
        }

        private void HandlerProgressChange(object value)
        {
            progressBar1.Value = (int)value;
            //if (value is int progress)  //also good work
            //{
            //    progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = progress; });
            //}
        }

        private void HandlerCalcEvent(object value)
        {
            if (!string.IsNullOrEmpty((string)value))
            {
                StringBuilder sb = new StringBuilder(value.ToString());
                //string time = DateTime.Now.ToString("dd.MM HH:mm:ss");
                //StringBuilder sb = new StringBuilder(time + "  " + value);
                sb.AppendLine();
                sb.AppendLine(richTextBox1.Text);
                richTextBox1.Text = sb.ToString();
            }
        }


        private delegate void DHandleDeleg(Control control, Action<object> func, object value);
        private void HandleEvent(Control control, Action<object> method, object value)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    //DHandleDeleg d = new DHandleDeleg(HandleEvent);
                    //control.Invoke(d, new object[] { value });
                    control.Invoke(new Action(() => method.Invoke(value)));
                }
                else
                {
                    method.Invoke(value);
                }
            }
            catch { }
        }



    }
}
