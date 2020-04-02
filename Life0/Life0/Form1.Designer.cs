namespace Life0
{
    partial class Life
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
            this.progressBarPopulation = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBarAverageAge = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.labelLIFE = new System.Windows.Forms.Label();
            this.trackBarSpawnLimits = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.labelSpawnLimit = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpawnLimits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
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
            this.pictureBoxGameField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGameField_MouseClick);
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.Location = new System.Drawing.Point(1002, 550);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(89, 32);
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
            this.label1.Location = new System.Drawing.Point(925, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Step";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(983, 126);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(0, 17);
            this.labelSteps.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(925, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alive";
            // 
            // labelAlive
            // 
            this.labelAlive.AutoSize = true;
            this.labelAlive.Location = new System.Drawing.Point(977, 182);
            this.labelAlive.Name = "labelAlive";
            this.labelAlive.Size = new System.Drawing.Size(0, 17);
            this.labelAlive.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(925, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Died";
            // 
            // labelDied
            // 
            this.labelDied.AutoSize = true;
            this.labelDied.Location = new System.Drawing.Point(977, 217);
            this.labelDied.Name = "labelDied";
            this.labelDied.Size = new System.Drawing.Size(0, 17);
            this.labelDied.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(860, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Entityes in sum";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(1002, 511);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(89, 33);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // labelEntitySum
            // 
            this.labelEntitySum.AutoSize = true;
            this.labelEntitySum.Location = new System.Drawing.Point(977, 248);
            this.labelEntitySum.Name = "labelEntitySum";
            this.labelEntitySum.Size = new System.Drawing.Size(0, 17);
            this.labelEntitySum.TabIndex = 10;
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(977, 155);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(0, 17);
            this.labelFood.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(883, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Food eaten";
            // 
            // labelMindState
            // 
            this.labelMindState.AutoSize = true;
            this.labelMindState.Location = new System.Drawing.Point(980, 277);
            this.labelMindState.Name = "labelMindState";
            this.labelMindState.Size = new System.Drawing.Size(0, 17);
            this.labelMindState.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(888, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mind state";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(841, 510);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(136, 34);
            this.buttonRandom.TabIndex = 15;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.Location = new System.Drawing.Point(841, 550);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(136, 34);
            this.buttonFood.TabIndex = 17;
            this.buttonFood.Text = "Food";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPartner
            // 
            this.buttonPartner.Location = new System.Drawing.Point(841, 590);
            this.buttonPartner.Name = "buttonPartner";
            this.buttonPartner.Size = new System.Drawing.Size(136, 34);
            this.buttonPartner.TabIndex = 18;
            this.buttonPartner.Text = "Partner";
            this.buttonPartner.UseVisualStyleBackColor = true;
            this.buttonPartner.Click += new System.EventHandler(this.buttonPartner_Click);
            // 
            // buttonClever
            // 
            this.buttonClever.Location = new System.Drawing.Point(841, 630);
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
            this.label2.Location = new System.Drawing.Point(866, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Change Mind";
            // 
            // progressBarPopulation
            // 
            this.progressBarPopulation.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBarPopulation.Location = new System.Drawing.Point(842, 341);
            this.progressBarPopulation.Name = "progressBarPopulation";
            this.progressBarPopulation.Size = new System.Drawing.Size(249, 23);
            this.progressBarPopulation.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(939, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Population";
            // 
            // progressBarAverageAge
            // 
            this.progressBarAverageAge.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBarAverageAge.Location = new System.Drawing.Point(842, 389);
            this.progressBarAverageAge.Name = "progressBarAverageAge";
            this.progressBarAverageAge.Size = new System.Drawing.Size(249, 23);
            this.progressBarAverageAge.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(925, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Average age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(915, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Average Health";
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBarHealth.Location = new System.Drawing.Point(842, 439);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(249, 23);
            this.progressBarHealth.TabIndex = 25;
            // 
            // labelLIFE
            // 
            this.labelLIFE.AutoSize = true;
            this.labelLIFE.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLIFE.ForeColor = System.Drawing.Color.Coral;
            this.labelLIFE.Location = new System.Drawing.Point(875, 31);
            this.labelLIFE.Name = "labelLIFE";
            this.labelLIFE.Size = new System.Drawing.Size(154, 95);
            this.labelLIFE.TabIndex = 27;
            this.labelLIFE.Text = "LIFE";
            // 
            // trackBarSpawnLimits
            // 
            this.trackBarSpawnLimits.Location = new System.Drawing.Point(23, 630);
            this.trackBarSpawnLimits.Maximum = 10000;
            this.trackBarSpawnLimits.Name = "trackBarSpawnLimits";
            this.trackBarSpawnLimits.Size = new System.Drawing.Size(374, 56);
            this.trackBarSpawnLimits.TabIndex = 28;
            this.trackBarSpawnLimits.Scroll += new System.EventHandler(this.trackBarSpawnLimits_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 610);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Spawn Limit";
            // 
            // labelSpawnLimit
            // 
            this.labelSpawnLimit.AutoSize = true;
            this.labelSpawnLimit.Location = new System.Drawing.Point(153, 610);
            this.labelSpawnLimit.Name = "labelSpawnLimit";
            this.labelSpawnLimit.Size = new System.Drawing.Size(0, 17);
            this.labelSpawnLimit.TabIndex = 30;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(436, 630);
            this.trackBarSpeed.Maximum = 300;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(349, 56);
            this.trackBarSpeed.TabIndex = 31;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(558, 610);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(0, 17);
            this.labelSpeed.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Speed";
            // 
            // Life
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 702);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.labelSpawnLimit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trackBarSpawnLimits);
            this.Controls.Add(this.labelLIFE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBarHealth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBarAverageAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBarPopulation);
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
            this.Name = "Life";
            this.Text = "Life by @dupeljan";
            this.Load += new System.EventHandler(this.Life_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpawnLimits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
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
        private System.Windows.Forms.ProgressBar progressBarPopulation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBarAverageAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.Label labelLIFE;
        private System.Windows.Forms.TrackBar trackBarSpawnLimits;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelSpawnLimit;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label13;
    }
}

