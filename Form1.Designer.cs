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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cmCompareMethod = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заполнитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьMACПоIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПробелыВКонцедляВсехToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравниваемоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнивающееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уникальныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПробелыВНачаледляВсехToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравниваемоеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнивающееToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уникальныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid.Location = new System.Drawing.Point(1, 27);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(633, 400);
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
            this.bCompare.Location = new System.Drawing.Point(9, 106);
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
            this.bStop.Location = new System.Drawing.Point(168, 108);
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
            this.cmFilterMethod.Location = new System.Drawing.Point(9, 29);
            this.cmFilterMethod.Name = "cmFilterMethod";
            this.cmFilterMethod.Size = new System.Drawing.Size(153, 21);
            this.cmFilterMethod.TabIndex = 3;
            this.cmFilterMethod.SelectedIndexChanged += new System.EventHandler(this.cmFilterMethod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Метод";
            // 
            // bCopyResult
            // 
            this.bCopyResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopyResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bCopyResult.Location = new System.Drawing.Point(6, 15);
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
            this.bSwap12Column.Location = new System.Drawing.Point(6, 73);
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
            this.richTextBox1.Location = new System.Drawing.Point(643, 374);
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
            this.bSwap23Column.Location = new System.Drawing.Point(6, 44);
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
            this.progressBar1.Location = new System.Drawing.Point(10, 133);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(152, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            // 
            // chbCompareWithEmptyCells
            // 
            this.chbCompareWithEmptyCells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCompareWithEmptyCells.AutoSize = true;
            this.chbCompareWithEmptyCells.Location = new System.Drawing.Point(11, 83);
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
            this.groupBox1.Location = new System.Drawing.Point(642, 184);
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
            this.groupBox2.Location = new System.Drawing.Point(640, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 102);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmCompareMethod);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chbCompareWithEmptyCells);
            this.groupBox3.Controls.Add(this.bCompare);
            this.groupBox3.Controls.Add(this.bStop);
            this.groupBox3.Controls.Add(this.cmFilterMethod);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(642, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 152);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Расчет";
            // 
            // cmCompareMethod
            // 
            this.cmCompareMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmCompareMethod.FormattingEnabled = true;
            this.cmCompareMethod.Location = new System.Drawing.Point(9, 56);
            this.cmCompareMethod.Name = "cmCompareMethod";
            this.cmCompareMethod.Size = new System.Drawing.Size(189, 21);
            this.cmCompareMethod.TabIndex = 12;
            this.cmCompareMethod.SelectedIndexChanged += new System.EventHandler(this.cmCompareMethod_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заполнитьТаблицуToolStripMenuItem,
            this.фильтрацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заполнитьТаблицуToolStripMenuItem
            // 
            this.заполнитьТаблицуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьMACПоIPToolStripMenuItem});
            this.заполнитьТаблицуToolStripMenuItem.Name = "заполнитьТаблицуToolStripMenuItem";
            this.заполнитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.заполнитьТаблицуToolStripMenuItem.Text = "Данные";
            // 
            // добавитьMACПоIPToolStripMenuItem
            // 
            this.добавитьMACПоIPToolStripMenuItem.Name = "добавитьMACПоIPToolStripMenuItem";
            this.добавитьMACПоIPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьMACПоIPToolStripMenuItem.Text = "Сетевая таблица";
            this.добавитьMACПоIPToolStripMenuItem.Click += new System.EventHandler(this.добавитьMACПоIPToolStripMenuItem_Click);
            // 
            // фильтрацияToolStripMenuItem
            // 
            this.фильтрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьПробелыВКонцедляВсехToolStripMenuItem,
            this.удалитьПробелыВНачаледляВсехToolStripMenuItem});
            this.фильтрацияToolStripMenuItem.Name = "фильтрацияToolStripMenuItem";
            this.фильтрацияToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.фильтрацияToolStripMenuItem.Text = "Операции";
            // 
            // удалитьПробелыВКонцедляВсехToolStripMenuItem
            // 
            this.удалитьПробелыВКонцедляВсехToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сравниваемоеToolStripMenuItem,
            this.сравнивающееToolStripMenuItem,
            this.уникальныеToolStripMenuItem});
            this.удалитьПробелыВКонцедляВсехToolStripMenuItem.Name = "удалитьПробелыВКонцедляВсехToolStripMenuItem";
            this.удалитьПробелыВКонцедляВсехToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.удалитьПробелыВКонцедляВсехToolStripMenuItem.Text = "Удалить пробелы в конце (для всех)";
            // 
            // сравниваемоеToolStripMenuItem
            // 
            this.сравниваемоеToolStripMenuItem.Name = "сравниваемоеToolStripMenuItem";
            this.сравниваемоеToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сравниваемоеToolStripMenuItem.Text = "Сравниваемое";
            // 
            // сравнивающееToolStripMenuItem
            // 
            this.сравнивающееToolStripMenuItem.Name = "сравнивающееToolStripMenuItem";
            this.сравнивающееToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сравнивающееToolStripMenuItem.Text = "Сравнивающее";
            // 
            // уникальныеToolStripMenuItem
            // 
            this.уникальныеToolStripMenuItem.Name = "уникальныеToolStripMenuItem";
            this.уникальныеToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.уникальныеToolStripMenuItem.Text = "Уникальные";
            // 
            // удалитьПробелыВНачаледляВсехToolStripMenuItem
            // 
            this.удалитьПробелыВНачаледляВсехToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сравниваемоеToolStripMenuItem1,
            this.сравнивающееToolStripMenuItem1,
            this.уникальныеToolStripMenuItem1});
            this.удалитьПробелыВНачаледляВсехToolStripMenuItem.Name = "удалитьПробелыВНачаледляВсехToolStripMenuItem";
            this.удалитьПробелыВНачаледляВсехToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.удалитьПробелыВНачаледляВсехToolStripMenuItem.Text = "Удалить пробелы в начале (для всех)";
            // 
            // сравниваемоеToolStripMenuItem1
            // 
            this.сравниваемоеToolStripMenuItem1.Name = "сравниваемоеToolStripMenuItem1";
            this.сравниваемоеToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.сравниваемоеToolStripMenuItem1.Text = "Сравниваемое";
            // 
            // сравнивающееToolStripMenuItem1
            // 
            this.сравнивающееToolStripMenuItem1.Name = "сравнивающееToolStripMenuItem1";
            this.сравнивающееToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.сравнивающееToolStripMenuItem1.Text = "Сравнивающее";
            // 
            // уникальныеToolStripMenuItem1
            // 
            this.уникальныеToolStripMenuItem1.Name = "уникальныеToolStripMenuItem1";
            this.уникальныеToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.уникальныеToolStripMenuItem1.Text = "Уникальные";
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple data comparator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заполнитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmCompareMethod;
        private System.Windows.Forms.ToolStripMenuItem добавитьMACПоIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПробелыВКонцедляВсехToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравниваемоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравнивающееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уникальныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПробелыВНачаледляВсехToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравниваемоеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сравнивающееToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уникальныеToolStripMenuItem1;
    }
}

