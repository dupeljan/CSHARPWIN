namespace lab11 {
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
            this.components = new System.ComponentModel.Container();
            this.GB_ODBC = new System.Windows.Forms.GroupBox();
            this.TB_ODBC_Path = new System.Windows.Forms.TextBox();
            this.RTB_ODBC = new System.Windows.Forms.RichTextBox();
            this.B_ODBC_Disconnect = new System.Windows.Forms.Button();
            this.B_ODBC_Add = new System.Windows.Forms.Button();
            this.B_ODBC_Connect = new System.Windows.Forms.Button();
            this.B_ODBC_Search = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.OFD_ODBC = new System.Windows.Forms.OpenFileDialog();
            this.GB_OLE_1 = new System.Windows.Forms.GroupBox();
            this.LB_OLE_1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_OLE_1_1 = new System.Windows.Forms.TextBox();
            this.TB_OLE_1_2 = new System.Windows.Forms.TextBox();
            this.TB_OLE_1_3 = new System.Windows.Forms.TextBox();
            this.TB_OLE_1_4 = new System.Windows.Forms.TextBox();
            this.TB_OLE_1_Path = new System.Windows.Forms.TextBox();
            this.B_OLE_1_Add = new System.Windows.Forms.Button();
            this.B_OLE_1_Read = new System.Windows.Forms.Button();
            this.B_OLE_1_Search = new System.Windows.Forms.Button();
            this.OFD_OLE_1 = new System.Windows.Forms.OpenFileDialog();
            this.GB_OLE_2 = new System.Windows.Forms.GroupBox();
            this.DataGridViewOLE_S = new System.Windows.Forms.DataGridView();
            this.DataGridViewOLE = new System.Windows.Forms.DataGridView();
            this.TB_OLE_2_Path = new System.Windows.Forms.TextBox();
            this.B_OLE_2_Save = new System.Windows.Forms.Button();
            this.B_OLE_2_Read = new System.Windows.Forms.Button();
            this.B_OLE_2_Search = new System.Windows.Forms.Button();
            this.OFD_OLE_2 = new System.Windows.Forms.OpenFileDialog();
            this.DataSetOLE = new System.Data.DataSet();
            this.GB_XML = new System.Windows.Forms.GroupBox();
            this.LB_XML = new System.Windows.Forms.ListBox();
            this.TB_XML_Path = new System.Windows.Forms.TextBox();
            this.B_XML_DB = new System.Windows.Forms.Button();
            this.B_XML_Read = new System.Windows.Forms.Button();
            this.B_XML_Create = new System.Windows.Forms.Button();
            this.B_XML_Search = new System.Windows.Forms.Button();
            this.SFD_XML = new System.Windows.Forms.SaveFileDialog();
            this.GB_ODBC.SuspendLayout();
            this.GB_OLE_1.SuspendLayout();
            this.GB_OLE_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOLE_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOLE)).BeginInit();
            this.GB_XML.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_ODBC
            // 
            this.GB_ODBC.Controls.Add(this.TB_ODBC_Path);
            this.GB_ODBC.Controls.Add(this.RTB_ODBC);
            this.GB_ODBC.Controls.Add(this.B_ODBC_Disconnect);
            this.GB_ODBC.Controls.Add(this.B_ODBC_Add);
            this.GB_ODBC.Controls.Add(this.B_ODBC_Connect);
            this.GB_ODBC.Controls.Add(this.B_ODBC_Search);
            this.GB_ODBC.Location = new System.Drawing.Point(12, 12);
            this.GB_ODBC.Name = "GB_ODBC";
            this.GB_ODBC.Size = new System.Drawing.Size(865, 173);
            this.GB_ODBC.TabIndex = 0;
            this.GB_ODBC.TabStop = false;
            this.GB_ODBC.Text = "ODBC";
            // 
            // TB_ODBC_Path
            // 
            this.TB_ODBC_Path.Enabled = false;
            this.TB_ODBC_Path.Location = new System.Drawing.Point(324, 22);
            this.TB_ODBC_Path.Multiline = true;
            this.TB_ODBC_Path.Name = "TB_ODBC_Path";
            this.TB_ODBC_Path.ReadOnly = true;
            this.TB_ODBC_Path.Size = new System.Drawing.Size(281, 44);
            this.TB_ODBC_Path.TabIndex = 5;
            // 
            // RTB_ODBC
            // 
            this.RTB_ODBC.Location = new System.Drawing.Point(6, 73);
            this.RTB_ODBC.Name = "RTB_ODBC";
            this.RTB_ODBC.Size = new System.Drawing.Size(599, 94);
            this.RTB_ODBC.TabIndex = 4;
            this.RTB_ODBC.Text = "";
            // 
            // B_ODBC_Disconnect
            // 
            this.B_ODBC_Disconnect.Location = new System.Drawing.Point(611, 123);
            this.B_ODBC_Disconnect.Name = "B_ODBC_Disconnect";
            this.B_ODBC_Disconnect.Size = new System.Drawing.Size(236, 44);
            this.B_ODBC_Disconnect.TabIndex = 3;
            this.B_ODBC_Disconnect.Text = "Закрыть соединение";
            this.B_ODBC_Disconnect.UseVisualStyleBackColor = true;
            this.B_ODBC_Disconnect.Click += new System.EventHandler(this.B_ODBC_Disconnect_Click);
            // 
            // B_ODBC_Add
            // 
            this.B_ODBC_Add.Location = new System.Drawing.Point(611, 73);
            this.B_ODBC_Add.Name = "B_ODBC_Add";
            this.B_ODBC_Add.Size = new System.Drawing.Size(236, 44);
            this.B_ODBC_Add.TabIndex = 2;
            this.B_ODBC_Add.Text = "Добавить запись";
            this.B_ODBC_Add.UseVisualStyleBackColor = true;
            this.B_ODBC_Add.Click += new System.EventHandler(this.B_ODBC_Add_Click);
            // 
            // B_ODBC_Connect
            // 
            this.B_ODBC_Connect.Location = new System.Drawing.Point(611, 22);
            this.B_ODBC_Connect.Name = "B_ODBC_Connect";
            this.B_ODBC_Connect.Size = new System.Drawing.Size(236, 44);
            this.B_ODBC_Connect.TabIndex = 1;
            this.B_ODBC_Connect.Text = "Открыть соединение";
            this.B_ODBC_Connect.UseVisualStyleBackColor = true;
            this.B_ODBC_Connect.Click += new System.EventHandler(this.B_ODBC_Connect_Click);
            // 
            // B_ODBC_Search
            // 
            this.B_ODBC_Search.Location = new System.Drawing.Point(6, 22);
            this.B_ODBC_Search.Name = "B_ODBC_Search";
            this.B_ODBC_Search.Size = new System.Drawing.Size(312, 44);
            this.B_ODBC_Search.TabIndex = 0;
            this.B_ODBC_Search.Text = "Выбрать базу данных(*.mdb)";
            this.B_ODBC_Search.UseVisualStyleBackColor = true;
            this.B_ODBC_Search.Click += new System.EventHandler(this.B_ODBC_Search_Click);
            // 
            // OFD_ODBC
            // 
            this.OFD_ODBC.FileName = "openFileDialog1";
            this.OFD_ODBC.Filter = "База данных *.mdb|*.mdb";
            // 
            // GB_OLE_1
            // 
            this.GB_OLE_1.Controls.Add(this.LB_OLE_1);
            this.GB_OLE_1.Controls.Add(this.label4);
            this.GB_OLE_1.Controls.Add(this.label3);
            this.GB_OLE_1.Controls.Add(this.label2);
            this.GB_OLE_1.Controls.Add(this.label1);
            this.GB_OLE_1.Controls.Add(this.TB_OLE_1_1);
            this.GB_OLE_1.Controls.Add(this.TB_OLE_1_2);
            this.GB_OLE_1.Controls.Add(this.TB_OLE_1_3);
            this.GB_OLE_1.Controls.Add(this.TB_OLE_1_4);
            this.GB_OLE_1.Controls.Add(this.TB_OLE_1_Path);
            this.GB_OLE_1.Controls.Add(this.B_OLE_1_Add);
            this.GB_OLE_1.Controls.Add(this.B_OLE_1_Read);
            this.GB_OLE_1.Controls.Add(this.B_OLE_1_Search);
            this.GB_OLE_1.Location = new System.Drawing.Point(12, 191);
            this.GB_OLE_1.Name = "GB_OLE_1";
            this.GB_OLE_1.Size = new System.Drawing.Size(865, 214);
            this.GB_OLE_1.TabIndex = 1;
            this.GB_OLE_1.TabStop = false;
            this.GB_OLE_1.Text = "OLE 1";
            // 
            // LB_OLE_1
            // 
            this.LB_OLE_1.FormattingEnabled = true;
            this.LB_OLE_1.ItemHeight = 20;
            this.LB_OLE_1.Location = new System.Drawing.Point(274, 78);
            this.LB_OLE_1.Name = "LB_OLE_1";
            this.LB_OLE_1.Size = new System.Drawing.Size(331, 124);
            this.LB_OLE_1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Третье поле :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Второе поле :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Первое поле :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ключевое поле :";
            // 
            // TB_OLE_1_1
            // 
            this.TB_OLE_1_1.Location = new System.Drawing.Point(156, 78);
            this.TB_OLE_1_1.Name = "TB_OLE_1_1";
            this.TB_OLE_1_1.Size = new System.Drawing.Size(100, 26);
            this.TB_OLE_1_1.TabIndex = 8;
            // 
            // TB_OLE_1_2
            // 
            this.TB_OLE_1_2.Location = new System.Drawing.Point(156, 110);
            this.TB_OLE_1_2.Name = "TB_OLE_1_2";
            this.TB_OLE_1_2.Size = new System.Drawing.Size(100, 26);
            this.TB_OLE_1_2.TabIndex = 7;
            // 
            // TB_OLE_1_3
            // 
            this.TB_OLE_1_3.Location = new System.Drawing.Point(156, 142);
            this.TB_OLE_1_3.Name = "TB_OLE_1_3";
            this.TB_OLE_1_3.Size = new System.Drawing.Size(100, 26);
            this.TB_OLE_1_3.TabIndex = 6;
            // 
            // TB_OLE_1_4
            // 
            this.TB_OLE_1_4.Location = new System.Drawing.Point(156, 174);
            this.TB_OLE_1_4.Name = "TB_OLE_1_4";
            this.TB_OLE_1_4.Size = new System.Drawing.Size(100, 26);
            this.TB_OLE_1_4.TabIndex = 5;
            // 
            // TB_OLE_1_Path
            // 
            this.TB_OLE_1_Path.Enabled = false;
            this.TB_OLE_1_Path.Location = new System.Drawing.Point(274, 22);
            this.TB_OLE_1_Path.Multiline = true;
            this.TB_OLE_1_Path.Name = "TB_OLE_1_Path";
            this.TB_OLE_1_Path.ReadOnly = true;
            this.TB_OLE_1_Path.Size = new System.Drawing.Size(331, 47);
            this.TB_OLE_1_Path.TabIndex = 3;
            // 
            // B_OLE_1_Add
            // 
            this.B_OLE_1_Add.Location = new System.Drawing.Point(611, 75);
            this.B_OLE_1_Add.Name = "B_OLE_1_Add";
            this.B_OLE_1_Add.Size = new System.Drawing.Size(236, 47);
            this.B_OLE_1_Add.TabIndex = 2;
            this.B_OLE_1_Add.Text = "Добавить записи";
            this.B_OLE_1_Add.UseVisualStyleBackColor = true;
            this.B_OLE_1_Add.Click += new System.EventHandler(this.B_OLE_1_Add_Click);
            // 
            // B_OLE_1_Read
            // 
            this.B_OLE_1_Read.Location = new System.Drawing.Point(611, 22);
            this.B_OLE_1_Read.Name = "B_OLE_1_Read";
            this.B_OLE_1_Read.Size = new System.Drawing.Size(236, 47);
            this.B_OLE_1_Read.TabIndex = 1;
            this.B_OLE_1_Read.Text = "Прочитать все записи";
            this.B_OLE_1_Read.UseVisualStyleBackColor = true;
            this.B_OLE_1_Read.Click += new System.EventHandler(this.B_OLE_1_Read_Click);
            // 
            // B_OLE_1_Search
            // 
            this.B_OLE_1_Search.Location = new System.Drawing.Point(6, 22);
            this.B_OLE_1_Search.Name = "B_OLE_1_Search";
            this.B_OLE_1_Search.Size = new System.Drawing.Size(250, 47);
            this.B_OLE_1_Search.TabIndex = 0;
            this.B_OLE_1_Search.Text = "Выбрать базу данных";
            this.B_OLE_1_Search.UseVisualStyleBackColor = true;
            this.B_OLE_1_Search.Click += new System.EventHandler(this.B_OLE_1_Search_Click);
            // 
            // OFD_OLE_1
            // 
            this.OFD_OLE_1.FileName = "openFileDialog1";
            this.OFD_OLE_1.Filter = "База данных *.mdb|*.mdb|База данных *.accdb|*.accdb";
            // 
            // GB_OLE_2
            // 
            this.GB_OLE_2.Controls.Add(this.DataGridViewOLE_S);
            this.GB_OLE_2.Controls.Add(this.DataGridViewOLE);
            this.GB_OLE_2.Controls.Add(this.TB_OLE_2_Path);
            this.GB_OLE_2.Controls.Add(this.B_OLE_2_Save);
            this.GB_OLE_2.Controls.Add(this.B_OLE_2_Read);
            this.GB_OLE_2.Controls.Add(this.B_OLE_2_Search);
            this.GB_OLE_2.Location = new System.Drawing.Point(12, 420);
            this.GB_OLE_2.Name = "GB_OLE_2";
            this.GB_OLE_2.Size = new System.Drawing.Size(865, 277);
            this.GB_OLE_2.TabIndex = 2;
            this.GB_OLE_2.TabStop = false;
            this.GB_OLE_2.Text = "OLE 2";
            // 
            // DataGridViewOLE_S
            // 
            this.DataGridViewOLE_S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOLE_S.Location = new System.Drawing.Point(425, 72);
            this.DataGridViewOLE_S.Name = "DataGridViewOLE_S";
            this.DataGridViewOLE_S.RowHeadersWidth = 62;
            this.DataGridViewOLE_S.RowTemplate.Height = 28;
            this.DataGridViewOLE_S.Size = new System.Drawing.Size(434, 189);
            this.DataGridViewOLE_S.TabIndex = 5;
            // 
            // DataGridViewOLE
            // 
            this.DataGridViewOLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOLE.Location = new System.Drawing.Point(6, 72);
            this.DataGridViewOLE.Name = "DataGridViewOLE";
            this.DataGridViewOLE.RowHeadersWidth = 62;
            this.DataGridViewOLE.RowTemplate.Height = 28;
            this.DataGridViewOLE.Size = new System.Drawing.Size(413, 189);
            this.DataGridViewOLE.TabIndex = 4;
            // 
            // TB_OLE_2_Path
            // 
            this.TB_OLE_2_Path.Enabled = false;
            this.TB_OLE_2_Path.Location = new System.Drawing.Point(203, 25);
            this.TB_OLE_2_Path.Multiline = true;
            this.TB_OLE_2_Path.Name = "TB_OLE_2_Path";
            this.TB_OLE_2_Path.ReadOnly = true;
            this.TB_OLE_2_Path.Size = new System.Drawing.Size(291, 41);
            this.TB_OLE_2_Path.TabIndex = 3;
            // 
            // B_OLE_2_Save
            // 
            this.B_OLE_2_Save.Location = new System.Drawing.Point(701, 25);
            this.B_OLE_2_Save.Name = "B_OLE_2_Save";
            this.B_OLE_2_Save.Size = new System.Drawing.Size(158, 41);
            this.B_OLE_2_Save.TabIndex = 2;
            this.B_OLE_2_Save.Text = "Сохранить записи";
            this.B_OLE_2_Save.UseVisualStyleBackColor = true;
            this.B_OLE_2_Save.Click += new System.EventHandler(this.B_OLE_2_Save_Click);
            // 
            // B_OLE_2_Read
            // 
            this.B_OLE_2_Read.Location = new System.Drawing.Point(500, 25);
            this.B_OLE_2_Read.Name = "B_OLE_2_Read";
            this.B_OLE_2_Read.Size = new System.Drawing.Size(195, 41);
            this.B_OLE_2_Read.TabIndex = 1;
            this.B_OLE_2_Read.Text = "Прочитать все записи";
            this.B_OLE_2_Read.UseVisualStyleBackColor = true;
            this.B_OLE_2_Read.Click += new System.EventHandler(this.B_OLE_2_Read_Click);
            // 
            // B_OLE_2_Search
            // 
            this.B_OLE_2_Search.Location = new System.Drawing.Point(6, 25);
            this.B_OLE_2_Search.Name = "B_OLE_2_Search";
            this.B_OLE_2_Search.Size = new System.Drawing.Size(191, 41);
            this.B_OLE_2_Search.TabIndex = 0;
            this.B_OLE_2_Search.Text = "Выбрать базу данных";
            this.B_OLE_2_Search.UseVisualStyleBackColor = true;
            this.B_OLE_2_Search.Click += new System.EventHandler(this.B_OLE_2_Search_Click);
            // 
            // OFD_OLE_2
            // 
            this.OFD_OLE_2.FileName = "openFileDialog1";
            this.OFD_OLE_2.Filter = "База данных *.mdb|*.mdb|База данных *.accdb|*.accdb";
            // 
            // DataSetOLE
            // 
            this.DataSetOLE.DataSetName = "NewDataSet";
            // 
            // GB_XML
            // 
            this.GB_XML.Controls.Add(this.LB_XML);
            this.GB_XML.Controls.Add(this.TB_XML_Path);
            this.GB_XML.Controls.Add(this.B_XML_DB);
            this.GB_XML.Controls.Add(this.B_XML_Read);
            this.GB_XML.Controls.Add(this.B_XML_Create);
            this.GB_XML.Controls.Add(this.B_XML_Search);
            this.GB_XML.Location = new System.Drawing.Point(12, 703);
            this.GB_XML.Name = "GB_XML";
            this.GB_XML.Size = new System.Drawing.Size(865, 191);
            this.GB_XML.TabIndex = 3;
            this.GB_XML.TabStop = false;
            this.GB_XML.Text = "XML";
            // 
            // LB_XML
            // 
            this.LB_XML.FormattingEnabled = true;
            this.LB_XML.ItemHeight = 20;
            this.LB_XML.Location = new System.Drawing.Point(3, 73);
            this.LB_XML.Name = "LB_XML";
            this.LB_XML.Size = new System.Drawing.Size(598, 104);
            this.LB_XML.TabIndex = 5;
            // 
            // TB_XML_Path
            // 
            this.TB_XML_Path.Enabled = false;
            this.TB_XML_Path.Location = new System.Drawing.Point(262, 22);
            this.TB_XML_Path.Multiline = true;
            this.TB_XML_Path.Name = "TB_XML_Path";
            this.TB_XML_Path.ReadOnly = true;
            this.TB_XML_Path.Size = new System.Drawing.Size(339, 45);
            this.TB_XML_Path.TabIndex = 4;
            // 
            // B_XML_DB
            // 
            this.B_XML_DB.Location = new System.Drawing.Point(607, 127);
            this.B_XML_DB.Name = "B_XML_DB";
            this.B_XML_DB.Size = new System.Drawing.Size(252, 48);
            this.B_XML_DB.TabIndex = 3;
            this.B_XML_DB.Text = "База данных обоев";
            this.B_XML_DB.UseVisualStyleBackColor = true;
            this.B_XML_DB.Click += new System.EventHandler(this.B_XML_DB_Click);
            // 
            // B_XML_Read
            // 
            this.B_XML_Read.Location = new System.Drawing.Point(607, 73);
            this.B_XML_Read.Name = "B_XML_Read";
            this.B_XML_Read.Size = new System.Drawing.Size(252, 48);
            this.B_XML_Read.TabIndex = 2;
            this.B_XML_Read.Text = "Прочитать простой документ";
            this.B_XML_Read.UseVisualStyleBackColor = true;
            this.B_XML_Read.Click += new System.EventHandler(this.B_XML_Read_Click);
            // 
            // B_XML_Create
            // 
            this.B_XML_Create.Location = new System.Drawing.Point(607, 22);
            this.B_XML_Create.Name = "B_XML_Create";
            this.B_XML_Create.Size = new System.Drawing.Size(252, 45);
            this.B_XML_Create.TabIndex = 1;
            this.B_XML_Create.Text = "Создать простой документ";
            this.B_XML_Create.UseVisualStyleBackColor = true;
            this.B_XML_Create.Click += new System.EventHandler(this.B_XML_Create_Click);
            // 
            // B_XML_Search
            // 
            this.B_XML_Search.Location = new System.Drawing.Point(3, 22);
            this.B_XML_Search.Name = "B_XML_Search";
            this.B_XML_Search.Size = new System.Drawing.Size(253, 45);
            this.B_XML_Search.TabIndex = 0;
            this.B_XML_Search.Text = "Выбрать место сохранения";
            this.B_XML_Search.UseVisualStyleBackColor = true;
            this.B_XML_Search.Click += new System.EventHandler(this.B_XML_Search_Click);
            // 
            // SFD_XML
            // 
            this.SFD_XML.FileName = "XML-Test";
            this.SFD_XML.Filter = "XML-файл|*.xml";
            this.SFD_XML.InitialDirectory = "C:\\Users\\Ibrag\\Desktop\\C#\\Lab Works\\Programms\\lab11\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(889, 908);
            this.Controls.Add(this.GB_XML);
            this.Controls.Add(this.GB_OLE_2);
            this.Controls.Add(this.GB_OLE_1);
            this.Controls.Add(this.GB_ODBC);
            this.Name = "Form1";
            this.Text = "Работа с базами данных в C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_ODBC.ResumeLayout(false);
            this.GB_ODBC.PerformLayout();
            this.GB_OLE_1.ResumeLayout(false);
            this.GB_OLE_1.PerformLayout();
            this.GB_OLE_2.ResumeLayout(false);
            this.GB_OLE_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOLE_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOLE)).EndInit();
            this.GB_XML.ResumeLayout(false);
            this.GB_XML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_ODBC;
        private System.Windows.Forms.TextBox TB_ODBC_Path;
        private System.Windows.Forms.RichTextBox RTB_ODBC;
        private System.Windows.Forms.Button B_ODBC_Disconnect;
        private System.Windows.Forms.Button B_ODBC_Add;
        private System.Windows.Forms.Button B_ODBC_Connect;
        private System.Windows.Forms.Button B_ODBC_Search;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.OpenFileDialog OFD_ODBC;
        private System.Windows.Forms.GroupBox GB_OLE_1;
        private System.Windows.Forms.TextBox TB_OLE_1_Path;
        private System.Windows.Forms.Button B_OLE_1_Add;
        private System.Windows.Forms.Button B_OLE_1_Read;
        private System.Windows.Forms.Button B_OLE_1_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_OLE_1_1;
        private System.Windows.Forms.TextBox TB_OLE_1_2;
        private System.Windows.Forms.TextBox TB_OLE_1_3;
        private System.Windows.Forms.TextBox TB_OLE_1_4;
        private System.Windows.Forms.ListBox LB_OLE_1;
        private System.Windows.Forms.OpenFileDialog OFD_OLE_1;
        private System.Windows.Forms.GroupBox GB_OLE_2;
        private System.Windows.Forms.DataGridView DataGridViewOLE_S;
        private System.Windows.Forms.DataGridView DataGridViewOLE;
        private System.Windows.Forms.TextBox TB_OLE_2_Path;
        private System.Windows.Forms.Button B_OLE_2_Save;
        private System.Windows.Forms.Button B_OLE_2_Read;
        private System.Windows.Forms.Button B_OLE_2_Search;
        private System.Windows.Forms.OpenFileDialog OFD_OLE_2;
        private System.Data.DataSet DataSetOLE;
        private System.Windows.Forms.GroupBox GB_XML;
        private System.Windows.Forms.TextBox TB_XML_Path;
        private System.Windows.Forms.Button B_XML_DB;
        private System.Windows.Forms.Button B_XML_Read;
        private System.Windows.Forms.Button B_XML_Create;
        private System.Windows.Forms.Button B_XML_Search;
        private System.Windows.Forms.ListBox LB_XML;
        private System.Windows.Forms.SaveFileDialog SFD_XML;
    }
}

