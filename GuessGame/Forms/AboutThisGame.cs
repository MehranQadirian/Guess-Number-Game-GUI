using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame.Forms
{
    public partial class AboutThisGame : Form
    {
        //Constructor
        public AboutThisGame(string Language)
        {
            InitializeComponent();
            if(Language == "En")
            {
                pictureBox1.Image = Properties.Resources.AboutThisGameEn123;
            }
            else if(Language == "Fa")
            {
                pictureBox1.Image = Properties.Resources.AboutThisGameFa;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
