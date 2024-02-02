using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame.Forms
{
    public partial class ShowInfo : Form
    {
        //Constructor
        public ShowInfo(string Theme , string Name , string Type , string Age , string GameMode , string Score , string CorrectNumber)
        {
            InitializeComponent();
            if(Theme == "Dark")
            {
                //43, 43, 43
                //60, 63, 65
                //255, 128, 0
                this.BackColor = Color.FromArgb(43, 43, 43);
                lblAge.ForeColor = Color.FromArgb(255, 128, 0);
                lblCorrect.ForeColor = Color.FromArgb(255, 128, 0);
                lblGameMode.ForeColor = Color.FromArgb(255, 128, 0);
                lblName.ForeColor = Color.FromArgb(255, 128, 0);
                lblScore.ForeColor = Color.FromArgb(255, 128, 0);
                lblType.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else if(Theme == "Light")
            {
                //255, 255, 255
                //0, 0, 0
                this.BackColor = Color.FromArgb(255, 255, 255);
                lblAge.ForeColor = Color.FromArgb(0, 0, 0);
                lblCorrect.ForeColor = Color.FromArgb(0, 0, 0);
                lblGameMode.ForeColor = Color.FromArgb(0, 0, 0);
                lblName.ForeColor = Color.FromArgb(0, 0, 0);
                lblScore.ForeColor = Color.FromArgb(0, 0, 0);
                lblType.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else if(Theme == "CyberPunk")
            {
                //0, 11, 30
                //252, 211, 62
                //211, 1, 126
                this.BackColor = Color.FromArgb(0, 11, 30);
                lblAge.ForeColor = Color.FromArgb(211, 1, 126);
                lblCorrect.ForeColor = Color.FromArgb(252, 211, 62);
                lblGameMode.ForeColor = Color.FromArgb(211, 1, 126);
                lblName.ForeColor = Color.FromArgb(252, 211, 62);
                lblScore.ForeColor = Color.FromArgb(252, 211, 62);
                lblType.ForeColor = Color.FromArgb(211, 1, 126);
            }
            if (Name != "None" && Age != "None" && Type != "None" && GameMode != "None")
            {
                lblAge.Text = Age;
                lblCorrect.Text = CorrectNumber;
                lblGameMode.Text = GameMode;
                lblName.Text = Name;
                lblScore.Text = Score;
                lblType.Text = Type;
            }
        }
    }
}
