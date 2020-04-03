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
            this.groupBoxEnemy = new System.Windows.Forms.GroupBox();
            this.groupBoxAlly = new System.Windows.Forms.GroupBox();
            this.buttonChangeGameState = new System.Windows.Forms.Button();
            this.groupBoxInit = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxEnemy
            // 
            this.groupBoxEnemy.Location = new System.Drawing.Point(33, 37);
            this.groupBoxEnemy.Name = "groupBoxEnemy";
            this.groupBoxEnemy.Size = new System.Drawing.Size(374, 299);
            this.groupBoxEnemy.TabIndex = 0;
            this.groupBoxEnemy.TabStop = false;
            this.groupBoxEnemy.Text = "groupBox1";
            // 
            // groupBoxAlly
            // 
            this.groupBoxAlly.Location = new System.Drawing.Point(475, 37);
            this.groupBoxAlly.Name = "groupBoxAlly";
            this.groupBoxAlly.Size = new System.Drawing.Size(374, 299);
            this.groupBoxAlly.TabIndex = 1;
            this.groupBoxAlly.TabStop = false;
            this.groupBoxAlly.Text = "groupBox1";
            // 
            // buttonChangeGameState
            // 
            this.buttonChangeGameState.Location = new System.Drawing.Point(984, 380);
            this.buttonChangeGameState.Name = "buttonChangeGameState";
            this.buttonChangeGameState.Size = new System.Drawing.Size(93, 39);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 460);
            this.Controls.Add(this.groupBoxInit);
            this.Controls.Add(this.buttonChangeGameState);
            this.Controls.Add(this.groupBoxAlly);
            this.Controls.Add(this.groupBoxEnemy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEnemy;
        private System.Windows.Forms.GroupBox groupBoxAlly;
        private System.Windows.Forms.Button buttonChangeGameState;
        private System.Windows.Forms.GroupBox groupBoxInit;
    }
}

