namespace GuessGame.Forms
{
    partial class Password
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
            this.txtSetPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnSetPass = new System.Windows.Forms.RadioButton();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.txtSetConfirm = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChangePass = new System.Windows.Forms.TextBox();
            this.txtChangeConfirm = new System.Windows.Forms.TextBox();
            this.rBtnChangePass = new System.Windows.Forms.RadioButton();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGameMode = new System.Windows.Forms.TextBox();
            this.rBtnForgotPass = new System.Windows.Forms.RadioButton();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSetPassword
            // 
            this.txtSetPassword.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtSetPassword.Location = new System.Drawing.Point(12, 51);
            this.txtSetPassword.MaxLength = 8;
            this.txtSetPassword.Name = "txtSetPassword";
            this.txtSetPassword.Size = new System.Drawing.Size(305, 35);
            this.txtSetPassword.TabIndex = 2;
            this.txtSetPassword.Text = "Password";
            this.txtSetPassword.TextChanged += new System.EventHandler(this.txtSetPassword_TextChanged);
            this.txtSetPassword.Enter += new System.EventHandler(this.txtSetPassword_Enter);
            this.txtSetPassword.Leave += new System.EventHandler(this.txtSetPassword_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnSetPass);
            this.groupBox1.Controls.Add(this.txtHint);
            this.groupBox1.Controls.Add(this.txtSetConfirm);
            this.groupBox1.Controls.Add(this.txtSetPassword);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rBtnSetPass
            // 
            this.rBtnSetPass.AutoSize = true;
            this.rBtnSetPass.Checked = true;
            this.rBtnSetPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rBtnSetPass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rBtnSetPass.Location = new System.Drawing.Point(12, 13);
            this.rBtnSetPass.Name = "rBtnSetPass";
            this.rBtnSetPass.Size = new System.Drawing.Size(195, 37);
            this.rBtnSetPass.TabIndex = 4;
            this.rBtnSetPass.TabStop = true;
            this.rBtnSetPass.Text = "Set Password";
            this.rBtnSetPass.UseVisualStyleBackColor = true;
            this.rBtnSetPass.CheckedChanged += new System.EventHandler(this.rBtnSetPass_CheckedChanged);
            this.rBtnSetPass.Click += new System.EventHandler(this.rBtnSetPass_Click);
            // 
            // txtHint
            // 
            this.txtHint.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHint.ForeColor = System.Drawing.Color.Gray;
            this.txtHint.Location = new System.Drawing.Point(12, 92);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(616, 35);
            this.txtHint.TabIndex = 3;
            this.txtHint.Text = "Hint";
            this.txtHint.Enter += new System.EventHandler(this.txtHint_Enter);
            this.txtHint.Leave += new System.EventHandler(this.txtHint_Leave);
            // 
            // txtSetConfirm
            // 
            this.txtSetConfirm.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetConfirm.ForeColor = System.Drawing.Color.Gray;
            this.txtSetConfirm.Location = new System.Drawing.Point(323, 51);
            this.txtSetConfirm.MaxLength = 8;
            this.txtSetConfirm.Name = "txtSetConfirm";
            this.txtSetConfirm.Size = new System.Drawing.Size(305, 35);
            this.txtSetConfirm.TabIndex = 2;
            this.txtSetConfirm.Text = "Confirm Password";
            this.txtSetConfirm.Enter += new System.EventHandler(this.txtSetConfirm_Enter);
            this.txtSetConfirm.Leave += new System.EventHandler(this.txtSetConfirm_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChangePass);
            this.groupBox2.Controls.Add(this.txtChangeConfirm);
            this.groupBox2.Controls.Add(this.rBtnChangePass);
            this.groupBox2.Controls.Add(this.txtCurrentPass);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 146);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txtChangePass
            // 
            this.txtChangePass.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePass.ForeColor = System.Drawing.Color.Gray;
            this.txtChangePass.Location = new System.Drawing.Point(12, 92);
            this.txtChangePass.MaxLength = 8;
            this.txtChangePass.Name = "txtChangePass";
            this.txtChangePass.Size = new System.Drawing.Size(305, 35);
            this.txtChangePass.TabIndex = 3;
            this.txtChangePass.Text = "Password";
            this.txtChangePass.TextChanged += new System.EventHandler(this.txtChangePass_TextChanged);
            this.txtChangePass.Enter += new System.EventHandler(this.txtChangePass_Enter);
            this.txtChangePass.Leave += new System.EventHandler(this.txtChangePass_Leave);
            // 
            // txtChangeConfirm
            // 
            this.txtChangeConfirm.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeConfirm.ForeColor = System.Drawing.Color.Gray;
            this.txtChangeConfirm.Location = new System.Drawing.Point(323, 92);
            this.txtChangeConfirm.MaxLength = 8;
            this.txtChangeConfirm.Name = "txtChangeConfirm";
            this.txtChangeConfirm.Size = new System.Drawing.Size(305, 35);
            this.txtChangeConfirm.TabIndex = 2;
            this.txtChangeConfirm.Text = "Confirm Password";
            this.txtChangeConfirm.Enter += new System.EventHandler(this.txtChangeConfirm_Enter);
            this.txtChangeConfirm.Leave += new System.EventHandler(this.txtChangeConfirm_Leave);
            // 
            // rBtnChangePass
            // 
            this.rBtnChangePass.AutoSize = true;
            this.rBtnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rBtnChangePass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rBtnChangePass.Location = new System.Drawing.Point(12, 11);
            this.rBtnChangePass.Name = "rBtnChangePass";
            this.rBtnChangePass.Size = new System.Drawing.Size(245, 37);
            this.rBtnChangePass.TabIndex = 4;
            this.rBtnChangePass.Text = "Change Password";
            this.rBtnChangePass.UseVisualStyleBackColor = true;
            this.rBtnChangePass.CheckedChanged += new System.EventHandler(this.rBtnSetPass_CheckedChanged);
            this.rBtnChangePass.Click += new System.EventHandler(this.rBtnChangePass_Click);
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.ForeColor = System.Drawing.Color.Gray;
            this.txtCurrentPass.Location = new System.Drawing.Point(12, 51);
            this.txtCurrentPass.MaxLength = 8;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(616, 35);
            this.txtCurrentPass.TabIndex = 2;
            this.txtCurrentPass.Text = "Current Password";
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            this.txtCurrentPass.Enter += new System.EventHandler(this.txtCurrentPass_Enter);
            this.txtCurrentPass.Leave += new System.EventHandler(this.txtCurrentPass_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGameMode);
            this.groupBox3.Controls.Add(this.rBtnForgotPass);
            this.groupBox3.Controls.Add(this.txtType);
            this.groupBox3.Controls.Add(this.txtAge);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 146);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // txtGameMode
            // 
            this.txtGameMode.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameMode.ForeColor = System.Drawing.Color.Gray;
            this.txtGameMode.Location = new System.Drawing.Point(323, 92);
            this.txtGameMode.MaxLength = 4;
            this.txtGameMode.Name = "txtGameMode";
            this.txtGameMode.Size = new System.Drawing.Size(305, 35);
            this.txtGameMode.TabIndex = 4;
            this.txtGameMode.Text = "Game Mode";
            this.txtGameMode.Enter += new System.EventHandler(this.txtGameMode_Enter);
            this.txtGameMode.Leave += new System.EventHandler(this.txtGameMode_Leave);
            // 
            // rBtnForgotPass
            // 
            this.rBtnForgotPass.AutoSize = true;
            this.rBtnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rBtnForgotPass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rBtnForgotPass.Location = new System.Drawing.Point(12, 12);
            this.rBtnForgotPass.Name = "rBtnForgotPass";
            this.rBtnForgotPass.Size = new System.Drawing.Size(236, 37);
            this.rBtnForgotPass.TabIndex = 4;
            this.rBtnForgotPass.Text = "Forgot Password";
            this.rBtnForgotPass.UseVisualStyleBackColor = true;
            this.rBtnForgotPass.CheckedChanged += new System.EventHandler(this.rBtnSetPass_CheckedChanged);
            this.rBtnForgotPass.Click += new System.EventHandler(this.rBtnForgotPass_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Gray;
            this.txtType.Location = new System.Drawing.Point(12, 92);
            this.txtType.MaxLength = 6;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(305, 35);
            this.txtType.TabIndex = 3;
            this.txtType.Text = "Type";
            this.txtType.Enter += new System.EventHandler(this.txtType_Enter);
            this.txtType.Leave += new System.EventHandler(this.txtType_Leave);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Gray;
            this.txtAge.Location = new System.Drawing.Point(323, 51);
            this.txtAge.MaxLength = 2;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(305, 35);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "Age";
            this.txtAge.Enter += new System.EventHandler(this.txtAge_Enter);
            this.txtAge.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(12, 51);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 35);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(323, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(643, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(49, 20);
            this.Status.Text = "Status";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Deactivate Password";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 591);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Password";
            this.Text = "Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSetPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.TextBox txtSetConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChangePass;
        private System.Windows.Forms.TextBox txtChangeConfirm;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGameMode;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.RadioButton rBtnSetPass;
        private System.Windows.Forms.RadioButton rBtnChangePass;
        private System.Windows.Forms.RadioButton rBtnForgotPass;
        private System.Windows.Forms.Button button2;
    }
}