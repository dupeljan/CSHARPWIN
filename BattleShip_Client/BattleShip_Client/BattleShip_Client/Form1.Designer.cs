namespace BattleShip_Client {
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
            this.stopConnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.socketTextBox = new System.Windows.Forms.TextBox();
            this.reBuildYourBoard = new System.Windows.Forms.Button();
            this.groupBoxOpponentBoard = new System.Windows.Forms.GroupBox();
            this.groupBoxYourBoard = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // stopConnectButton
            // 
            this.stopConnectButton.Enabled = false;
            this.stopConnectButton.Location = new System.Drawing.Point(450, 507);
            this.stopConnectButton.Name = "stopConnectButton";
            this.stopConnectButton.Size = new System.Drawing.Size(158, 41);
            this.stopConnectButton.TabIndex = 9;
            this.stopConnectButton.Text = "Остановить";
            this.stopConnectButton.UseVisualStyleBackColor = true;
            this.stopConnectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(286, 507);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(158, 41);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Соединиться";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // socketTextBox
            // 
            this.socketTextBox.Location = new System.Drawing.Point(19, 522);
            this.socketTextBox.Name = "socketTextBox";
            this.socketTextBox.Size = new System.Drawing.Size(246, 26);
            this.socketTextBox.TabIndex = 11;
            // 
            // reBuildYourBoard
            // 
            this.reBuildYourBoard.Location = new System.Drawing.Point(753, 3);
            this.reBuildYourBoard.Name = "reBuildYourBoard";
            this.reBuildYourBoard.Size = new System.Drawing.Size(125, 37);
            this.reBuildYourBoard.TabIndex = 14;
            this.reBuildYourBoard.Text = "Перестроить";
            this.reBuildYourBoard.UseVisualStyleBackColor = true;
            this.reBuildYourBoard.Click += new System.EventHandler(this.reBuildYourBoard_Click);
            // 
            // groupBoxOpponentBoard
            // 
            this.groupBoxOpponentBoard.Location = new System.Drawing.Point(12, 36);
            this.groupBoxOpponentBoard.Name = "groupBoxOpponentBoard";
            this.groupBoxOpponentBoard.Size = new System.Drawing.Size(426, 455);
            this.groupBoxOpponentBoard.TabIndex = 12;
            this.groupBoxOpponentBoard.TabStop = false;
            this.groupBoxOpponentBoard.Text = "Игровое поле противника";
            // 
            // groupBoxYourBoard
            // 
            this.groupBoxYourBoard.Location = new System.Drawing.Point(452, 36);
            this.groupBoxYourBoard.Name = "groupBoxYourBoard";
            this.groupBoxYourBoard.Size = new System.Drawing.Size(426, 455);
            this.groupBoxYourBoard.TabIndex = 13;
            this.groupBoxYourBoard.TabStop = false;
            this.groupBoxYourBoard.Text = "Ваше игровое поле";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Введите хост и порт";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reBuildYourBoard);
            this.Controls.Add(this.groupBoxOpponentBoard);
            this.Controls.Add(this.groupBoxYourBoard);
            this.Controls.Add(this.socketTextBox);
            this.Controls.Add(this.stopConnectButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stopConnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox socketTextBox;
        private System.Windows.Forms.Button reBuildYourBoard;
        private System.Windows.Forms.GroupBox groupBoxOpponentBoard;
        private System.Windows.Forms.GroupBox groupBoxYourBoard;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

