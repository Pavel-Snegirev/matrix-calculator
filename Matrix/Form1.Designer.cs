namespace Matrix
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.matrixOne = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCountCollum = new System.Windows.Forms.NumericUpDown();
            this.numCountRows = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.matrixTwo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numCollCountM2 = new System.Windows.Forms.NumericUpDown();
            this.numRowsCountM2 = new System.Windows.Forms.NumericUpDown();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountCollum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountRows)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollCountM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsCountM2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.matrixOne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numCountCollum);
            this.groupBox1.Controls.Add(this.numCountRows);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(441, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матрица 1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 405);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 441);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(417, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Найти определитель";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Заполнить случайно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matrixOne
            // 
            this.matrixOne.AllowUserToAddRows = false;
            this.matrixOne.AllowUserToDeleteRows = false;
            this.matrixOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixOne.ColumnHeadersVisible = false;
            this.matrixOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixOne.DefaultCellStyle = dataGridViewCellStyle9;
            this.matrixOne.Location = new System.Drawing.Point(12, 55);
            this.matrixOne.Margin = new System.Windows.Forms.Padding(4);
            this.matrixOne.Name = "matrixOne";
            this.matrixOne.RowHeadersVisible = false;
            this.matrixOne.RowHeadersWidth = 30;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = "0";
            this.matrixOne.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.matrixOne.RowTemplate.DefaultCellStyle.Format = "N0";
            this.matrixOne.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.matrixOne.RowTemplate.ErrorText = "Не верный формат цифр";
            this.matrixOne.Size = new System.Drawing.Size(417, 342);
            this.matrixOne.TabIndex = 4;
            this.matrixOne.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixOne_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во столбцов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во строк:";
            // 
            // numCountCollum
            // 
            this.numCountCollum.Location = new System.Drawing.Point(344, 23);
            this.numCountCollum.Margin = new System.Windows.Forms.Padding(4);
            this.numCountCollum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountCollum.Name = "numCountCollum";
            this.numCountCollum.Size = new System.Drawing.Size(85, 22);
            this.numCountCollum.TabIndex = 1;
            this.numCountCollum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountCollum.ValueChanged += new System.EventHandler(this.numCountCollum_ValueChanged);
            // 
            // numCountRows
            // 
            this.numCountRows.Location = new System.Drawing.Point(117, 23);
            this.numCountRows.Margin = new System.Windows.Forms.Padding(4);
            this.numCountRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountRows.Name = "numCountRows";
            this.numCountRows.Size = new System.Drawing.Size(85, 22);
            this.numCountRows.TabIndex = 0;
            this.numCountRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountRows.ValueChanged += new System.EventHandler(this.numCountRows_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.matrixTwo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numCollCountM2);
            this.groupBox2.Controls.Add(this.numRowsCountM2);
            this.groupBox2.Location = new System.Drawing.Point(541, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(441, 482);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Матрица 2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 405);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 405);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "Заполнить случайно";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // matrixTwo
            // 
            this.matrixTwo.AllowUserToAddRows = false;
            this.matrixTwo.AllowUserToDeleteRows = false;
            this.matrixTwo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixTwo.ColumnHeadersVisible = false;
            this.matrixTwo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = "0";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixTwo.DefaultCellStyle = dataGridViewCellStyle11;
            this.matrixTwo.Location = new System.Drawing.Point(12, 55);
            this.matrixTwo.Margin = new System.Windows.Forms.Padding(4);
            this.matrixTwo.Name = "matrixTwo";
            this.matrixTwo.RowHeadersVisible = false;
            this.matrixTwo.RowHeadersWidth = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            this.matrixTwo.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.matrixTwo.RowTemplate.DefaultCellStyle.Format = "N0";
            this.matrixTwo.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.matrixTwo.RowTemplate.ErrorText = "Не верный формат цифр";
            this.matrixTwo.Size = new System.Drawing.Size(417, 342);
            this.matrixTwo.TabIndex = 4;
            this.matrixTwo.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixOne_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во столбцов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Кол-во строк:";
            // 
            // numCollCountM2
            // 
            this.numCollCountM2.Location = new System.Drawing.Point(344, 23);
            this.numCollCountM2.Margin = new System.Windows.Forms.Padding(4);
            this.numCollCountM2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCollCountM2.Name = "numCollCountM2";
            this.numCollCountM2.Size = new System.Drawing.Size(85, 22);
            this.numCollCountM2.TabIndex = 1;
            this.numCollCountM2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCollCountM2.ValueChanged += new System.EventHandler(this.numCollCountM2_ValueChanged);
            // 
            // numRowsCountM2
            // 
            this.numRowsCountM2.Location = new System.Drawing.Point(117, 23);
            this.numRowsCountM2.Margin = new System.Windows.Forms.Padding(4);
            this.numRowsCountM2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRowsCountM2.Name = "numRowsCountM2";
            this.numRowsCountM2.Size = new System.Drawing.Size(85, 22);
            this.numRowsCountM2.TabIndex = 0;
            this.numRowsCountM2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRowsCountM2.ValueChanged += new System.EventHandler(this.numRowsCountM2_ValueChanged);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPlus.Location = new System.Drawing.Point(465, 146);
            this.bPlus.Margin = new System.Windows.Forms.Padding(4);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(68, 63);
            this.bPlus.TabIndex = 9;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMul
            // 
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMul.Location = new System.Drawing.Point(465, 233);
            this.bMul.Margin = new System.Windows.Forms.Padding(4);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(68, 63);
            this.bMul.TabIndex = 11;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(464, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 38);
            this.button5.TabIndex = 0;
            this.button5.Text = "-";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 503);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountCollum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountRows)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollCountM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsCountM2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCountCollum;
        private System.Windows.Forms.NumericUpDown numCountRows;
        private System.Windows.Forms.DataGridView matrixOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView matrixTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCollCountM2;
        private System.Windows.Forms.NumericUpDown numRowsCountM2;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button button5;
    }
}

