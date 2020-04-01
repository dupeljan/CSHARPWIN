namespace lab10 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WorkWithTables = new System.Windows.Forms.TabPage();
            this.UsingExpression = new System.Windows.Forms.TabPage();
            this.CreateTable = new System.Windows.Forms.Button();
            this.ValueRow = new System.Windows.Forms.Button();
            this.SortedButton = new System.Windows.Forms.Button();
            this.sortedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.WorkWithTables.SuspendLayout();
            this.UsingExpression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(518, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WorkWithTables);
            this.tabControl1.Controls.Add(this.UsingExpression);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 430);
            this.tabControl1.TabIndex = 1;
            // 
            // WorkWithTables
            // 
            this.WorkWithTables.Controls.Add(this.label2);
            this.WorkWithTables.Controls.Add(this.FilterTextBox);
            this.WorkWithTables.Controls.Add(this.button1);
            this.WorkWithTables.Controls.Add(this.label1);
            this.WorkWithTables.Controls.Add(this.sortedTextBox);
            this.WorkWithTables.Controls.Add(this.SortedButton);
            this.WorkWithTables.Controls.Add(this.ValueRow);
            this.WorkWithTables.Controls.Add(this.dataGridView1);
            this.WorkWithTables.Location = new System.Drawing.Point(4, 29);
            this.WorkWithTables.Name = "WorkWithTables";
            this.WorkWithTables.Padding = new System.Windows.Forms.Padding(3);
            this.WorkWithTables.Size = new System.Drawing.Size(531, 397);
            this.WorkWithTables.TabIndex = 0;
            this.WorkWithTables.Text = "Работа с таблицей";
            this.WorkWithTables.UseVisualStyleBackColor = true;
            // 
            // UsingExpression
            // 
            this.UsingExpression.Controls.Add(this.dataGridView3);
            this.UsingExpression.Controls.Add(this.dataGridView2);
            this.UsingExpression.Location = new System.Drawing.Point(4, 29);
            this.UsingExpression.Name = "UsingExpression";
            this.UsingExpression.Size = new System.Drawing.Size(531, 397);
            this.UsingExpression.TabIndex = 2;
            this.UsingExpression.Text = "UsingExpression";
            this.UsingExpression.UseVisualStyleBackColor = true;
            // 
            // CreateTable
            // 
            this.CreateTable.Location = new System.Drawing.Point(580, 41);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(195, 33);
            this.CreateTable.TabIndex = 1;
            this.CreateTable.Text = "Создать таблицу";
            this.CreateTable.UseVisualStyleBackColor = true;
            this.CreateTable.Click += new System.EventHandler(this.CreateTable_Click);
            // 
            // ValueRow
            // 
            this.ValueRow.Location = new System.Drawing.Point(337, 258);
            this.ValueRow.Name = "ValueRow";
            this.ValueRow.Size = new System.Drawing.Size(188, 38);
            this.ValueRow.TabIndex = 2;
            this.ValueRow.Text = "Значение ячейки";
            this.ValueRow.UseVisualStyleBackColor = true;
            this.ValueRow.Click += new System.EventHandler(this.ValueRow_Click);
            // 
            // SortedButton
            // 
            this.SortedButton.Location = new System.Drawing.Point(396, 306);
            this.SortedButton.Name = "SortedButton";
            this.SortedButton.Size = new System.Drawing.Size(129, 38);
            this.SortedButton.TabIndex = 2;
            this.SortedButton.Text = "Сортировать";
            this.SortedButton.UseVisualStyleBackColor = true;
            this.SortedButton.Click += new System.EventHandler(this.SortedButton_Click);
            // 
            // sortedTextBox
            // 
            this.sortedTextBox.Location = new System.Drawing.Point(219, 312);
            this.sortedTextBox.Name = "sortedTextBox";
            this.sortedTextBox.Size = new System.Drawing.Size(170, 26);
            this.sortedTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя поля для сортировки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Правило для фильтрации";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(219, 356);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(170, 26);
            this.FilterTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(525, 176);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 201);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(525, 176);
            this.dataGridView3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Записать в XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Прочитать из XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 455);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateTable);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.WorkWithTables.ResumeLayout(false);
            this.WorkWithTables.PerformLayout();
            this.UsingExpression.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WorkWithTables;
        private System.Windows.Forms.TabPage UsingExpression;
        private System.Windows.Forms.Button CreateTable;
        private System.Windows.Forms.Button ValueRow;
        private System.Windows.Forms.Button SortedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sortedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

