using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessGame.Forms
{
    public partial class SearchDataFromName : Form
    {
        //Constructor
        public SearchDataFromName()
        {
            InitializeComponent();
        }
        //Main Search
        private void button1_Click(object sender, EventArgs e)
        {
            Guess_Game game = new Guess_Game();
            game.SetValSearchName(txtName.Text);
            Close();
        }
    }
}
