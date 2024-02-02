namespace GuessGame.Forms
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.Header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeTheme = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(129, 10);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(238, 58);
            this.Header.TabIndex = 0;
            this.Header.Text = "About Us";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 510);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // ChangeTheme
            // 
            this.ChangeTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTheme.FormattingEnabled = true;
            this.ChangeTheme.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "CyberPunk"});
            this.ChangeTheme.Location = new System.Drawing.Point(14, 583);
            this.ChangeTheme.Name = "ChangeTheme";
            this.ChangeTheme.Size = new System.Drawing.Size(112, 28);
            this.ChangeTheme.TabIndex = 1;
            this.ChangeTheme.Text = "Light";
            this.ChangeTheme.TextChanged += new System.EventHandler(this.ChangeTheme_TextChanged);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 619);
            this.Controls.Add(this.ChangeTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChangeTheme;
    }
}