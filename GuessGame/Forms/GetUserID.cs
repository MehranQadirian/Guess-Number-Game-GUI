using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace GuessGame.Forms
{
    public partial class GetUserID : Form
    {
        private string tbText, language;
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
        private new string Name, Age, Type, GameMode;
#pragma warning restore CS0109 // Member does not hide an inherited member; new keyword is not required
        private int n = 0, t = 0, LeaveTextName = 0;
        private readonly int ind = 0;
        private readonly bool type;
        private readonly bool age;
        private readonly bool gamemode;
        //Constructor
        public GetUserID(string language)
        {
            InitializeComponent();
            this.language = language;
            Width = 550;
            Height = 240;
            age = false;
            type = false;
            gamemode = false;
            if (language == "Fa")
            {
                txtName.Text = "نام";
                txtAge.Text = "سن";
                txtType.Text = "آقا یا خانم";
                txtGameMode.Text = "سخت یا آسان";
                button1.Text = "تایید";
                this.Text = "تنظیم اطلاعات بازیکن";
                txtName.RightToLeft = RightToLeft.Yes;
                txtAge.RightToLeft = RightToLeft.Yes;
                txtType.RightToLeft = RightToLeft.Yes;
                txtGameMode.RightToLeft = RightToLeft.Yes;
                txtGameMode.Items.Clear();
                txtGameMode.Items.Insert(0, "آسان");
                txtGameMode.Items.Insert(1, "سخت");
                txtType.Items.Clear();
                txtType.Items.Insert(0, "آقا");
                txtType.Items.Insert(1, "خانم");
            }
            if (language == "En")
            {
                txtName.Text = "Your Name";
                txtAge.Text = "Your Age";
                txtType.Text = "Male or Female";
                txtGameMode.Text = "Easy or Hard";
                button1.Text = "Apply".ToUpper();
                this.Text = "Set player information".ToUpper();
                txtName.RightToLeft = RightToLeft.No;
                txtAge.RightToLeft = RightToLeft.No;
                txtType.RightToLeft = RightToLeft.No;
                txtGameMode.RightToLeft = RightToLeft.No;
                txtGameMode.Items.Clear();
                txtGameMode.Items.Insert(0, "Easy");
                txtGameMode.Items.Insert(1, "Hard");
                txtType.Items.Clear();
                txtType.Items.Insert(0, "Male");
                txtType.Items.Insert(1, "Female");
            }
        }
        //Theme Functions
        private void Change_Theme(string Theme)
        {
            if (Theme == "Dark")
            {

            }
            else if (Theme == "Light")
            {

            }
            else if (Theme == "CyberPunk")
            {

            }
        }
        //Size Change Event
        private void GetUserID_SizeChanged(object sender, EventArgs e)
        {
            if (Width < 550 || Width > 550)
                Width = 550;
            if (Height < 240 || Height > 240)
                Height = 240;
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        //Enter Event
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (language == "Fa")
                if (txtName.Text == "نام" || txtName.Text == "Your Name")
                {
                    tbText = "نام";
                    txtName.ForeColor = Color.Black;
                    txtName.Text = "";
                }
            if (language == "En")
                if (txtName.Text == "Your Name" || txtName.Text == "نام")
                {
                    tbText = "Your Name";
                    txtName.ForeColor = Color.Black;
                    txtName.Text = "";
                }
            if (PbarName.Value == 0)
                for (int i = 0; i < 51; i++)
                    if (PbarName.Value < 50)
                    {
                        Thread.Sleep(2);
                        PbarName.Value++;
                    }
            if (PbarName.Value == 100)
                for (int i = 0; i < 30; i++)
                    if (PbarName.Value > 80)
                    {
                        Thread.Sleep(5);
                        PbarName.Value--;
                    }
        }
        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (language == "Fa")
                if (txtAge.Text == "سن" || txtAge.Text == "Your Age")
                {
                    tbText = "سن";
                    txtAge.ForeColor = Color.Black;
                    txtAge.Text = "";
                }
            if (language == "En")
                if (txtAge.Text == "Your Age" || txtAge.Text == "سن")
                {
                    tbText = "Your Age";
                    txtAge.ForeColor = Color.Black;
                    txtAge.Text = "";
                }
            if (PbarAge.Value == 0)
                for (int i = 0; i < 51; i++)
                    if (PbarAge.Value != 50)
                    {
                        Thread.Sleep(2);
                        PbarAge.Value++;
                    }
        }
        private void txtType_Enter(object sender, EventArgs e)
        {
            if (language == "Fa")
                if (txtType.Text == "آقا یا خانم" || txtType.Text == "Male or Female")
                {
                    tbText = "آقا یا خانم";
                    txtType.ForeColor = Color.Black;
                    txtType.Text = "";
                }
            if (language == "En")
                if (txtType.Text == "Male or Female" || txtType.Text == "آقا یا خانم")
                {
                    tbText = "Male or Female";
                    txtType.ForeColor = Color.Black;
                    txtType.Text = "";
                }
            if (PbarType.Value == 0)
                for (int i = 0; i < 51; i++)
                    if (PbarType.Value < 50)
                    {
                        Thread.Sleep(2);
                        PbarType.Value++;
                    }
        }
        private void txtGameMode_Enter(object sender, EventArgs e)
        {
            if (language == "Fa")
                if (txtGameMode.Text == "سخت یا آسان" || txtGameMode.Text == "Easy or Hard")
                {
                    tbText = "سخت یا آسان";
                    txtGameMode.ForeColor = Color.Black;
                    txtGameMode.Text = "";
                }
            if (language == "En")
                if (txtGameMode.Text == "Easy or Hard" || txtGameMode.Text == "سخت یا آسان")
                {
                    tbText = "Easy or Hard";
                    txtGameMode.ForeColor = Color.Black;
                    txtGameMode.Text = "";
                }
            if (PbarGameMode.Value == 0)
                for (int i = 0; i < 51; i++)
                    if (PbarGameMode.Value < 50)
                    {
                        Thread.Sleep(2);
                        PbarGameMode.Value++;
                    }
        }
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAge.Text, out n))
                switch (Convert.ToInt32(txtAge.Text))
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                    case 34:
                    case 35:
                    case 36:
                    case 37:
                    case 38:
                    case 39:
                    case 40:
                    case 41:
                    case 42:
                    case 43:
                    case 44:
                    case 45:
                    case 46:
                    case 47:
                    case 48:
                    case 49:
                    case 50:
                    case 51:
                    case 52:
                    case 53:
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                    case 60:
                    case 61:
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                    case 66:
                    case 67:
                    case 68:
                    case 69:
                    case 70:
                    case 71:
                    case 72:
                    case 73:
                    case 74:
                    case 75:
                    case 76:
                    case 77:
                    case 78:
                    case 79:
                    case 80:
                    case 81:
                    case 82:
                    case 83:
                    case 84:
                    case 85:
                    case 86:
                    case 87:
                    case 88:
                    case 89:
                    case 90:
                    case 91:
                    case 92:
                    case 93:
                    case 94:
                    case 95:
                    case 96:
                    case 97:
                    case 98:
                    case 99:
                    case 100:
                        for (int j = 0; j < 99; j++)
                        {
                            if (PbarAge.Value != 100)
                            {
                                Thread.Sleep(2);
                                PbarAge.Value++;
                            }
                        }

                        break;
                    default:
                        txtAge.Text = "";
                        txtAge.Focus();
                        for (int j = 0; j < 99; j++)
                        {
                            if (PbarAge.Value != 0)
                                PbarAge.Value--;
                            Thread.Sleep(5);
                        }
                        txtType.Enabled = false;
                        break;
                }
            if (txtAge.Text == "")
            {
                PbarAge.Value = 0;
                for (int j = 0; j < 99; j++)
                {
                    if (PbarAge.Value < 50)
                        PbarAge.Value++;
                    Thread.Sleep(2);
                }
            }
            if (PbarAge.Value == 100)
                txtType.Enabled = true;
            else
                txtType.Enabled = false;
        }
        //Text Chenged Event
        private void txtGameMode_TextChanged(object sender, EventArgs e)
        {
            if (txtGameMode.ForeColor != Color.Gray)
            {
                if (txtGameMode.Text != "")
                {
                    if (txtGameMode.Text[0] == 'E')
                    {
                        txtGameMode.Text = "Easy";
                        button1.Enabled = true;
                    }
                    else if (txtGameMode.Text[0] == 'H')
                    {
                        txtGameMode.Text = "Hard";
                        button1.Enabled = true;
                    }
                    else
                    {
                        txtGameMode.Text = "";
                        button1.Enabled = false;
                    }
                }
                else
                {
                    for (int i = 0; i < 99; i++)
                    {
                        if (PbarGameMode.Value > 0)
                        {
                            Thread.Sleep(5);
                            PbarGameMode.Value--;
                        }
                    }
                    button1.Enabled = false;
                }
            }
        }
        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if(txtType.Text != "" && txtType.Text[0] == 'M')
            {
                if (txtType.Text.Length == 1)
                {
                    if (PbarType.Value < 60)
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            Thread.Sleep(2);
                            if (PbarType.Value != 60)
                                PbarType.Value++;
                        }
                    }
                    else if (PbarType.Value > 60)
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            Thread.Sleep(2);
                            if (PbarType.Value != 0)
                                PbarType.Value--;
                        }
                    }
                }
                if (PbarType.Value != PbarAge.Value + (txtAge.Text.Length * 10))
                {
                    if(txtType.Text.Length > t && txtType.Text.Length < 5 &&
                        (txtType.Text[0] == 'M' || txtType.Text[1] == 'a' || txtType.Text[2] == 'l' || txtType.Text[3] == 'e')
                        )
                    {
                        t++;
                        for (int i = 0; i < 10; i++)
                        {
                            Thread.Sleep(10);
                            if (PbarType.Value != 100)
                                PbarType.Value++;
                        }
                    }
                    if (txtType.Text.Length < t && txtType.Text.Length >= 0)
                    {
                        t--;
                        for (int i = 0; i < 10; i++)
                        {
                            Thread.Sleep(10);
                            if (PbarType.Value != 0)
                                PbarType.Value--;
                        }
                    }
                }
            }
            if (txtType.Text != "" && txtType.Text[0] == 'F')
            {
                if (txtType.Text.Length == 1)
                    PbarType.Value = 40;
                if (PbarType.Value != PbarAge.Value + (txtAge.Text.Length * 10))
                {
                    if (txtType.Text.Length > t && txtType.Text.Length < 7 &&
                        (txtType.Text[0] == 'F' || txtType.Text[1] == 'e' || txtType.Text[2] == 'm' || txtType.Text[3] == 'a' ||
                        txtType.Text[4] == 'l' || txtType.Text[5] == 'e'))
                    {
                        t++;
                        Thread.Sleep(10);
                        for (int i = 0; i < 10; i++)
                            if (PbarType.Value != 100)
                                PbarType.Value++;

                    }
                    if (txtType.Text.Length < t && txtType.Text.Length >= 0)
                    {
                        t--;
                        Thread.Sleep(10);
                        for (int i = 0; i < 10; i++)
                            if (PbarType.Value != 0)
                                PbarType.Value--;

                    }
                }
            }
            if (txtType.Text == "Female" || txtType.Text == "Male")
            {
                if(PbarType.Value < 100 && txtType.Text == "Male")
                {
                    t = 4;
                    Thread.Sleep(10);
                    for (int i = 0; i < 100; i++)
                        if (PbarType.Value != 100)
                            PbarType.Value++;
                }
                if (PbarType.Value < 100 && txtType.Text == "Female")
                {
                    t = 6;
                    Thread.Sleep(10);
                    for (int i = 0; i < 100; i++)
                        if (PbarType.Value != 100)
                            PbarType.Value++;
                }
                txtGameMode.Enabled = true;
            }
            else
                txtGameMode.Enabled = false;
            if(txtType.Text == "" && PbarType.Value > 50)
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(2);
                    if (PbarType.Value > 50)
                        PbarType.Value--;
                }
            }
            if (txtType.Text == "" && PbarType.Value < 50)
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(2);
                    if (PbarType.Value < 50)
                        PbarType.Value++;
                }
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > n && txtName.Text.Length <= 3)
            {
                n = txtName.Text.Length;
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(10);
                    PbarName.Value += 1;
                }
            }
            if (txtName.Text.Length < n && txtName.Text.Length <= 3)
            {
                n = txtName.Text.Length;
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(10);
                    PbarName.Value -= 1;
                }
            }
            if (txtName.Text == "" || txtName.Text == "Your Name")
            {
                txtAge.Enabled = false;
                txtType.Enabled = false;
                txtGameMode.Enabled = false;
                button1.Enabled = false;
            }
            if (PbarName.Value == 80)
                txtAge.Enabled = true;
            else
                txtAge.Enabled = false;
        }
        //Enabled Changed Event
        private void txtAge_EnabledChanged(object sender, EventArgs e)
        {
            if (txtAge.Enabled == true)
            {
                if (PbarAll.Value != 100)
                    for (int i = 0; i < 25; i++)
                    {
                        Thread.Sleep(10);
                        PbarAll.Value++;
                    }
            }
            else
            {
                if (PbarAll.Value != 0)
                    for (int i = 0; i < 25; i++)
                    {
                        Thread.Sleep(10);
                        PbarAll.Value--;
                    }
            }
        }
        private void txtType_EnabledChanged(object sender, EventArgs e)
        {
            if (txtType.Enabled == true)
            {
                if (PbarAll.Value != 100)
                    for (int i = 0; i < 25; i++)
                    {
                        Thread.Sleep(10);
                        PbarAll.Value++;
                    }
            }
            else
            {
                if (PbarAll.Value != 0)
                    for (int i = 0; i < 25; i++)
                    {
                        Thread.Sleep(10);
                        PbarAll.Value--;
                    }
            }
        }
        private void txtGameMode_EnabledChanged(object sender, EventArgs e)
        {
            if (txtGameMode.Enabled == true)
            {
                if (PbarAll.Value != 100)
                    for (int i = 0; i < 25; i++)
                    {
                        Thread.Sleep(10);
                        PbarAll.Value++;
                    }
            }
            else
            {
                if (PbarAll.Value != 0)
                    for (int i = 0; i < 25; i++)
                    {
                        Thread.Sleep(10);
                        PbarAll.Value--;
                    }
            }
        }
        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {
                if (PbarAll.Value != 100)
                    for (int i = 0; i < 25; i++)
                    {
                        Thread.Sleep(10);
                        PbarAll.Value++;
                    }
            }
            if (button1.Enabled == false)
            {
                if (PbarAll.Value != 0)
                    for (int i = 0; i < 25; i++)
                    {
                        Thread.Sleep(10);
                        PbarAll.Value--;
                    }
            }

        }
        //Leave Event
        private void txtName_Leave_1(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                if (language == "Fa")
                    txtName.Text = "نام";
                else if (language == "En")
                    txtName.Text = "Your Name";
                txtName.ForeColor = Color.Gray;
                for (int i = 0; i < 99; i++)
                {
                    if (PbarName.Value > 0)
                    {
                        Thread.Sleep(2);
                        PbarName.Value--;
                    }
                }
            }
            else if (txtName.Text != "Your Name" && txtName.Text != "نام" && txtName.Text.Length >= 3)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (PbarName.Value < 100)
                    {
                        Thread.Sleep(2);
                        PbarName.Value++;
                    }
                }
                LeaveTextName = txtName.Text.Length;
            }
            else
            {
                txtName.Text = "";
                txtName.Focus();
                for (int i = 0; i < 99; i++)
                {
                    if (PbarName.Value > 0)
                    {
                        Thread.Sleep(5);
                        PbarName.Value--;
                    }
                }
            }
        }
        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text == "")
            {
                if (language == "Fa")
                    txtAge.Text = "سن";
                else if (language == "En")
                    txtAge.Text = "Your Age";
                txtAge.ForeColor = Color.Gray;
                for (int j = 0; j < 99; j++)
                {
                    if (PbarAge.Value != 0)
                        PbarAge.Value--;
                    Thread.Sleep(5);
                }
            }
            else if (txtAge.Text != "Your Age" && txtAge.Text != "سن")
            {
                if (int.TryParse(txtAge.Text, out n))
                    switch (Convert.ToInt32(txtAge.Text))
                    {
                        case 1:
                            txtAge.Text = "10";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 2:
                            txtAge.Text = "20";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 3:
                            txtAge.Text = "30";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 4:
                            txtAge.Text = "40";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 5:
                            txtAge.Text = "50";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 6:
                            txtAge.Text = "60";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 7:
                            txtAge.Text = "70";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 8:
                            txtAge.Text = "80";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 9:
                            txtAge.Text = "90";
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                        case 21:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                        case 31:
                        case 32:
                        case 33:
                        case 34:
                        case 35:
                        case 36:
                        case 37:
                        case 38:
                        case 39:
                        case 40:
                        case 41:
                        case 42:
                        case 43:
                        case 44:
                        case 45:
                        case 46:
                        case 47:
                        case 48:
                        case 49:
                        case 50:
                        case 51:
                        case 52:
                        case 53:
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        case 58:
                        case 59:
                        case 60:
                        case 61:
                        case 62:
                        case 63:
                        case 64:
                        case 65:
                        case 66:
                        case 67:
                        case 68:
                        case 69:
                        case 70:
                        case 71:
                        case 72:
                        case 73:
                        case 74:
                        case 75:
                        case 76:
                        case 77:
                        case 78:
                        case 79:
                        case 80:
                        case 81:
                        case 82:
                        case 83:
                        case 84:
                        case 85:
                        case 86:
                        case 87:
                        case 88:
                        case 89:
                        case 90:
                        case 91:
                        case 92:
                        case 93:
                        case 94:
                        case 95:
                        case 96:
                        case 97:
                        case 98:
                        case 99:
                        case 100:
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 100)
                                {
                                    Thread.Sleep(2);
                                    PbarAge.Value++;
                                }
                            }
                            txtType.Enabled = true;
                            break;
                        default:
                            txtAge.Text = "";
                            txtAge.Focus();
                            for (int j = 0; j < 99; j++)
                            {
                                if (PbarAge.Value != 0)
                                    PbarAge.Value--;
                                Thread.Sleep(5);
                            }
                            txtType.Enabled = false;
                            break;
                    }
            }
            else
            {
                txtAge.Text = "";
                txtAge.Focus();
                for (int j = 0; j < 99; j++)
                {
                    if (PbarAge.Value != 0)
                        PbarAge.Value--;
                    Thread.Sleep(5);
                }
                txtType.Enabled = false;
            }
        }
        private void txtType_Leave(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                if (language == "Fa")
                    txtType.Text = "آقا یا خانم";
                else if (language == "En")
                    txtType.Text = "Male or Female";
                txtType.ForeColor = Color.Gray;
                for (int i = 0; i < 99; i++)
                    if (PbarType.Value != 0)
                    {
                        Thread.Sleep(2);
                        PbarType.Value--;
                    }
            }
        }
        private void txtGameMode_Leave(object sender, EventArgs e)
        {
            if (txtGameMode.Text == "")
            {
                txtGameMode.ForeColor = Color.Gray;
                if (language == "Fa")
                    txtGameMode.Text = "سخت یا آسان";
                else if (language == "En")
                    txtGameMode.Text = "Easy or Hard";
                for (int i = 0; i < 99; i++)
                {
                    if (PbarGameMode.Value > 0)
                    {
                        Thread.Sleep(5);
                        PbarGameMode.Value--;
                    }
                }
            }
            else if (txtGameMode.Text == "Easy" || txtGameMode.Text == "Hard" || txtGameMode.Text == "سخت" || txtGameMode.Text == "آسان")
                for (int i = 0; i < 99; i++)
                    if (PbarGameMode.Value < 100)
                    {
                        Thread.Sleep(2);
                        PbarGameMode.Value++;
                    }
        }
        //Send Information
        public string SendData()
        {
            string Data = $"{Name},{Age},{Type},{GameMode}";
            return Data;
        }
        //Set
        private void button1_Click(object sender, EventArgs e)
        {
            Guess_Game game = new Guess_Game();
            if
                (
                txtName.Text != "Your Name" || txtName.Text != "نام" ||
                txtAge.Text != "Your Age" || txtAge.Text != "سن" ||
                txtType.Text != "Male or Female" || txtType.Text != "آقا یا خانم" ||
                txtGameMode.Text != "Easy or Hard" || txtGameMode.Text != "سخت یا آسان"
                )
            {
                if (txtType.Text == "Male" || txtType.Text == "آقا")
                {
                    if (txtGameMode.Text == "Easy" || txtGameMode.Text == "آسان")
                    {
                        Name = txtName.Text;
                        Age = txtAge.Text;
                        Type = txtType.Text;
                        GameMode = txtGameMode.Text;
                        SendData();
                        game.SaveSetUserInfo(Name, Age, Type, GameMode);
                        this.Close();
                    }
                    else if (txtGameMode.Text == "Hard" || txtGameMode.Text == "سخت")
                    {
                        Name = txtName.Text;
                        Age = txtAge.Text;
                        Type = txtType.Text;
                        GameMode = txtGameMode.Text;
                        SendData();
                        game.SaveSetUserInfo(Name, Age, Type, GameMode);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "The game mode you selected is not between Easy and Hard modes.",
                            "Error for game mode".ToUpper(),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtGameMode.Focus();
                    }

                }
                else if (txtType.Text == "Female" || txtType.Text == "خانم")
                {
                    if (txtGameMode.Text == "Easy" || txtGameMode.Text == "آسان")
                    {
                        Name = txtName.Text;
                        Age = txtAge.Text;
                        Type = txtType.Text;
                        GameMode = txtGameMode.Text;
                        SendData();
                        game.SaveSetUserInfo(Name, Age, Type, GameMode);
                        this.Close();
                    }
                    else if (txtGameMode.Text == "Hard" || txtGameMode.Text == "سخت")
                    {
                        Name = txtName.Text;
                        Age = txtAge.Text;
                        Type = txtType.Text;
                        GameMode = txtGameMode.Text;
                        SendData();
                        game.SaveSetUserInfo(Name, Age, Type, GameMode);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "The game mode you selected is not between Easy and Hard modes.",
                            "Error for game mode".ToUpper(),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtGameMode.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "You have not selected your gender correctly.",
                        "Error for gender".ToUpper(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtType.Focus();
                }
            }
        }
    }
}
