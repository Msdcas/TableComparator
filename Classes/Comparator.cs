using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TableComparator.Classes
{        /// при сравнении массив цвета всегда привязан ко 1му столбцу и считается определяющим есть ли эквивалент во 2м столбце

    public static class Comparator
{
        public delegate void DProgressChange(int progress);
        public static DProgressChange ProgressChange;

        public delegate void DelProgressChange(string message);
        public static DelProgressChange CalcEvent;
        private static List<string> _Messages = new List<string>();

        public static Action CalcFinished;

        public static void CompareEachWithEachAndRecolor(DataGridView grid, string columnCompareMain,
            string columnCompareSlave, string columnOut, CancellationToken cancellation)
        {
            ClearResultColumn(grid, columnOut);

            int resColInd = 0;

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

                ProgressChange?.Invoke(i * 100 / grid.RowCount);

                if (cancellation.IsCancellationRequested)
                {
                    ResetCellColor(grid, columnCompareMain, Color.White);
                    break;
                }
            }
            ProgressChange?.Invoke(100);
            ProcessErrors();
            CalcFinished?.Invoke();
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
                    grid.Rows[i].Cells[columnCompareMain].Style.BackColor = Color.Green;
                    resColInd++;
                }
                else
                    grid.Rows[i].Cells[columnCompareMain].Style.BackColor = Color.Red;

                ProgressChange?.Invoke(i * 100 / grid.RowCount);

                if (cancellation.IsCancellationRequested)
                {
                    ResetCellColor(grid, columnCompareMain, Color.White);
                    break;
                }
            }

            ProgressChange?.Invoke(100);
            ProcessErrors();
            CalcFinished?.Invoke();
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
            if (!_Messages.Contains(message))
                _Messages.Add(message);
        }

        private static void ProcessErrors()
        {
            foreach (var error in _Messages)
            {
                CalcEvent?.Invoke(error);
            }
            _Messages.Clear();
        }


    }
    
}
