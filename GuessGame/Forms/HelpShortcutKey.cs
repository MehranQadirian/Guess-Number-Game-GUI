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
    public partial class HelpShortcutKey : Form
    {
        //Constructor
        public HelpShortcutKey(string language)
        {
            InitializeComponent();
            if(language == "Fa")
            {
                pictureBox1.Image = Properties.Resources.HelpShortcutKeyFa;
                btnOK.Text = "تایید";
                this.Text = "راهنمای کلید های میانبر";
            }
            if (language == "En")
            {
                pictureBox1.Image = Properties.Resources.HelpShortcutKeyEn1;
                btnOK.Text = "Apply";
                this.Text = "Shortcut Keys Guide";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
