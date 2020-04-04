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
            this.fieldAlly = new BattleShip0.Field();
            this.fieldEnemy = new BattleShip0.Field();
            this.SuspendLayout();
            // 
            // buttonChangeGameState
            // 
            this.buttonChangeGameState.Location = new System.Drawing.Point(893, 394);
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
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(889, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(960, 355);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 20);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "init";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1069, 352);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFillRandom
            // 
            this.buttonFillRandom.Location = new System.Drawing.Point(941, 8);
            this.buttonFillRandom.Name = "buttonFillRandom";
            this.buttonFillRandom.Size = new System.Drawing.Size(132, 23);
            this.buttonFillRandom.TabIndex = 6;
            this.buttonFillRandom.Text = "Fill random";
            this.buttonFillRandom.UseVisualStyleBackColor = true;
            this.buttonFillRandom.Click += new System.EventHandler(this.buttonFillRandom_Click);
            // 
            // fieldAlly
            // 
            this.fieldAlly.Location = new System.Drawing.Point(462, 37);
            this.fieldAlly.Name = "fieldAlly";
            this.fieldAlly.Size = new System.Drawing.Size(292, 222);
            this.fieldAlly.TabIndex = 8;
            this.fieldAlly.TabStop = false;
            this.fieldAlly.Text = "Ally field";
            // 
            // fieldEnemy
            // 
            this.fieldEnemy.Location = new System.Drawing.Point(33, 37);
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
            this.ClientSize = new System.Drawing.Size(1145, 460);
            this.Controls.Add(this.fieldAlly);
            this.Controls.Add(this.fieldEnemy);
            this.Controls.Add(this.buttonFillRandom);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxInit);
            this.Controls.Add(this.buttonChangeGameState);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

