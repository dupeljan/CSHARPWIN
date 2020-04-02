namespace Life0
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxGameField = new System.Windows.Forms.PictureBox();
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAlive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDied = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.labelEntitySum = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMindState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
            this.buttonPartner = new System.Windows.Forms.Button();
            this.buttonClever = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGameField
            // 
            this.pictureBoxGameField.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGameField.Name = "pictureBoxGameField";
            this.pictureBoxGameField.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxGameField.TabIndex = 0;
            this.pictureBoxGameField.TabStop = false;
            this.pictureBoxGameField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGameField_Paint);
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.Location = new System.Drawing.Point(865, 83);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(101, 32);
            this.buttonTryAgain.TabIndex = 1;
            this.buttonTryAgain.Text = "Try Again";
            this.buttonTryAgain.UseVisualStyleBackColor = true;
            this.buttonTryAgain.Click += new System.EventHandler(this.buttonTryAgain_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Step";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(934, 136);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(0, 17);
            this.labelSteps.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(876, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alive";
            // 
            // labelAlive
            // 
            this.labelAlive.AutoSize = true;
            this.labelAlive.Location = new System.Drawing.Point(928, 192);
            this.labelAlive.Name = "labelAlive";
            this.labelAlive.Size = new System.Drawing.Size(0, 17);
            this.labelAlive.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(876, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Died";
            // 
            // labelDied
            // 
            this.labelDied.AutoSize = true;
            this.labelDied.Location = new System.Drawing.Point(928, 227);
            this.labelDied.Name = "labelDied";
            this.labelDied.Size = new System.Drawing.Size(0, 17);
            this.labelDied.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Entityes in sum";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(865, 44);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(101, 33);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // labelEntitySum
            // 
            this.labelEntitySum.AutoSize = true;
            this.labelEntitySum.Location = new System.Drawing.Point(928, 258);
            this.labelEntitySum.Name = "labelEntitySum";
            this.labelEntitySum.Size = new System.Drawing.Size(0, 17);
            this.labelEntitySum.TabIndex = 10;
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(928, 165);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(0, 17);
            this.labelFood.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(834, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Food eaten";
            // 
            // labelMindState
            // 
            this.labelMindState.AutoSize = true;
            this.labelMindState.Location = new System.Drawing.Point(931, 287);
            this.labelMindState.Name = "labelMindState";
            this.labelMindState.Size = new System.Drawing.Size(0, 17);
            this.labelMindState.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(839, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mind state";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(837, 428);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(136, 34);
            this.buttonRandom.TabIndex = 15;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.Location = new System.Drawing.Point(837, 468);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(136, 34);
            this.buttonFood.TabIndex = 17;
            this.buttonFood.Text = "Food";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPartner
            // 
            this.buttonPartner.Location = new System.Drawing.Point(837, 508);
            this.buttonPartner.Name = "buttonPartner";
            this.buttonPartner.Size = new System.Drawing.Size(136, 34);
            this.buttonPartner.TabIndex = 18;
            this.buttonPartner.Text = "Partner";
            this.buttonPartner.UseVisualStyleBackColor = true;
            this.buttonPartner.Click += new System.EventHandler(this.buttonPartner_Click);
            // 
            // buttonClever
            // 
            this.buttonClever.Location = new System.Drawing.Point(837, 548);
            this.buttonClever.Name = "buttonClever";
            this.buttonClever.Size = new System.Drawing.Size(136, 34);
            this.buttonClever.TabIndex = 19;
            this.buttonClever.Text = "Wondering";
            this.buttonClever.UseVisualStyleBackColor = true;
            this.buttonClever.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Change Mind";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBar1.Location = new System.Drawing.Point(814, 354);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(216, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(876, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Population";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClever);
            this.Controls.Add(this.buttonPartner);
            this.Controls.Add(this.buttonFood);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.labelMindState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelEntitySum);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDied);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAlive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTryAgain);
            this.Controls.Add(this.pictureBoxGameField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameField;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAlive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDied;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label labelEntitySum;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMindState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Button buttonPartner;
        private System.Windows.Forms.Button buttonClever;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
    }
}

