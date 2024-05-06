﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TableComparator.Classes
{        /// при сравнении массив цвета всегда привязан ко 1му столбцу и считается определяющим есть ли эквивалент во 2м столбце

    public static class Comparator
{
        public static bool CompareWithEmptyCells = false;

        public delegate void DProgressChange(int progress);
        public static DProgressChange ProgressChange;

        public delegate void DelProgressChange(string message);
        public static DelProgressChange CalcEvent;
        public static Action CalcFinished;

        private static List<string> _Messages = new List<string>();      

        public static void CompareEachWithEachAndRecolor(DataGridView grid, string columnCompareMain,
            string columnCompareSlave, string columnOut, CancellationToken cancellation)
        {
            ClearResultColumn(grid);

            int resColInd = 0;

            for (int i = 0; i < grid.RowCount; i++)
            {
                if (string.IsNullOrEmpty(grid.Rows[i].Cells[columnCompareMain].Value?.ToString()))
                {
                    AddError($">Найдена пустая ячейка в первом столбце в строке {i+1}");
                    continue;
                }

                bool isUniq = true;
                for (int j = 0; j < grid.RowCount; j++)
                {
                    if (string.IsNullOrEmpty(grid.Rows[j].Cells[columnCompareSlave].Value?.ToString()))
                    {
                        AddError($">Найдена пустая ячейка во втором столбце в строке {j+1}");
                        if (!CompareWithEmptyCells) continue;
                    }

                    if (grid.Rows[i].Cells[columnCompareMain].Value.ToString() ==
                        grid.Rows[j].Cells[columnCompareSlave].Value?.ToString())
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
                Console.WriteLine(i * 100 / grid.RowCount);

                if (cancellation.IsCancellationRequested) break;
            }
            ProgressChange?.Invoke(100);
            ProcessErrors();
            CalcFinished?.Invoke();

            Console.WriteLine("finish");
        }

        public static void CompareLineByLine(DataGridView grid, string columnCompareMain,
            string columnCompareSlave, string columnOut, CancellationToken cancellation)
        {
            ClearResultColumn(grid);

            int resColInd = 0;
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (string.IsNullOrEmpty(grid.Rows[i].Cells[columnCompareMain].Value?.ToString()))
                {
                    AddError($">Найдена пустая ячейка в {i+1} строке");
                    continue;
                }
                if (string.IsNullOrEmpty(grid.Rows[i].Cells[columnCompareSlave].Value?.ToString()))
                {
                    AddError($">Найдена пустая ячейка в {i + 1} строке");
                    if (!CompareWithEmptyCells) continue;
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

                if (cancellation.IsCancellationRequested) break;
            }

            ProgressChange?.Invoke(100);
            ProcessErrors();
            CalcFinished?.Invoke();
        }

        private static void ClearResultColumn(DataGridView grid)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[2].Value = string.Empty;
                grid.Rows[i].Cells[0].Style.BackColor = Color.White;
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
