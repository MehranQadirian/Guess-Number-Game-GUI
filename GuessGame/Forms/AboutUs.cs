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
    public partial class AboutUs : Form
    {
        private string Language , Theme;
        public AboutUs(string Language, string Theme)
        {
            InitializeComponent();
            this.Language = Language;
            this.Theme = Theme;

            if (this.Theme == "Light" || this.Theme == "Dark" || this.Theme == "CyberPunk")
                CheckTheme(this.Theme);
            else
                CheckTheme(ChangeTheme.Text);

            if (this.Language == "En" || this.Language == "Fa")
                CheckLanguage(this.Language);
        }
        private void CheckTheme(string Theme)
        {
            if (Theme == "Light")
            {
                Header.ForeColor = Color.FromArgb(0, 0, 0);
                label1.ForeColor = Color.FromArgb(0, 0, 0);

                Header.BackColor = Color.FromArgb(255, 255, 255);
                label1.BackColor = Color.FromArgb(255, 255, 255);

                BackColor = Color.FromArgb(255, 255, 255);
            }
            if (Theme == "Dark")
            {
                Header.ForeColor = Color.FromArgb(255, 128, 0);
                label1.ForeColor = Color.FromArgb(252, 211, 62);

                Header.BackColor = Color.FromArgb(43, 43, 43);
                label1.BackColor = Color.FromArgb(43, 43, 43);
                BackColor = Color.FromArgb(43, 43, 43);
            }
            if (Theme == "CyberPunk")
            {
                Header.ForeColor = Color.FromArgb(211, 1, 126);
                label1.ForeColor = Color.FromArgb(252, 211, 62);

                Header.BackColor = Color.FromArgb(0, 11, 30);
                label1.BackColor = Color.FromArgb(0, 11, 30);
                BackColor = Color.FromArgb(0, 11, 30);
            }
        }
        private void CheckLanguage(string Language)
        {
            if (Language == "En")
            {
                RightToLeft = RightToLeft.No;
                Header.Text = "About Us";
                label1.Text = "I am Mehran Qadirian, living in Razavi Khorasan, Neishabur" +
                    ", I have a valid and internationally translatable degree from Neishabur" +
                    " Vocational Technical School, I am a computer programmer with 5 years of" +
                    " coding experience and nearly 3 years of teaching programming in private and" +
                    " public schools.\n" +
                    "I have coding skills in C#, Python, PHP, and C++ at the introductory and advanced levels.\n" +
                    "I have the ability to design, develop and test applications and software programs.\n" +
                    "I have participated in various projects such as building" +
                    " a website for a commercial company, developing an online" +
                    " game for a game studio, and creating a database management" +
                    " system for a government agency.\n" +
                    "I want to work in an innovative and dynamic company that will" +
                    " allow me to learn and grow professionally.\n" +
                    "I am interested in solving complex problems and creating creative and efficient solutions.";
            }
            if (Language == "Fa")
            {
                RightToLeft = RightToLeft.Yes;
                Header.Text = "درباره ما";
                label1.Text = "من مهران قدیریان ، ساکن در خراسان رضوی " +
                    "، نیشابور دارای مدرک معتبر و بین المللی قابل ترجمه از آموزشگاه فنی" +
                    " حرفه ای نیشابور، برنامه نویس کامپیوتر با 5 سال سابقه کدنویسی و نزدیک به 3 سال تدریس " +
                    "برنامه نویسی در آموزشگاه های خصصوصی و دولتی هستم.\n" +
                    "من مهارت کدنویسی در زبان های سی شارپ ،پایتون، پی اچ" +
                    " پی و سی پلاس پلاس در سطوح مقدماتی و پیشرفته را دارم.\n" +
                    "من توانایی طراحی، توسعه و تست کردن" +
                    " اپلیکیشن‌ها و برنامه‌های نرم افزاری را دارم.\n" +
                    "من در پروژه‌های مختلفی مانند ساخت یک وب سایت برای یک شرکت تجاری" +
                    "، توسعه یک بازی آنلاین برای یک استودیو بازی و ایجاد یک سیستم مدیریت پایگاه" +
                    " داده برای یک سازمان دولتی مشارکت کرده‌ام.\n" +
                    "من می‌خواهم در یک شرکت نوآورانه و پویا کار کنم" +
                    " که به من امکان یادگیری و رشد حرفه‌ای را بدهد.\n" +
                    "من علاقه مند به حل مسائل پیچیده و" +
                    " ایجاد راه حل‌های خلاقانه و کارآمد هستم.\n";
            }
        }

        private void ChangeTheme_TextChanged(object sender, EventArgs e)
        {
            if (ChangeTheme.Text == "Light" ||
                ChangeTheme.Text == "Dark" ||
                ChangeTheme.Text == "CyberPunk")
                CheckTheme(ChangeTheme.Text);
        }
    }
}
