namespace GuessGame.Forms
{
    partial class ShowInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInfo));
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.picCorrect = new System.Windows.Forms.PictureBox();
            this.picScore = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(202, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 46);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(202, 58);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(90, 46);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(202, 104);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(80, 46);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // lblGameMode
            // 
            this.lblGameMode.AutoSize = true;
            this.lblGameMode.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMode.Location = new System.Drawing.Point(202, 150);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(205, 46);
            this.lblGameMode.TabIndex = 1;
            this.lblGameMode.Text = "Game Mode";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(291, 207);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(104, 46);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(101, 207);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(131, 46);
            this.lblCorrect.TabIndex = 1;
            this.lblCorrect.Text = "Correct";
            // 
            // picCorrect
            // 
            this.picCorrect.Image = global::GuessGame.Properties.Resources.icons8_counter_500px_1;
            this.picCorrect.Location = new System.Drawing.Point(49, 207);
            this.picCorrect.Name = "picCorrect";
            this.picCorrect.Size = new System.Drawing.Size(46, 46);
            this.picCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCorrect.TabIndex = 2;
            this.picCorrect.TabStop = false;
            // 
            // picScore
            // 
            this.picScore.Image = global::GuessGame.Properties.Resources.icons8_coins_500px;
            this.picScore.Location = new System.Drawing.Point(239, 207);
            this.picScore.Name = "picScore";
            this.picScore.Size = new System.Drawing.Size(46, 46);
            this.picScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScore.TabIndex = 2;
            this.picScore.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuessGame.Properties.Resources.BlackFemale;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 266);
            this.Controls.Add(this.picCorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.picScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGameMode);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowInfo";
            ((System.ComponentModel.ISupportInitialize)(this.picCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picScore;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.PictureBox picCorrect;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}