namespace TableComparator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCompare = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.cmFilterMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCopyResult = new System.Windows.Forms.Button();
            this.bSwap12Column = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bSwap23Column = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chbCompareWithEmptyCells = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDelRow = new System.Windows.Forms.Button();
            this.bAddRow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid.Location = new System.Drawing.Point(1, 0);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(633, 427);
            this.grid.TabIndex = 0;
            this.grid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grid_RowPrePaint);
            this.grid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grid_KeyUp);
            // 
            // col1
            // 
            this.col1.HeaderText = "Сравниваемое";
            this.col1.Name = "col1";
            this.col1.Width = 200;
            // 
            // col2
            // 
            this.col2.HeaderText = "Сравнивающее";
            this.col2.Name = "col2";
            this.col2.Width = 200;
            // 
            // col3
            // 
            this.col3.HeaderText = "Уникальные";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Width = 190;
            // 
            // bCompare
            // 
            this.bCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCompare.BackColor = System.Drawing.SystemColors.Window;
            this.bCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCompare.Location = new System.Drawing.Point(11, 79);
            this.bCompare.Name = "bCompare";
            this.bCompare.Size = new System.Drawing.Size(153, 36);
            this.bCompare.TabIndex = 1;
            this.bCompare.Text = "Сравнить";
            this.bCompare.UseVisualStyleBackColor = false;
            this.bCompare.Click += new System.EventHandler(this.bCompare_Click);
            // 
            // bStop
            // 
            this.bStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bStop.Location = new System.Drawing.Point(170, 81);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(29, 32);
            this.bStop.TabIndex = 2;
            this.bStop.Text = "X";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // cmFilterMethod
            // 
            this.cmFilterMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmFilterMethod.FormattingEnabled = true;
            this.cmFilterMethod.Items.AddRange(new object[] {
            "Построчно",
            "Каждый с каждым"});
            this.cmFilterMethod.Location = new System.Drawing.Point(11, 29);
            this.cmFilterMethod.Name = "cmFilterMethod";
            this.cmFilterMethod.Size = new System.Drawing.Size(153, 21);
            this.cmFilterMethod.TabIndex = 3;
            this.cmFilterMethod.SelectedIndexChanged += new System.EventHandler(this.cmFilterMethod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Метод";
            // 
            // bCopyResult
            // 
            this.bCopyResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopyResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bCopyResult.Location = new System.Drawing.Point(6, 19);
            this.bCopyResult.Name = "bCopyResult";
            this.bCopyResult.Size = new System.Drawing.Size(153, 23);
            this.bCopyResult.TabIndex = 5;
            this.bCopyResult.Text = "Копировать уникальные";
            this.bCopyResult.UseVisualStyleBackColor = false;
            this.bCopyResult.Click += new System.EventHandler(this.bCopyResult_Click);
            // 
            // bSwap12Column
            // 
            this.bSwap12Column.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSwap12Column.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bSwap12Column.Location = new System.Drawing.Point(6, 77);
            this.bSwap12Column.Name = "bSwap12Column";
            this.bSwap12Column.Size = new System.Drawing.Size(188, 23);
            this.bSwap12Column.TabIndex = 6;
            this.bSwap12Column.Text = "Сравниваемое ↔ Сравнивающее";
            this.bSwap12Column.UseVisualStyleBackColor = false;
            this.bSwap12Column.Click += new System.EventHandler(this.bSwap12Column_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(640, 374);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(211, 53);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // bSwap23Column
            // 
            this.bSwap23Column.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSwap23Column.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bSwap23Column.Location = new System.Drawing.Point(6, 48);
            this.bSwap23Column.Name = "bSwap23Column";
            this.bSwap23Column.Size = new System.Drawing.Size(188, 23);
            this.bSwap23Column.TabIndex = 8;
            this.bSwap23Column.Text = "Уникальные → Сравнивающее";
            this.bSwap23Column.UseVisualStyleBackColor = false;
            this.bSwap23Column.Click += new System.EventHandler(this.bSwap23Column_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(11, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(152, 13);
            this.progressBar1.TabIndex = 10;
            // 
            // chbCompareWithEmptyCells
            // 
            this.chbCompareWithEmptyCells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCompareWithEmptyCells.AutoSize = true;
            this.chbCompareWithEmptyCells.Location = new System.Drawing.Point(13, 56);
            this.chbCompareWithEmptyCells.Name = "chbCompareWithEmptyCells";
            this.chbCompareWithEmptyCells.Size = new System.Drawing.Size(194, 17);
            this.chbCompareWithEmptyCells.TabIndex = 11;
            this.chbCompareWithEmptyCells.Text = "Сравнивать с пустыми строками";
            this.chbCompareWithEmptyCells.UseVisualStyleBackColor = true;
            this.chbCompareWithEmptyCells.CheckedChanged += new System.EventHandler(this.chbCompareWithEmptyCells_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bDelRow);
            this.groupBox1.Controls.Add(this.bAddRow);
            this.groupBox1.Location = new System.Drawing.Point(640, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 76);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица";
            // 
            // bDelRow
            // 
            this.bDelRow.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bDelRow.Location = new System.Drawing.Point(6, 45);
            this.bDelRow.Name = "bDelRow";
            this.bDelRow.Size = new System.Drawing.Size(124, 25);
            this.bDelRow.TabIndex = 1;
            this.bDelRow.Text = "- удалить стороку(и)";
            this.bDelRow.UseVisualStyleBackColor = false;
            this.bDelRow.Click += new System.EventHandler(this.bDelRow_Click);
            // 
            // bAddRow
            // 
            this.bAddRow.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bAddRow.Location = new System.Drawing.Point(6, 19);
            this.bAddRow.Name = "bAddRow";
            this.bAddRow.Size = new System.Drawing.Size(124, 25);
            this.bAddRow.TabIndex = 0;
            this.bAddRow.Text = "+ добавить строку";
            this.bAddRow.UseVisualStyleBackColor = false;
            this.bAddRow.Click += new System.EventHandler(this.bAddRow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bCopyResult);
            this.groupBox2.Controls.Add(this.bSwap23Column);
            this.groupBox2.Controls.Add(this.bSwap12Column);
            this.groupBox2.Location = new System.Drawing.Point(642, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 118);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chbCompareWithEmptyCells);
            this.groupBox3.Controls.Add(this.bCompare);
            this.groupBox3.Controls.Add(this.bStop);
            this.groupBox3.Controls.Add(this.cmFilterMethod);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(640, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 127);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Расчет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simple data comparator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button bCompare;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.ComboBox cmFilterMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCopyResult;
        private System.Windows.Forms.Button bSwap12Column;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bSwap23Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chbCompareWithEmptyCells;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDelRow;
        private System.Windows.Forms.Button bAddRow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

