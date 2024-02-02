using System;
using System.IO;
using System.Windows.Forms;

namespace GuessGame.Forms
{
    public partial class EntryPassword : Form
    {
        public bool CheckPass;
        public EntryPassword()
        {
            InitializeComponent();
        }
        public bool SendCheck()
        {
            return CheckPass;
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string PathPassword = @"C:\Previous game data\Saves\Password";
            string[] Data = new string[3];
            FileStream fs = new FileStream(PathPassword, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Data = sr.ReadLine().Split(',');
            if (txtPassword.Text != "PASSWORD")
                if (Data[2] == txtPassword.Text)
                {
                    CheckPass = true;
                    sr.Close();
                    fs.Close();
                    Close();
                }
            sr.Close();
            fs.Close();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
                txtPassword.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                txtPassword.Text = "PASSWORD";
        }

        private void EntryPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void EntryPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Forgot Pass : [Enter Name]"))
                textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                textBox1.Text = "Forgot Pass : [Enter Name]";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string PathPassword = @"C:\Previous game data\Saves\Password";
            FileStream fs = new FileStream(PathPassword, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string []data = sr.ReadLine().Split(',');
            if(textBox1.Text == data[0])
            {
                MessageBox.Show($"Your Password : {data[2]}", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sr.Close();
            fs.Close();
        }
    }
}
