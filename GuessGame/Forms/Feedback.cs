using System;
using System.Drawing;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace GuessGame.Forms
{
    public partial class Feedback : Form
    {
        //Constructor
        public Feedback(string Theme)
        {
            InitializeComponent();
            feedbackLabel.Text = "Please enter your feedback:";
            feedbackLabel.AutoSize = true;
            if(Theme == "Light")
            {
                //255, 255, 255
                //0, 0, 0
                //ForeColor
                label1.ForeColor = Color.FromArgb(0, 0, 0);
                label2.ForeColor = Color.FromArgb(0, 0, 0);
                feedbackLabel.ForeColor = Color.FromArgb(0, 0, 0);
                feedbackTextBox.ForeColor = Color.FromArgb(0, 0, 0);
                statusLabel.ForeColor = Color.Red;
                textBox1.ForeColor = Color.FromArgb(0, 0, 0);
                textBox2.ForeColor = Color.FromArgb(0, 0, 0);
                sendButton.ForeColor = Color.FromArgb(0, 0, 0);

                BackColor = Color.FromArgb(255, 255, 255);
                feedbackLabel.BackColor = Color.FromArgb(255, 255, 255);
                feedbackTextBox.BackColor = Color.FromArgb(245, 245, 245);
                statusLabel.BackColor = Color.FromArgb(255, 255, 255);
                textBox1.BackColor = Color.FromArgb(245, 245, 245);
                textBox2.BackColor = Color.FromArgb(245, 245, 245);
            }
            if (Theme == "Dark")
            {
                //43, 43, 43
                //60, 63, 65
                //255, 128, 0
                label1.ForeColor = Color.FromArgb(252, 211, 62);
                label2.ForeColor = Color.FromArgb(252, 211, 62);
                feedbackLabel.ForeColor = Color.FromArgb(252, 211, 62);
                feedbackTextBox.ForeColor = Color.FromArgb(252, 211, 62);
                statusLabel.ForeColor = Color.FromArgb(252, 211, 62);;
                textBox1.ForeColor = Color.FromArgb(252, 211, 62);
                textBox2.ForeColor = Color.FromArgb(252, 211, 62);
                sendButton.ForeColor = Color.FromArgb(252, 211, 62);

                BackColor = Color.FromArgb(43, 43, 43);
                feedbackLabel.BackColor = Color.FromArgb(43, 43, 43);
                feedbackTextBox.BackColor = Color.FromArgb(60, 63, 65);
                statusLabel.BackColor = Color.FromArgb(43, 43, 43);
                textBox1.BackColor = Color.FromArgb(60, 63, 65);
                textBox2.BackColor = Color.FromArgb(60, 63, 65);
                sendButton.BackColor = Color.FromArgb(50, 50, 50);
            }
            if (Theme == "CyberPunk")
            {
                //0, 11, 30
                //252, 211, 62
                //211, 1, 126
                label1.ForeColor = Color.FromArgb(252, 211, 62);
                label2.ForeColor = Color.FromArgb(252, 211, 62);
                feedbackLabel.ForeColor = Color.FromArgb(252, 211, 62);
                feedbackTextBox.ForeColor = Color.FromArgb(252, 211, 62);
                statusLabel.ForeColor = Color.FromArgb(252, 211, 62); ;
                textBox1.ForeColor = Color.FromArgb(252, 211, 62);
                textBox2.ForeColor = Color.FromArgb(252, 211, 62);
                sendButton.ForeColor = Color.FromArgb(252, 211, 62);

                BackColor = Color.FromArgb(0, 11, 30);
                feedbackLabel.BackColor = Color.FromArgb(0, 11, 30);
                feedbackTextBox.BackColor = Color.FromArgb(10, 21, 40);
                statusLabel.BackColor = Color.FromArgb(0, 11, 30);
                textBox1.BackColor = Color.FromArgb(10, 21, 40);
                textBox2.BackColor = Color.FromArgb(10, 21, 40);
                sendButton.BackColor = Color.FromArgb(10, 21, 40);
            }

        }
        //Send Email
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(new MailboxAddress("GNG-Support", "supgnumgame@gmail.com"));
                email.To.Add(new MailboxAddress("Mehran Ghadirian", "mehranghadirian01@email.com"));
                email.Subject = "Feedback for Guess Number Game";
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {
                    Text = $"<h2>Name : {textBox1.Text}</h2>" +
                    $"<h4>Gmail Address : {textBox2.Text}</h4>" +
                    "<b>Hello all the way from the land of C#</b>" +
                    $"<p><i>{feedbackTextBox.Text}</i></p>"
                };

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, false);
                    // Note: only needed if the SMTP server requires authentication
                    smtp.Authenticate("supgnumgame@gmail.com", "Mehran00gh5564");
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
            }
            catch(Exception ex)
            {
                statusLabel.Text = $"Error : {ex.Message}";
                statusLabel.Visible = true;
            }
        }
    }
}
