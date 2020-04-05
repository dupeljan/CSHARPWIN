namespace BattleShip0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChangeGameState = new System.Windows.Forms.Button();
            this.groupBoxInit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFillRandom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonBot = new System.Windows.Forms.Button();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.fieldAlly = new BattleShip0.Field();
            this.fieldEnemy = new BattleShip0.Field();
            this.SuspendLayout();
            // 
            // buttonChangeGameState
            // 
            this.buttonChangeGameState.Location = new System.Drawing.Point(903, 418);
            this.buttonChangeGameState.Name = "buttonChangeGameState";
            this.buttonChangeGameState.Size = new System.Drawing.Size(217, 54);
            this.buttonChangeGameState.TabIndex = 2;
            this.buttonChangeGameState.Text = "button1";
            this.buttonChangeGameState.UseVisualStyleBackColor = true;
            this.buttonChangeGameState.Click += new System.EventHandler(this.buttonChangeGameState_Click);
            // 
            // groupBoxInit
            // 
            this.groupBoxInit.Location = new System.Drawing.Point(919, 37);
            this.groupBoxInit.Name = "groupBoxInit";
            this.groupBoxInit.Size = new System.Drawing.Size(191, 299);
            this.groupBoxInit.TabIndex = 2;
            this.groupBoxInit.TabStop = false;
            this.groupBoxInit.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(426, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelStatus.Location = new System.Drawing.Point(552, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(75, 45);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "init";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1076, 356);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(63, 56);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFillRandom
            // 
            this.buttonFillRandom.Location = new System.Drawing.Point(998, 356);
            this.buttonFillRandom.Name = "buttonFillRandom";
            this.buttonFillRandom.Size = new System.Drawing.Size(72, 56);
            this.buttonFillRandom.TabIndex = 6;
            this.buttonFillRandom.Text = "Fill random";
            this.buttonFillRandom.UseVisualStyleBackColor = true;
            this.buttonFillRandom.Click += new System.EventHandler(this.buttonFillRandom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "ButtleShip!";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(45, 473);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(98, 35);
            this.buttonConnect.TabIndex = 10;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(264, 473);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(149, 35);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Create shared game";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonBot
            // 
            this.buttonBot.Location = new System.Drawing.Point(434, 473);
            this.buttonBot.Name = "buttonBot";
            this.buttonBot.Size = new System.Drawing.Size(98, 35);
            this.buttonBot.TabIndex = 12;
            this.buttonBot.Text = "Play vs bot";
            this.buttonBot.UseVisualStyleBackColor = true;
            this.buttonBot.Click += new System.EventHandler(this.buttonBot_Click);
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(149, 479);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxIpAddress.TabIndex = 13;
            this.textBoxIpAddress.Text = "localhost";
            // 
            // fieldAlly
            // 
            this.fieldAlly.Location = new System.Drawing.Point(464, 48);
            this.fieldAlly.Name = "fieldAlly";
            this.fieldAlly.Size = new System.Drawing.Size(292, 222);
            this.fieldAlly.TabIndex = 8;
            this.fieldAlly.TabStop = false;
            this.fieldAlly.Text = "Ally field";
            // 
            // fieldEnemy
            // 
            this.fieldEnemy.Location = new System.Drawing.Point(34, 48);
            this.fieldEnemy.Name = "fieldEnemy";
            this.fieldEnemy.Size = new System.Drawing.Size(292, 222);
            this.fieldEnemy.TabIndex = 7;
            this.fieldEnemy.TabStop = false;
            this.fieldEnemy.Text = "Enemy field";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 520);
            this.Controls.Add(this.textBoxIpAddress);
            this.Controls.Add(this.buttonBot);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldAlly);
            this.Controls.Add(this.fieldEnemy);
            this.Controls.Add(this.buttonFillRandom);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxInit);
            this.Controls.Add(this.buttonChangeGameState);
            this.Name = "Form1";
            this.Text = "BattleShip by @dupeljan";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChangeGameState;
        private System.Windows.Forms.GroupBox groupBoxInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonFillRandom;
        private Field fieldEnemy;
        private Field fieldAlly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonBot;
        private System.Windows.Forms.TextBox textBoxIpAddress;
    }
}

