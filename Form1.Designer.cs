namespace Part_6__PSR_project
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
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.RBPaper = new System.Windows.Forms.RadioButton();
            this.BRScissors = new System.Windows.Forms.RadioButton();
            this.RBRock = new System.Windows.Forms.RadioButton();
            this.GBOne = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.GBOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(12, 12);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(301, 278);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(487, 12);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(301, 278);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 1;
            this.img2.TabStop = false;
            // 
            // RBPaper
            // 
            this.RBPaper.AutoSize = true;
            this.RBPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPaper.Location = new System.Drawing.Point(6, 47);
            this.RBPaper.Name = "RBPaper";
            this.RBPaper.Size = new System.Drawing.Size(65, 22);
            this.RBPaper.TabIndex = 2;
            this.RBPaper.TabStop = true;
            this.RBPaper.Text = "Paper";
            this.RBPaper.UseVisualStyleBackColor = true;
            this.RBPaper.CheckedChanged += new System.EventHandler(this.RBPaper_CheckedChanged);
            // 
            // BRScissors
            // 
            this.BRScissors.AutoSize = true;
            this.BRScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRScissors.Location = new System.Drawing.Point(6, 19);
            this.BRScissors.Name = "BRScissors";
            this.BRScissors.Size = new System.Drawing.Size(85, 22);
            this.BRScissors.TabIndex = 3;
            this.BRScissors.TabStop = true;
            this.BRScissors.Text = "Scissors";
            this.BRScissors.UseVisualStyleBackColor = true;
            this.BRScissors.CheckedChanged += new System.EventHandler(this.BRScissors_CheckedChanged);
            // 
            // RBRock
            // 
            this.RBRock.AutoSize = true;
            this.RBRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBRock.Location = new System.Drawing.Point(6, 75);
            this.RBRock.Name = "RBRock";
            this.RBRock.Size = new System.Drawing.Size(62, 22);
            this.RBRock.TabIndex = 4;
            this.RBRock.TabStop = true;
            this.RBRock.Text = "Rock";
            this.RBRock.UseVisualStyleBackColor = true;
            this.RBRock.CheckedChanged += new System.EventHandler(this.RBRock_CheckedChanged);
            // 
            // GBOne
            // 
            this.GBOne.Controls.Add(this.RBRock);
            this.GBOne.Controls.Add(this.RBPaper);
            this.GBOne.Controls.Add(this.BRScissors);
            this.GBOne.Location = new System.Drawing.Point(685, 296);
            this.GBOne.Name = "GBOne";
            this.GBOne.Size = new System.Drawing.Size(103, 101);
            this.GBOne.TabIndex = 5;
            this.GBOne.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(357, 212);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(90, 78);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "PLAY\r\nS.P.R.!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.GBOne);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Name = "Form1";
            this.Text = "Extreme S.P.R. Simuloator 2023";
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            this.GBOne.ResumeLayout(false);
            this.GBOne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.RadioButton RBPaper;
        private System.Windows.Forms.RadioButton BRScissors;
        private System.Windows.Forms.RadioButton RBRock;
        private System.Windows.Forms.GroupBox GBOne;
        private System.Windows.Forms.Button btnPlay;
    }
}

