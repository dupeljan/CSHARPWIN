namespace lab11 {
    partial class LWP10Wallpapper {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.B_OPEN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_MAIN = new System.Windows.Forms.PictureBox();
            this.TB_NUMBER = new System.Windows.Forms.TextBox();
            this.B_SAVE = new System.Windows.Forms.Button();
            this.B_SEARCH = new System.Windows.Forms.Button();
            this.TB_FORMAT = new System.Windows.Forms.TextBox();
            this.TB_SIZE = new System.Windows.Forms.TextBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.L_NAME = new System.Windows.Forms.Label();
            this.L_SIZE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OFD_FIND = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAIN)).BeginInit();
            this.SuspendLayout();
            // 
            // B_OPEN
            // 
            this.B_OPEN.Location = new System.Drawing.Point(576, 12);
            this.B_OPEN.Name = "B_OPEN";
            this.B_OPEN.Size = new System.Drawing.Size(212, 42);
            this.B_OPEN.TabIndex = 0;
            this.B_OPEN.Text = "Выбрать рисунок";
            this.B_OPEN.UseVisualStyleBackColor = true;
            this.B_OPEN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите номер рисунка";
            // 
            // PB_MAIN
            // 
            this.PB_MAIN.Location = new System.Drawing.Point(16, 63);
            this.PB_MAIN.Name = "PB_MAIN";
            this.PB_MAIN.Size = new System.Drawing.Size(772, 442);
            this.PB_MAIN.TabIndex = 2;
            this.PB_MAIN.TabStop = false;
            // 
            // TB_NUMBER
            // 
            this.TB_NUMBER.Location = new System.Drawing.Point(208, 12);
            this.TB_NUMBER.Multiline = true;
            this.TB_NUMBER.Name = "TB_NUMBER";
            this.TB_NUMBER.Size = new System.Drawing.Size(362, 42);
            this.TB_NUMBER.TabIndex = 3;
            this.TB_NUMBER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NUMBER_KeyPress);
            // 
            // B_SAVE
            // 
            this.B_SAVE.Location = new System.Drawing.Point(501, 669);
            this.B_SAVE.Name = "B_SAVE";
            this.B_SAVE.Size = new System.Drawing.Size(287, 39);
            this.B_SAVE.TabIndex = 4;
            this.B_SAVE.Text = "Сохранить рисунок в базе данных";
            this.B_SAVE.UseVisualStyleBackColor = true;
            this.B_SAVE.Click += new System.EventHandler(this.B_SAVE_Click);
            // 
            // B_SEARCH
            // 
            this.B_SEARCH.Location = new System.Drawing.Point(16, 616);
            this.B_SEARCH.Name = "B_SEARCH";
            this.B_SEARCH.Size = new System.Drawing.Size(307, 42);
            this.B_SEARCH.TabIndex = 5;
            this.B_SEARCH.Text = "Выбрать рисунок для добавления";
            this.B_SEARCH.UseVisualStyleBackColor = true;
            this.B_SEARCH.Click += new System.EventHandler(this.B_SEARCH_Click);
            // 
            // TB_FORMAT
            // 
            this.TB_FORMAT.Location = new System.Drawing.Point(655, 511);
            this.TB_FORMAT.Multiline = true;
            this.TB_FORMAT.Name = "TB_FORMAT";
            this.TB_FORMAT.Size = new System.Drawing.Size(133, 39);
            this.TB_FORMAT.TabIndex = 6;
            // 
            // TB_SIZE
            // 
            this.TB_SIZE.Location = new System.Drawing.Point(655, 616);
            this.TB_SIZE.Multiline = true;
            this.TB_SIZE.Name = "TB_SIZE";
            this.TB_SIZE.ReadOnly = true;
            this.TB_SIZE.Size = new System.Drawing.Size(133, 42);
            this.TB_SIZE.TabIndex = 7;
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(121, 669);
            this.TB_NAME.Multiline = true;
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(202, 39);
            this.TB_NAME.TabIndex = 8;
            // 
            // L_NAME
            // 
            this.L_NAME.AutoSize = true;
            this.L_NAME.Location = new System.Drawing.Point(12, 524);
            this.L_NAME.Name = "L_NAME";
            this.L_NAME.Size = new System.Drawing.Size(96, 20);
            this.L_NAME.TabIndex = 9;
            this.L_NAME.Text = "Имя файла";
            // 
            // L_SIZE
            // 
            this.L_SIZE.AutoSize = true;
            this.L_SIZE.Location = new System.Drawing.Point(12, 563);
            this.L_SIZE.Name = "L_SIZE";
            this.L_SIZE.Size = new System.Drawing.Size(166, 20);
            this.L_SIZE.TabIndex = 10;
            this.L_SIZE.Text = "Разрешение рисунка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Формат рисунка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 679);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Имя рисунка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Разрешение рисунка";
            // 
            // OFD_FIND
            // 
            this.OFD_FIND.FileName = "openFileDialog1";
            this.OFD_FIND.Filter = "GIF-файлы|*.gif|BMP-файлы|*.bmp|JPEG-файлы|*.jpg";
            this.OFD_FIND.InitialDirectory = "C:\\Users\\Ibrag\\Desktop\\C#\\Lab Works\\Programms\\lab11\\";
            // 
            // LWP10Wallpapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 720);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L_SIZE);
            this.Controls.Add(this.L_NAME);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.TB_SIZE);
            this.Controls.Add(this.TB_FORMAT);
            this.Controls.Add(this.B_SEARCH);
            this.Controls.Add(this.B_SAVE);
            this.Controls.Add(this.TB_NUMBER);
            this.Controls.Add(this.PB_MAIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_OPEN);
            this.Name = "LWP10Wallpapper";
            this.Text = "Работа с базами данных (C#) :: База данных обоев";
            this.Load += new System.EventHandler(this.LWP10Wallpapper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_OPEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_MAIN;
        private System.Windows.Forms.TextBox TB_NUMBER;
        private System.Windows.Forms.Button B_SAVE;
        private System.Windows.Forms.Button B_SEARCH;
        private System.Windows.Forms.TextBox TB_FORMAT;
        private System.Windows.Forms.TextBox TB_SIZE;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label L_NAME;
        private System.Windows.Forms.Label L_SIZE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog OFD_FIND;
    }
}