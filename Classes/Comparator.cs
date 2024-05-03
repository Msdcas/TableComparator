using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableComparator.Classes
{
public static class Comparator
{
    /// при сравнении массив цвета всегда привязан ко 1му столбцу и считается определяющим есть ли эквивалент во 2м столбце
        private delegate void DMethodDeleg(Control control, object value);
        private delegate void DCommonNotifyer(object progress);

        public static ProgressBar ProgressBar;
        private static DCommonNotifyer ProgressSender = value => HandleEvent(ProgressBar, value);

        public static RichTextBox RichTextBox;
        private static DCommonNotifyer EventSender = text => HandleEvent(RichTextBox, text);
        private static List<string> _Errors = new List<string>();

        public static Action CalcFinished;
        private static Action _EventCalcFinished = CalcFinishHandler;

        public static void CompareEachWithEachAndRecolor(DataGridView grid, string columnCompareMain,
            string columnCompareSlave, string columnOut, CancellationToken cancellation)
        {
            ClearResultColumn(grid, columnOut);

            int resColInd = 0;
            //int emptyCellsTogether = 0;

            for (int i = 0; i < grid.RowCount; i++)
            {
                if (string.IsNullOrEmpty(grid.Rows[i].Cells[columnCompareMain].Value?.ToString()))
                {
                    AddError($">Найдена пустая ячейка в первом столбце в строке {i}");
                    continue;
                }

                bool isUniq = true;
                for (int j = 0; j < grid.RowCount; j++)
                {
                    if (string.IsNullOrEmpty(grid.Rows[j].Cells[columnCompareSlave].Value?.ToString()))
                    {
                        AddError($">Найдена пустая ячейка во втором столбце в строке {j}");
                        continue;
                    }

                    if (grid.Rows[i].Cells[columnCompareMain].Value.ToString() ==
                                grid.Rows[j].Cells[columnCompareSlave].Value.ToString())
                    {
                        isUniq = false;
                        break;
                    }
                }

                if (isUniq)
                {
                    grid.Rows[resColInd].Cells[columnOut].Value = grid.Rows[i].Cells[columnCompareMain].Value;
                    grid.Rows[i].Cells[columnCompareMain].Style.BackColor = Color.Green;
                    resColInd++;
                }
                else
                    grid.Rows[i].Cells[columnCompareMain].Style.BackColor = Color.Red;

                ProgressSender?.Invoke(i * 100 / grid.RowCount);

                if (cancellation.IsCancellationRequested)
                {
                    ResetCellColor(grid, columnCompareMain, Color.White);
                    break;
                }
            }
            ProgressSender?.Invoke(0);
            ProcessErrors();
            _EventCalcFinished?.Invoke();
        }

        public static void CompareLineByLine(DataGridView grid, string columnCompareMain,
            string columnCompareSlave, string columnOut, CancellationToken cancellation)
        {
            ClearResultColumn(grid, columnOut);

            int resColInd = 0;
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (string.IsNullOrEmpty(grid.Rows[i].Cells[columnCompareMain].Value?.ToString()) ||
                    string.IsNullOrEmpty(grid.Rows[i].Cells[columnCompareSlave].Value?.ToString()))
                {
                    AddError($">Найдена пустая ячейка в {i} строке");
                    continue;
                }

                if (grid.Rows[i].Cells[columnCompareMain].Value.ToString() != grid.Rows[i].Cells[columnCompareSlave].Value.ToString())
                {
                    grid.Rows[resColInd].Cells[columnOut].Value = grid.Rows[i].Cells[columnCompareMain].Value;
                    grid.Rows[i].Cells[columnCompareMain].Style.BackColor = Color.FromArgb(200, Color.Green);
                    resColInd++;
                }
                else
                    grid.Rows[i].Cells[columnCompareMain].Style.BackColor = Color.FromArgb(200, Color.Red);

                ProgressSender?.Invoke(i * 100 / grid.RowCount);

                if (cancellation.IsCancellationRequested)
                {
                    ResetCellColor(grid, columnCompareMain, Color.White);
                    break;
                }
            }

            ProgressSender?.Invoke(0);
            ProcessErrors();
            _EventCalcFinished?.Invoke();
        }

        private static void ClearResultColumn(DataGridView grid, string resultColName)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[resultColName].Value = string.Empty;
            }
        }

        private static void ResetCellColor(DataGridView grid, string nameColumn, Color color)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[nameColumn].Style.BackColor = Color.FromArgb(128, color);
            }
        }

        private static void AddError(string message)
        {
            if (!_Errors.Contains(message))
            { _Errors.Add(message); }
        }

        private static void ProcessErrors()
        {
            foreach (var error in _Errors)
            {
                EventSender?.Invoke(error);
            }
            _Errors.Clear();
        }

        private static void CalcFinishHandler()
        {
            CalcFinished.Invoke();
            
        }


        private static void HandleEvent(Control control, object value)
        {
            if (control == null) return;
            try
            {
                if (control.InvokeRequired)
                {
                    DMethodDeleg d = new DMethodDeleg(HandleEvent);
                    control.Invoke(d, new object[] { value });
                }
                else
                {
                    if (control.GetType() == typeof(ProgressBar))
                    {
                        ProgressBar.Value = (int)value;
                    }
                    if (control.GetType() == typeof(RichTextBox))
                        if (!string.IsNullOrEmpty((string)value))
                        {
                            string time = DateTime.Now.ToString("dd.MM HH:mm:ss");
                            StringBuilder sb = new StringBuilder(time + "  " + value);
                            sb.AppendLine();
                            sb.AppendLine(control.Text);
                            control.Text = sb.ToString();
                        }


                    Console.WriteLine(value.ToString());
                }
            }
            catch { }
        }


    }
    
}
