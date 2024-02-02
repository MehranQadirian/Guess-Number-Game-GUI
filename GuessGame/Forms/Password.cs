using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GuessGame.Forms
{
    public partial class Password : Form
    {
        private string PathPassword , Pass , Theme;
        private string[] ReadPass = new string[2];
        private bool ExistPassFile , CorrectPassword , CorrectCurrentPass;

        public bool CorrectChangePassword { get; private set; }
        //Constructor
        public Password(string Theme)
        {
            InitializeComponent();
            this.Theme = Theme;
            PathPassword = @"C:\Previous game data\Saves\Password";
            ExistPassFile = false;
            CorrectPassword = false;
            CorrectCurrentPass = false;
            Pass = "";
            ReadPass[0] = "false";
            ReadPass[1] = "NULL";
            button2.Visible = false;
            if (File.Exists(PathPassword))
            {
                FileStream fs = new FileStream(PathPassword, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                ReadPass = sr.ReadLine().Split(',');
                Pass = ReadPass[1];
                sr.Close();
                fs.Close();
                if (ReadPass[1] != "" && ReadPass.Length == 8)
                {
                    ExistPassFile = true;
                    button2.Visible = true;
                }
            }
            if (Theme == "Dark")
            {
                //43, 43, 43
                //60, 63, 65
                //255, 128, 0
                BackColor = Color.FromArgb(43, 43, 43);
                txtSetPassword.ForeColor = Color.FromArgb(255, 128, 0);
                txtCurrentPass.ForeColor = Color.FromArgb(255, 128, 0);
                txtChangePass.ForeColor = Color.FromArgb(255, 128, 0);
                txtHint.ForeColor = Color.FromArgb(255, 128, 0);
                txtSetConfirm.ForeColor = Color.FromArgb(255, 128, 0);
                txtChangeConfirm.ForeColor = Color.FromArgb(255, 128, 0);
                txtName.ForeColor = Color.FromArgb(255, 128, 0);
                txtAge.ForeColor = Color.FromArgb(255, 128, 0);
                txtType.ForeColor = Color.FromArgb(255, 128, 0);
                txtGameMode.ForeColor = Color.FromArgb(255, 128, 0);

                txtSetPassword.BackColor = Color.FromArgb(50,50,50);
                txtCurrentPass.BackColor = Color.FromArgb(50,50,50);
                txtChangePass.BackColor = Color.FromArgb(50,50,50);
                txtHint.BackColor = Color.FromArgb(50,50,50);
                txtSetConfirm.BackColor = Color.FromArgb(50,50,50);
                txtChangeConfirm.BackColor = Color.FromArgb(50,50,50);
                txtName.BackColor = Color.FromArgb(50,50,50);
                txtAge.BackColor = Color.FromArgb(50,50,50);
                txtType.BackColor = Color.FromArgb(50,50,50);
                txtGameMode.BackColor = Color.FromArgb(50, 50, 50);

                button1.ForeColor = Color.FromArgb(255, 128, 0);
                button1.BackColor = Color.FromArgb(50,50,50);
                rBtnChangePass.ForeColor = Color.FromArgb(255, 128, 0);
                rBtnForgotPass.ForeColor = Color.FromArgb(255, 128, 0);
                rBtnSetPass.ForeColor = Color.FromArgb(255, 128, 0);

                statusStrip1.BackColor = Color.FromArgb(50, 50, 50);
                Status.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else if (Theme == "Light")
            {
                //255, 255, 255
                //0, 0, 0
                BackColor = Color.FromArgb(255, 255, 255);
                txtSetPassword.ForeColor = Color.FromArgb(0, 0, 0);
                txtCurrentPass.ForeColor = Color.FromArgb(0, 0, 0);
                txtChangePass.ForeColor = Color.FromArgb(0, 0, 0);
                txtHint.ForeColor = Color.FromArgb(0, 0, 0);
                txtSetConfirm.ForeColor = Color.FromArgb(0, 0, 0);
                txtChangeConfirm.ForeColor = Color.FromArgb(0, 0, 0);
                txtName.ForeColor = Color.FromArgb(0, 0, 0);
                txtAge.ForeColor = Color.FromArgb(0, 0, 0);
                txtType.ForeColor = Color.FromArgb(0, 0, 0);
                txtGameMode.ForeColor = Color.FromArgb(0, 0, 0);

                txtSetPassword.BackColor = Color.FromArgb(255, 255, 255);
                txtCurrentPass.BackColor = Color.FromArgb(255, 255, 255);
                txtChangePass.BackColor = Color.FromArgb(255, 255, 255);
                txtHint.BackColor = Color.FromArgb(255, 255, 255);
                txtSetConfirm.BackColor = Color.FromArgb(255, 255, 255);
                txtChangeConfirm.BackColor = Color.FromArgb(255, 255, 255);
                txtName.BackColor = Color.FromArgb(255, 255, 255);
                txtAge.BackColor = Color.FromArgb(255, 255, 255);
                txtType.BackColor = Color.FromArgb(255, 255, 255);
                txtGameMode.BackColor = Color.FromArgb(255, 255, 255);

                button1.ForeColor = Color.FromArgb(0, 0, 0);
                button1.BackColor = Color.FromArgb(255, 255, 255);
                rBtnChangePass.ForeColor = Color.FromArgb(0, 0, 0);
                rBtnForgotPass.ForeColor = Color.FromArgb(0, 0, 0);
                rBtnSetPass.ForeColor = Color.FromArgb(0, 0, 0);

                statusStrip1.BackColor = Color.FromArgb(255, 255, 255);
                Status.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else if (Theme == "CyberPunk")
            {
                //0, 11, 30
                //252, 211, 62
                //211, 1, 126
                BackColor = Color.FromArgb(0, 11, 30);
                txtSetPassword.ForeColor = Color.FromArgb(211, 1, 126);
                txtCurrentPass.ForeColor = Color.FromArgb(211, 1, 126);
                txtChangePass.ForeColor = Color.FromArgb(211, 1, 126);
                txtHint.ForeColor = Color.FromArgb(211, 1, 126);
                txtSetConfirm.ForeColor = Color.FromArgb(211, 1, 126);
                txtChangeConfirm.ForeColor = Color.FromArgb(211, 1, 126);
                txtName.ForeColor = Color.FromArgb(211, 1, 126);
                txtAge.ForeColor = Color.FromArgb(211, 1, 126);
                txtType.ForeColor = Color.FromArgb(211, 1, 126);
                txtGameMode.ForeColor = Color.FromArgb(211, 1, 126);

                txtSetPassword.BackColor = Color.FromArgb(0, 11, 30);
                txtCurrentPass.BackColor = Color.FromArgb(0, 11, 30);
                txtChangePass.BackColor = Color.FromArgb(0, 11, 30);
                txtHint.BackColor = Color.FromArgb(0, 11, 30);
                txtSetConfirm.BackColor = Color.FromArgb(0, 11, 30);
                txtChangeConfirm.BackColor = Color.FromArgb(0, 11, 30);
                txtName.BackColor = Color.FromArgb(0, 11, 30);
                txtAge.BackColor = Color.FromArgb(0, 11, 30);
                txtType.BackColor = Color.FromArgb(0, 11, 30);
                txtGameMode.BackColor = Color.FromArgb(0, 11, 30);

                button1.ForeColor = Color.FromArgb(211, 1, 126);
                button1.BackColor = Color.FromArgb(0, 11, 30);
                rBtnChangePass.ForeColor = Color.FromArgb(211, 1, 126);
                rBtnForgotPass.ForeColor = Color.FromArgb(211, 1, 126);
                rBtnSetPass.ForeColor = Color.FromArgb(211, 1, 126);

                statusStrip1.BackColor = Color.FromArgb(0, 11, 30);
                Status.ForeColor = Color.FromArgb(211, 1, 126);
            }
            CheckRadioButton();
        }
        //Checker Functions
        private void CheckRadioButton()
        {
            if (ExistPassFile == false)
                if (rBtnSetPass.Checked == true)
                {
                    rBtnChangePass.Checked = false;
                    rBtnForgotPass.Checked = false;
                    //Enable Set Password Box
                    txtSetPassword.Enabled = true;
                    txtSetConfirm.Enabled = true;
                    txtHint.Enabled = true;

                    //Unenable Any Box
                    txtChangePass.Enabled = false;
                    txtChangeConfirm.Enabled = false;
                    txtCurrentPass.Enabled = false;
                    txtName.Enabled = false;
                    txtAge.Enabled = false;
                    txtType.Enabled = false;
                    txtGameMode.Enabled = false;
                }
            if (rBtnChangePass.Checked == true)
            {
                rBtnSetPass.Checked = false;
                rBtnForgotPass.Checked = false;

                //Enable Set Password Box
                txtChangePass.Enabled = true;
                txtChangeConfirm.Enabled = true;
                txtCurrentPass.Enabled = true;

                //Unenable Any Box
                txtSetPassword.Enabled = false;
                txtSetConfirm.Enabled = false;
                txtHint.Enabled = false;
                txtName.Enabled = false;
                txtAge.Enabled = false;
                txtType.Enabled = false;
                txtGameMode.Enabled = false;
            }
            if (rBtnForgotPass.Checked == true)
            {
                rBtnChangePass.Checked = false;
                rBtnSetPass.Checked = false;

                //Enable Set Password Box
                txtName.Enabled = true;
                txtAge.Enabled = true;
                txtType.Enabled = true;
                txtGameMode.Enabled = true;

                //Unenable Any Box
                txtSetPassword.Enabled = false;
                txtSetConfirm.Enabled = false;
                txtHint.Enabled = false;
                txtChangePass.Enabled = false;
                txtChangeConfirm.Enabled = false;
                txtCurrentPass.Enabled = false;
            }
        }
        //Checked Changed Event
        private void rBtnSetPass_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButton();
        }
        //Click Event
        private void rBtnSetPass_Click(object sender, EventArgs e)
        {
            if (rBtnSetPass.Checked == false)
            {
                rBtnChangePass.Checked = false;
                rBtnForgotPass.Checked = false;
                rBtnSetPass.Checked = true;
            }
                
        }
        private void rBtnChangePass_Click(object sender, EventArgs e)
        {
            if (rBtnChangePass.Checked == false)
            {
                rBtnSetPass.Checked = false;
                rBtnForgotPass.Checked = false;
                rBtnChangePass.Checked = true;
            }
        }
        private void rBtnForgotPass_Click(object sender, EventArgs e)
        {
            if (rBtnForgotPass.Checked == false)
            {
                rBtnChangePass.Checked = false;
                rBtnSetPass.Checked = false;
                rBtnForgotPass.Checked = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(PathPassword))
            {
                File.Delete(PathPassword);
                button2.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guess_Game game = new Guess_Game();
            if (rBtnSetPass.Checked == true)
            {
                if (CorrectPassword == true)
                {
                    if (txtSetConfirm.Text == txtSetPassword.Text)
                    {
                        if (txtHint.Text != "Hint")
                        {
                            try
                            {
                                FileStream fs = new FileStream(PathPassword, FileMode.Create, FileAccess.Write);
                                StreamWriter sw = new StreamWriter(fs);
                                sw.Write($"{game.Name},{true},{txtSetPassword.Text}");
                                sw.Close();
                                fs.Close();
                                button2.Visible = true;
                            }
                            catch (Exception ex)
                            {
                                Status.Text = $"{ex.Message}";
                            }
                        }
                        else
                            Status.Text = "please fill the hint box";
                    }
                    else
                    {
                        Status.Text = "The Confirm Password section is not the same as the Password section".ToLower();
                    }
                }
                else
                {
                    Status.Text = "the entered password in not correct";
                }
            }
            if (rBtnChangePass.Checked == true)
            {
                if (CorrectCurrentPass == true)
                {
                    if (txtChangeConfirm.Text == txtChangePass.Text)
                    {
                        try
                        {
                            FileStream fs = new FileStream(PathPassword, FileMode.Create, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.Write($"{true},{txtChangePass.Text}");
                            sw.Close();
                            fs.Close();
                        }
                        catch (Exception ex)
                        {
                            Status.Text = $"{ex.Message}";
                        }
                    }
                    else
                    {
                        Status.Text = "The Confirm Password section is not the same as the Password section".ToLower();
                    }
                }
                else
                {
                    Status.Text = "the entered password in not correct";
                }
            }
            if (rBtnForgotPass.Checked == true)
            {

                string[] Data = new string[7];
                string path = @"C:\Previous game data\Saves\GuAllUserInfo.txt";
                if (File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    while (sr.Peek() != -1)
                    {
                        Data = sr.ReadLine().Split(',');
                        if (Data[6] != "")
                        {
                            if (txtName.Text == Data[2])
                            {
                                if (txtAge.Text == Data[4])
                                    if (txtType.Text == Data[3])
                                        if (txtGameMode.Text == Data[5])
                                            MessageBox.Show($"YOUR PASS : {Data[6]}", "Password", MessageBoxButtons.OK);
                            }
                            if (txtAge.Text == Data[4])
                            {
                                if (txtType.Text == Data[3])
                                    if (txtGameMode.Text == Data[5])
                                        if (txtName.Text == Data[2])
                                            MessageBox.Show($"YOUR PASS : {Data[6]}", "Password", MessageBoxButtons.OK);
                            }
                            if (txtType.Text == Data[3])
                            {
                                if (txtGameMode.Text == Data[5])
                                    if (txtName.Text == Data[2])
                                        if (txtAge.Text == Data[4])
                                            MessageBox.Show($"YOUR PASS : {Data[6]}", "Password", MessageBoxButtons.OK);
                            }
                            if (txtGameMode.Text == Data[5])
                            {
                                if (txtName.Text == Data[2])
                                    if (txtAge.Text == Data[4])
                                        if (txtType.Text == Data[3])
                                            MessageBox.Show($"YOUR PASS : {Data[6]}", "Password", MessageBoxButtons.OK);
                            }
                        }
                        else
                            MessageBox.Show("No password saved", "Password", MessageBoxButtons.OK);
                    }
                    sr.Close();
                    fs.Close();
                }
                else
                {
                    if (File.Exists(PathPassword))
                    {
                        if (SendPassword() != "")
                        {
                            MessageBox.Show($"YOUR PASS : {SendPassword()}", "Password", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
        //Text Changed Event
        private void txtSetPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtSetPassword.TextLength < 8 && txtSetPassword.Text != "Password")
                Status.Text = "You must enter a minimum and maximum of 8 characters".ToLower();
            else if (txtSetPassword.TextLength == 8 && txtSetPassword.Text != "Password")
                Status.Text = "The format entered is correct".ToLower();
            else
                Status.Text = "The format entered is not correct".ToLower();
            if (Status.Text == "The format entered is correct".ToLower())
                CorrectPassword = true;
        }
        private void txtChangePass_TextChanged(object sender, EventArgs e)
        {
            if (txtChangePass.TextLength < 8 && txtChangePass.Text != "Password")
                Status.Text = "You must enter a minimum and maximum of 8 characters".ToLower();
            else if (txtChangePass.TextLength == 8 && txtChangePass.Text != "Password")
                Status.Text = "The format entered is correct".ToLower();
            else
                Status.Text = "The format entered is not correct".ToLower();
            if (Status.Text == "The format entered is correct".ToLower())
                CorrectChangePassword = true;
        }
        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == Pass)
            {
                if (Pass != "NULL")
                {
                    Status.Text = "the password you entered " + "is the same as ".ToUpper() + "the saved password";
                    CorrectCurrentPass = true;
                }
            }
            else
            {
                Status.Text = "the password you entered " + "is not the same as ".ToUpper() + "the saved password";
                CorrectCurrentPass = false;
            }
        }
        //Enter Event
        private void txtSetPassword_Enter(object sender, EventArgs e)
        {
            if (txtSetPassword.Text == "Password")
            {
                txtSetPassword.Text = "";
            }
        }
        private void txtSetConfirm_Enter(object sender, EventArgs e)
        {
            if (txtSetConfirm.Text == "Confirm Password")
            {
                txtSetConfirm.Text = "";
            }
        }
        private void txtHint_Enter(object sender, EventArgs e)
        {
            if (txtHint.Text == "Hint")
            {
                txtHint.Text = "";
            }
        }
        private void txtCurrentPass_Enter(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "Current Password")
            {
                txtCurrentPass.Text = "";
            }
        }
        private void txtChangePass_Enter(object sender, EventArgs e)
        {
            if (txtChangePass.Text == "Password")
            {
                txtChangePass.Text = "";
            }
        }
        private void txtChangeConfirm_Enter(object sender, EventArgs e)
        {
            if (txtChangeConfirm.Text == "Confirm Password")
            {
                txtChangeConfirm.Text = "";
            }
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
            }
        }
        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text == "Age")
            {
                txtAge.Text = "";
            }
        }
        private void txtType_Enter(object sender, EventArgs e)
        {
            if (txtType.Text == "Type")
            {
                txtType.Text = "";
            }
        }
        private void txtGameMode_Enter(object sender, EventArgs e)
        {
            if (txtGameMode.Text == "Game Mode")
            {
                txtGameMode.Text = "";
            }
        }
        //Leave Event
        private void txtSetPassword_Leave(object sender, EventArgs e)
        {
            if (txtSetPassword.Text == "")
            {
                txtSetPassword.Text = "Password";
            }
        }
        private void txtHint_Leave(object sender, EventArgs e)
        {
            if (txtHint.Text == "")
            {
                txtHint.Text = "Hint";
            }
        }
        private void txtCurrentPass_Leave(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "")
            {
                txtCurrentPass.Text = "Current Password";
            }
        }
        private void txtChangePass_Leave(object sender, EventArgs e)
        {
            if (txtChangePass.Text == "")
            {
                txtChangePass.Text = "Password";
            }
        }
        private void txtChangeConfirm_Leave(object sender, EventArgs e)
        {
            if (txtChangeConfirm.Text == "")
            {
                txtChangeConfirm.Text = "Confirm Password";
            }
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
            }
        }
        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text == "")
            {
                txtAge.Text = "Age";
            }
        }
        private void txtType_Leave(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                txtType.Text = "Type";
            }
        }
        private void txtGameMode_Leave(object sender, EventArgs e)
        {
            if (txtGameMode.Text == "")
            {
                txtGameMode.Text = "Game Mode";
            }
        }
        private void txtSetConfirm_Leave(object sender, EventArgs e)
        {
            if (txtSetConfirm.Text == "")
            {
                txtSetConfirm.Text = "Confirm Password";
            }
        }
        //Set Password
        private string SendPassword()
        {
            string PasswordLocal;
            if (File.Exists(PathPassword))
            {
                FileStream fs = new FileStream(PathPassword, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                PasswordLocal = sr.ReadLine().Split(',')[1];
                sr.Close();
                fs.Close();
            }
            else
                PasswordLocal = "";
            return PasswordLocal;
        }
    }
}
