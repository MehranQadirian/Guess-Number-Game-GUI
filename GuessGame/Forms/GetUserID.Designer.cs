namespace GuessGame.Forms
{
    partial class GetUserID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetUserID));
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGameMode = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.ComboBox();
            this.PbarName = new System.Windows.Forms.ProgressBar();
            this.PbarAge = new System.Windows.Forms.ProgressBar();
            this.PbarGameMode = new System.Windows.Forms.ProgressBar();
            this.PbarType = new System.Windows.Forms.ProgressBar();
            this.PbarAll = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(12, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 35);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Your Name";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(540, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.EnabledChanged += new System.EventHandler(this.button1_EnabledChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGameMode
            // 
            this.txtGameMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtGameMode.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
            this.txtGameMode.ForeColor = System.Drawing.Color.Gray;
            this.txtGameMode.FormattingEnabled = true;
            this.txtGameMode.Items.AddRange(new object[] {
            "Easy",
            "Hard"});
            this.txtGameMode.Location = new System.Drawing.Point(380, 84);
            this.txtGameMode.Name = "txtGameMode";
            this.txtGameMode.Size = new System.Drawing.Size(305, 35);
            this.txtGameMode.TabIndex = 2;
            this.txtGameMode.Text = "Easy or Hard";
            this.txtGameMode.EnabledChanged += new System.EventHandler(this.txtGameMode_EnabledChanged);
            this.txtGameMode.TextChanged += new System.EventHandler(this.txtGameMode_TextChanged);
            this.txtGameMode.Enter += new System.EventHandler(this.txtGameMode_Enter);
            this.txtGameMode.Leave += new System.EventHandler(this.txtGameMode_Leave);
            // 
            // txtType
            // 
            this.txtType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtType.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
            this.txtType.ForeColor = System.Drawing.Color.Gray;
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtType.Location = new System.Drawing.Point(12, 84);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(305, 35);
            this.txtType.TabIndex = 3;
            this.txtType.Text = "Male or Female";
            this.txtType.EnabledChanged += new System.EventHandler(this.txtType_EnabledChanged);
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            this.txtType.Enter += new System.EventHandler(this.txtType_Enter);
            this.txtType.Leave += new System.EventHandler(this.txtType_Leave);
            // 
            // txtAge
            // 
            this.txtAge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtAge.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
            this.txtAge.ForeColor = System.Drawing.Color.Gray;
            this.txtAge.FormattingEnabled = true;
            this.txtAge.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.txtAge.Location = new System.Drawing.Point(380, 19);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(305, 35);
            this.txtAge.TabIndex = 4;
            this.txtAge.Text = "Your Age";
            this.txtAge.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            this.txtAge.Enter += new System.EventHandler(this.txtAge_Enter);
            this.txtAge.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // PbarName
            // 
            this.PbarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PbarName.Location = new System.Drawing.Point(12, 55);
            this.PbarName.Margin = new System.Windows.Forms.Padding(0);
            this.PbarName.Name = "PbarName";
            this.PbarName.Size = new System.Drawing.Size(305, 7);
            this.PbarName.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PbarName.TabIndex = 5;
            // 
            // PbarAge
            // 
            this.PbarAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PbarAge.Location = new System.Drawing.Point(380, 55);
            this.PbarAge.Margin = new System.Windows.Forms.Padding(0);
            this.PbarAge.Name = "PbarAge";
            this.PbarAge.Size = new System.Drawing.Size(305, 7);
            this.PbarAge.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PbarAge.TabIndex = 5;
            // 
            // PbarGameMode
            // 
            this.PbarGameMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PbarGameMode.Location = new System.Drawing.Point(380, 120);
            this.PbarGameMode.Margin = new System.Windows.Forms.Padding(0);
            this.PbarGameMode.Name = "PbarGameMode";
            this.PbarGameMode.Size = new System.Drawing.Size(305, 7);
            this.PbarGameMode.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PbarGameMode.TabIndex = 5;
            // 
            // PbarType
            // 
            this.PbarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PbarType.Location = new System.Drawing.Point(12, 120);
            this.PbarType.Margin = new System.Windows.Forms.Padding(0);
            this.PbarType.Name = "PbarType";
            this.PbarType.Size = new System.Drawing.Size(305, 7);
            this.PbarType.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PbarType.TabIndex = 5;
            // 
            // PbarAll
            // 
            this.PbarAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PbarAll.Location = new System.Drawing.Point(540, 196);
            this.PbarAll.Margin = new System.Windows.Forms.Padding(0);
            this.PbarAll.Name = "PbarAll";
            this.PbarAll.Size = new System.Drawing.Size(145, 7);
            this.PbarAll.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PbarAll.TabIndex = 5;
            // 
            // GetUserID
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 206);
            this.Controls.Add(this.PbarAll);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGameMode);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.PbarType);
            this.Controls.Add(this.PbarGameMode);
            this.Controls.Add(this.PbarAge);
            this.Controls.Add(this.PbarName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetUserID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Your Information";
            this.SizeChanged += new System.EventHandler(this.GetUserID_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtGameMode;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.ComboBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ProgressBar PbarName;
        private System.Windows.Forms.ProgressBar PbarAge;
        private System.Windows.Forms.ProgressBar PbarGameMode;
        private System.Windows.Forms.ProgressBar PbarType;
        private System.Windows.Forms.ProgressBar PbarAll;
    }
}