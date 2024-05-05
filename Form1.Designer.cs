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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCompare = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.cmFilterMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCopyResult = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chbCompareWithEmptyCells = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid.Location = new System.Drawing.Point(1, 0);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(633, 331);
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
            this.bCompare.Location = new System.Drawing.Point(638, 65);
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
            this.bStop.Location = new System.Drawing.Point(797, 67);
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
            this.cmFilterMethod.Location = new System.Drawing.Point(638, 15);
            this.cmFilterMethod.Name = "cmFilterMethod";
            this.cmFilterMethod.Size = new System.Drawing.Size(153, 21);
            this.cmFilterMethod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Метод";
            // 
            // bCopyResult
            // 
            this.bCopyResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopyResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bCopyResult.Location = new System.Drawing.Point(638, 191);
            this.bCopyResult.Name = "bCopyResult";
            this.bCopyResult.Size = new System.Drawing.Size(153, 23);
            this.bCopyResult.TabIndex = 5;
            this.bCopyResult.Text = "Копировать уникальные";
            this.bCopyResult.UseVisualStyleBackColor = false;
            this.bCopyResult.Click += new System.EventHandler(this.bCopyResult_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Location = new System.Drawing.Point(638, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Сравниваемое ↔ Сравнивающее";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(638, 278);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(211, 53);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button5.Location = new System.Drawing.Point(638, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Уникальные → Сравнивающее";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьЗначенияToolStripMenuItem,
            this.удалитьСтрокиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 92);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // удалитьЗначенияToolStripMenuItem
            // 
            this.удалитьЗначенияToolStripMenuItem.Name = "удалитьЗначенияToolStripMenuItem";
            this.удалитьЗначенияToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.удалитьЗначенияToolStripMenuItem.Text = "Удалить значения";
            // 
            // удалитьСтрокиToolStripMenuItem
            // 
            this.удалитьСтрокиToolStripMenuItem.Name = "удалитьСтрокиToolStripMenuItem";
            this.удалитьСтрокиToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.удалитьСтрокиToolStripMenuItem.Text = "Удалить строки";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(638, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(152, 13);
            this.progressBar1.TabIndex = 10;
            // 
            // chbCompareWithEmptyCells
            // 
            this.chbCompareWithEmptyCells.AutoSize = true;
            this.chbCompareWithEmptyCells.Location = new System.Drawing.Point(640, 42);
            this.chbCompareWithEmptyCells.Name = "chbCompareWithEmptyCells";
            this.chbCompareWithEmptyCells.Size = new System.Drawing.Size(194, 17);
            this.chbCompareWithEmptyCells.TabIndex = 11;
            this.chbCompareWithEmptyCells.Text = "Сравнивать с пустыми строками";
            this.chbCompareWithEmptyCells.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 332);
            this.Controls.Add(this.chbCompareWithEmptyCells);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bCopyResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmFilterMethod);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bCompare);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Simple comparator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокиToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chbCompareWithEmptyCells;
    }
}

