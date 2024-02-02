using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using CsvHelper;
using GuessGame.Classes;
using System.Collections.Generic;
using System.Globalization;

namespace GuessGame.Forms
{
    public partial class Guess_Game : Form
    {
        //Variables
        public string Name, Age, Type, GameLevel, path, pathLastSave,
            ReadFromOnlyPath, SeachName, Theme, PasswordUser, TxtEntryHelp;
        private readonly string pathFileSave;
        private int rndNumber, chances, score, CorrectNumberGuess , Out , check,indexOfLine;
        private string[] readPth;
        public static string Language;
        string[] Show_Data = new string[4];
        //Constructor
        public Guess_Game()
        {
            InitializeComponent();
            Language = "En";
            btnCheck.Visible = false;
            picArrow.Visible = false;
            lblAlert.Visible = false;
            //Theme
            string pathTheme = @"C:\Previous game data\Saves\Theme.txt";
            if (File.Exists(pathTheme))
            {
                FileStream files = new FileStream(pathTheme, FileMode.Open, FileAccess.Read);
                StreamReader strer = new StreamReader(files);
                Theme = strer.ReadLine();
                strer.Close();
                files.Close();
            }
            else
                Theme = "Light";
            Change_Theme(Theme);
            indexOfLine = 0;
            pictureBox1.Image = Properties.Resources.help;
            pathFileSave = @"C:\Previous game data\Saves\GuAddOfTheReserv.txt";
            if (Directory.Exists(@"C:\Previous game data\Saves"))
                if (File.Exists(pathFileSave))
                {
                    FileStream fs1 = new FileStream(pathFileSave, FileMode.Open, FileAccess.Read);
                    StreamReader sr1 = new StreamReader(fs1);
                    string ReadPathFileSave = sr1.ReadLine();
                    sr1.Close();
                    fs1.Close();
                    pathLastSave = @ReadPathFileSave;
                }
                else
                    pathLastSave = @"C:\Previous game data\Saves\GuLData.txt";
            else
                pathLastSave = @"C:\Previous game data\Saves\GuLData.txt";
            path = @"C:\Previous game data\Saves\GuAllUserInfo.txt";
            if (chances == 0)
                chances = 5;
            if (Directory.Exists(@"C:\Previous game data\Saves"))
            {
                if (File.Exists(pathLastSave))
                {
                    FileStream fs = new FileStream(pathLastSave, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    string Data = sr.ReadLine();
                    string[] SplitedData = Data.Split(',');
                    sr.Close();
                    fs.Close();
                    Name = SplitedData[0];
                    Age = SplitedData[1];
                    Type = SplitedData[2];
                    GameLevel = SplitedData[3];
                    score = Convert.ToInt32(SplitedData[4]);
                    CorrectNumberGuess = Convert.ToInt32(SplitedData[5]);
                    lblGameMode.Text = GameLevel;
                    lblType.Text = Type;
                    lblAge.Text = Age;
                    lblName.Text = Name;
                    lblScore.Text = score.ToString();
                    lblChances.Text = chances.ToString();
                    GenerateRandomNumber(GameLevel);
                }
                else
                {
                    btnCheck.Visible = true;
                    picArrow.Visible = true;
                    lblAlert.Visible = true;
                    Name = "None";
                    Age = "None";
                    Type = "None";
                    GameLevel = "None";
                    score = 0;
                    CorrectNumberGuess = 0;
                    lblGameMode.Text = GameLevel;
                    lblType.Text = Type;
                    lblAge.Text = Age;
                    lblName.Text = Name;
                    lblScore.Text = score.ToString();

                }
            }
            else
            {
                Directory.CreateDirectory(@"C:\Previous game data\Saves");
                btnCheck.Visible = true;
                picArrow.Visible = true;
                lblAlert.Visible = true;
                Name = "None";
                Age = "None";
                Type = "None";
                GameLevel = "None";
                score = 0;
                CorrectNumberGuess = 0;
                lblGameMode.Text = GameLevel;
                lblType.Text = Type;
                lblAge.Text = Age;
                lblName.Text = Name;
                lblScore.Text = score.ToString();
            }
            PBAR();

        }
        //Save Functions
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveLastAction();
            Save($"{Name},{Age},{Type}", GameLevel, CorrectNumberGuess.ToString(), score.ToString(), PasswordUser);
        }
        public void SaveLastAction()
        {
            string Data = $"{Name},{Type},{Age},{GameLevel},{score},{CorrectNumberGuess},{PasswordUser}";
            if (Name != "None" && Age != "None" && Type != "None" && GameLevel != "None")
            {
                if (File.Exists(pathLastSave))
                    File.Delete(pathLastSave);
                FileStream fs = new FileStream(pathLastSave, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine(Data);
                writer.Flush();
                writer.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Please fill in the fields of name, age, gender or type and mode of the game.",
                    "Error : Save Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Hide();
                Forms.GetUserID guess_ = new Forms.GetUserID(Language);
                guess_.ShowDialog();
                this.Show();
                ReadSetUserInfo();
            }
            PBAR();
        }
        private void Save(string Uinfo, string GameLevel, string CNG, string score, string Pass)
        {
            string PathSave = @"C:\Previous game data\Saves\AllDataUsers.csv";
            string SC = score.ToString(), CNG1 = CNG.ToString(), UserInfo = Uinfo, GL = GameLevel;
            string Data = $"{SC},{CNG},{UserInfo},{GL},{Pass}";
            bool ExistDir = false;
            bool ExistFile = false;
            try
            {
                //If the specified folder does not exist
                if (Directory.Exists(@"C:\Previous game data\Saves"))
                {
                    ExistDir = true;
                    if (!File.Exists(path))
                    {
                        ExistFile = false;
                    }
                    else
                    {
                        ExistFile = true;
                    }
                }
                //If the said folder exists
                else
                {
                    ExistDir = false;
                    if (File.Exists(path))
                    {
                        ExistFile = true;
                    }
                    else
                    {
                        ExistFile = false;
                    }
                }
                if (Name != "None" && Age != "None" && Type != "None" && GameLevel != "None")
                {
                    if (ExistDir == false)
                    {
                        if (ExistFile == false)
                        {
                            Directory.CreateDirectory(@"C:\Previous game data\Saves");
                            FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(Data);
                            sw.Close();
                            fs.Close();
                            FileStream fs1 = new FileStream(PathSave, FileMode.CreateNew, FileAccess.Write);
                            StreamWriter sw1 = new StreamWriter(fs1);
                            for (int i = 0; i < Data.Split(',').Length; i++)
                                sw1.WriteLine(Data.Split(',')[i]);
                            sw1.Close();
                            fs1.Close();
                            StatusLabel.Text = Language == "En" ?
                            "All data are saved" :
                            "تمام اطلاعات ذخیره شد";
                        }
                    }
                    else
                    {
                        if (ExistFile == false)
                        {
                            FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(Data);
                            sw.Close();
                            fs.Close();
                            FileStream fs1 = new FileStream(PathSave, FileMode.CreateNew, FileAccess.Write);
                            StreamWriter sw1 = new StreamWriter(fs1);
                            for (int i = 0; i < Data.Split(',').Length; i++)
                                sw1.WriteLine(Data.Split(',')[i]);
                            sw1.Close();
                            fs1.Close();
                            StatusLabel.Text = Language == "En" ?
                            "All data are saved" :
                            "تمام اطلاعات ذخیره شد";
                        }
                        else
                        {
                            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(Data);
                            sw.Close();
                            fs.Close();
                            FileStream fs1 = new FileStream(PathSave, FileMode.Append, FileAccess.Write);
                            StreamWriter sw1 = new StreamWriter(fs1);
                            for (int i = 0; i < Data.Split(',').Length; i++)
                                sw1.WriteLine(Data.Split(',')[i]);
                            sw1.Close();
                            fs1.Close();
                            StatusLabel.Text = Language == "En" ?
                            "All data are saved" :
                            "تمام اطلاعات ذخیره شد";
                        }
                    }
                }
                PBAR();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error While Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Save To Folder Functions
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Files (*.txt)|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            //DialogResult result = saveFileDialog1.ShowDialog();
            saveFileDialog1.FileName = String.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathLastSave = @saveFileDialog1.FileName;
            }
            File.Delete(pathFileSave);
            FileStream fs = new FileStream(pathFileSave, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(pathLastSave);
            sw.Flush();
            sw.Close();
            fs.Close();
            SaveLastAction();
            Save($"{Name},{Age},{Type}", GameLevel, CorrectNumberGuess.ToString(), score.ToString(), PasswordUser);
            PBAR();
        }
        //Read From Folder Functions
        private void Read_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txtFile(*.txt)|*.txt|AllFiles(*.*)|*.*";
            openFileDialog1.Title = "Read File Saved";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
        }
        //Delete Saved Functions
        private void allDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Previous game data\Saves"))
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }
        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(@"C:\Previous game data\Saves"))
                {
                    Directory.Delete(@"C:\Previous game data\Saves");
                    StatusLabel.Text = Language == "En" ?
                        "Deleted Folder Saving" :
                        "پوشه ذخیره ها پاک شد";
                }
                else
                {
                    StatusLabel.Text = Language == "En" ?
                        "Folder Was Not Exist" :
                        "پوشه وجود ندارد";
                }
            }
            catch (Exception ex)
            {

            }

        }
        private void lastSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathLastSave))
                File.Delete(pathLastSave);
        }
        //Close Read File Functions
        private void Close_Click(object sender, EventArgs e)
        {
            string PathPassword = @"C:\Previous game data\Saves\Password";
            if (File.Exists(PathPassword))
            {
                File.Delete(PathPassword);
            }
            if (File.Exists(pathLastSave))
            {
                File.Delete(pathLastSave);
                Name = "None";
                Age = "None";
                Type = "None";
                GameLevel = "None";
                score = 0;
                CorrectNumberGuess = 0;
                lblGameMode.Text = GameLevel;
                lblType.Text = Type;
                lblAge.Text = Age;
                lblName.Text = Name;
                lblScore.Text = score.ToString();
                btnCheck.Visible = true;
                picArrow.Visible = true;
                lblAlert.Visible = true;
                ListView.Rows.Clear();
                LastActionList.Rows.Clear();
            }
        }
        //Search Functions
        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            textBox1.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            if (textBox1.Text != "" && textBox1.Text != "Enter a name to search data")
            {
                SetValSearchName(textBox1.Text);
            }
        }
        public void SetValSearchName(string Name)
        {
            SeachName = Name;
            SearchFromData(SeachName);
        }
        public void SearchFromData(string Name)
        {
            if (ListView.RowCount != 1)
            {
                ListView.Rows.Clear();
            }
            try
            {
                //lblResult.Text = "Search Name From Data :";
                string[] Data = new string[7];

                StreamReader ReadFromFile = new StreamReader(path);
                while (ReadFromFile.Peek() != -1)
                {
                    Data = ReadFromFile.ReadLine().Split(',');
                    if (Data[2] == Name)
                        break;
                }

                int i = 1;
                ReadFromFile.Close();
                ListView.Rows.Add($"{ListView.RowCount}", $"{Data[2]}", $"{Data[3]}", $"{Data[4]}", $"{Data[5]}", $"{Data[0]}", $"{Data[1]}");
                for (int j = 0, k = 2; j < 4 && k < 6; j++, k++)
                {
                    Show_Data[j] = Data[k];
                }

                StatusLabel.Text = Language == "En" ?
                        $"> Founded {Data[2]} Data" :
                        $"اطلاعات {Data[2]} پیدا شد.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Show All Player Functions
        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllDataSaved();
        }
        public void ShowAllDataSaved()
        {
            try
            {
                //lblResult.Text = "Show all users :\n\n";
                StreamReader ReadFromFile = new StreamReader(path);
                string[] Data = new string[10];
                int index = 1, i = 1;
                while (ReadFromFile.Peek() != -1)
                {
                    Data = ReadFromFile.ReadLine().Split(',');
                    if (Data.Length >= 4)
                    {
                        ListView.Rows.Add($"{ListView.RowCount}", $"{Data[2]}", $"{Data[3]}", $"{Data[4]}", $"{Data[5]}", $"{Data[0]}", $"{Data[1]}");
                        i++;
                    }

                    index++;
                }

                ReadFromFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Sort Player By Age Functions
        private void showListByAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortListByAge();
        }
        public void SortListByAge()
        {
            if (ListView.RowCount != 1)
            {
                ListView.Rows.Clear();
            }
            string Data;
            string[] ArrData = new string[10000];
            string[] SetData = new string[7];
            int max = 5;
            int bellowMax = 0;
            int index = 0, n = 0;
            try
            {
                if (File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    while (sr.Peek() != -1)
                    {
                        Data = sr.ReadLine();
                        if (Data.Split(',').Length >= 4)
                        {
                            ArrData[index] = Data;
                            index++;
                        }
                    }
                    sr.Close();
                    fs.Close();
                    for (int i = 0; i < index; i++)
                    {
                        if (ArrData[i].Split(',').Length >= 4)
                        {
                            SetData = ArrData[i].Split(',');
                            if (int.TryParse(SetData[4], out n))
                                if (Convert.ToInt32(SetData[4]) > max)
                                    max = Convert.ToInt32(SetData[4]);
                        }
                    }
                    for (int i = 0; i < index; i++)
                    {
                        if (ArrData[i].Split(',').Length >= 4)
                        {
                            SetData = ArrData[i].Split(',');
                            if (int.TryParse(SetData[4], out n))
                                if (Convert.ToInt32(SetData[4]) > bellowMax && Convert.ToInt32(SetData[4]) < max)
                                    bellowMax = Convert.ToInt32(SetData[4]);
                        }
                    }
                    int Row = 1;
                    for (int i = 0; i < index; i++)
                    {
                        for (int j = 0; j < index; j++)
                        {
                            SetData = ArrData[j].Split(',');
                            if (int.TryParse(SetData[4], out n))
                                if (Convert.ToInt32(SetData[4]) == max)
                                {
                                    ListView.Rows.Add($"{ListView.RowCount}", $"{SetData[2]}", $"{SetData[3]}", $"{SetData[4]}", $"{SetData[5]}", $"{SetData[0]}", $"{SetData[1]}");
                                    Row++;
                                }
                        }
                        max = bellowMax;
                        bellowMax = 0;
                        for (int j = 0; j < index; j++)
                        {
                            if (ArrData[j].Split(',').Length >= 4)
                            {
                                SetData = ArrData[j].Split(',');
                                if (int.TryParse(SetData[4], out n))
                                    if (Convert.ToInt32(SetData[4]) > bellowMax && Convert.ToInt32(SetData[4]) < max)
                                        bellowMax = Convert.ToInt32(SetData[4]);
                            }
                        }
                    }
                }
                else
                {
                    File.Create(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Top Player Action Functions
        private void top5PlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Top5Player();
        }
        private void Top5Player()
        {
            if (ListView.RowCount != 1)
            {
                ListView.Rows.Clear();
            }
            string Data;
            string[] OutputData = new string[7];
            int index = 0, n = 0;
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                //Read from file
                while (sr.Peek() != -1)
                {
                    Data = sr.ReadLine();
                    if (Data.Split(',').Length >= 4)
                    {
                        index++;
                    }
                }
                fs.Close();
                sr.Close();
                FileStream fs1 = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(fs1);
                string[] ArrData = new string[index];
                string[] Username = new string[index];
                string[] Correct = new string[index];
                string[] Age = new string[index];
                string[] Type = new string[index];
                string[] GameMode = new string[index];
                int[] scoreUser = new int[index];
                for (int i = 0; i < index; i++)
                {
                    Data = sr1.ReadLine();
                    if (Data.Split(',').Length >= 4)
                    {
                        ArrData[i] = Data;
                        OutputData = ArrData[i].Split(',');
                        Username[i] = OutputData[2];
                        if (int.TryParse(OutputData[1], out n))
                        {
                            scoreUser[i] = Convert.ToInt32(OutputData[0]);
                            Correct[i] = OutputData[1];
                            Type[i] = OutputData[3];
                            Age[i] = OutputData[4];
                            GameMode[i] = OutputData[5];
                        }

                    }
                }
                sr1.Close();
                fs1.Close();
                int max = 0, cng = 0, iPrint = 0;
                string IndexOneOfUsername = Username[0];
                if(index > 1)
                for (int i = 0; i < index; i++)
                {
                    if (Username[i] == IndexOneOfUsername)
                    {
                        if (scoreUser[i] > max)
                        {
                            max = scoreUser[i];
                            cng = Convert.ToInt32(Correct[i]);
                        }
                    }
                    else if (Username[i] != IndexOneOfUsername)
                    {
                        if (iPrint < 5)
                        {
                            ListView.Rows.Add($"{ListView.RowCount}", $"{Username[i - 1]}", $"{Type[i - 1]}", $"{Age[i - 1]}", $"{GameMode[i - 1]}", $"{scoreUser[i - 1]}", $"{Correct[i - 1]}");
                            IndexOneOfUsername = Username[i];
                            max = 0;
                            iPrint++;
                        }
                    }
                    if (i == index - 1)
                    {
                        if (iPrint < 5)
                        {
                            //lblResult.Text += $"{Username[i - 1]}  :  {scoreUser[i - 1]}\n";
                            iPrint++;
                        }
                    }
                }
                else
                {
                    ListView.Rows.Add($"{ListView.RowCount}", $"{Username[0]}", $"{Type[0]}", $"{Age[0]}", $"{GameMode[0]}", $"{scoreUser[0]}", $"{Correct[0]}");
                }
                StatusLabel.Text = Language == "En" ?
                    ">Action Top 5 Player" :
                    "عملیات 5 نفر برتر";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Best Action Functions
        private void bestGameSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BestPlayer();
        }
        private void BestPlayer()
        {
            if (ListView.RowCount != 1)
            {
                ListView.Rows.Clear();
            }
            string Data;
            string[] OutputData = new string[7];
            int index = 0, n = 0;
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                //Read from file
                while (sr.Peek() != -1)
                {
                    Data = sr.ReadLine();
                    if (Data.Split(',').Length >= 4)
                    {
                        index++;
                    }
                }
                sr.Close();
                fs.Close();
                FileStream fs1 = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(fs1);
                string[] ArrData = new string[index];
                string[] Username = new string[index];
                string[] Age = new string[index];
                string[] Type = new string[index];
                string[] GameMode = new string[index];
                string[] Score = new string[index];
                int[] counter = new int[index];
                for (int i = 0; i < index; i++)
                {
                    Data = sr1.ReadLine();
                    if (Data.Split(',').Length >= 4)
                    {
                        ArrData[i] = Data;
                        OutputData = ArrData[i].Split(',');
                        Username[i] = OutputData[2];
                        Age[i] = OutputData[4];
                        Type[i] = OutputData[3];
                        Score[i] = OutputData[0];
                        GameMode[i] = OutputData[5];
                        Type[i] = OutputData[3];
                        if (int.TryParse(OutputData[1], out n))
                            counter[i] = Convert.ToInt32(OutputData[1]);
                    }
                }
                sr1.Close();
                fs1.Close();
                int max = 0;
                int[] indexof = new int[index];
                string IndexOneOfUsername = Username[0];
                if(index > 1)
                for (int i = 0; i < index; i++)
                {
                    if (Username[i] == IndexOneOfUsername)
                    {
                        if (counter[i] > max)
                        {
                            max = counter[i];
                        }
                    }
                    else if (Username[i] != IndexOneOfUsername)
                    {
                        ListView.Rows.Add($"{ListView.RowCount}", $"{Username[i - 1]}", $"{Type[i - 1]}", $"{Age[i - 1]}", $"{GameMode[i - 1]}", $"{Score[i - 1]}", $"{max}");
                        IndexOneOfUsername = Username[i];
                        max = 0;
                    }
                    if (i == index - 1)
                    {
                        ListView.Rows.Add($"{ListView.RowCount}", $"{Username[i - 1]}", $"{Type[i - 1]}", $"{Age[i - 1]}", $"{GameMode[i - 1]}", $"{Score[i - 1]}", $"{max}");
                    }
                }
                else
                {
                    ListView.Rows.Add($"{ListView.RowCount}", $"{Username[0]}", $"{Type[0]}", $"{Age[0]}", $"{GameMode[0]}", $"{Score[0]}", $"{max}");
                }
                StatusLabel.Text = Language == "En" ?
                    ">Action Best Players" :
                    "عملیات برترین بازیکنان";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Change Game Mode To Hard Functions
        private void toHardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GameLevel == "easy" || GameLevel == "Easy")
            {
                GameLevel = "Hard";
                lblGameMode.Text = GameLevel;
                GenerateRandomNumber(GameLevel);
                StatusLabel.Text = Language == "En" ?
                        "Another random number was generated ,for change game mode " :
                        "برای تغییر حالت بازی ،یک عدد تصادفی دیگر تولید شد";
                SaveLastAction();
            }
            else
            {
                StatusLabel.Text = Language == "En" ?
                        "> You are in a hard mode right now" :
                        "شما هم اکنون در حالت سخت هستید.";
            }
        }
        //Change Game Mode To Easy Functions
        private void toEasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GameLevel == "hard" || GameLevel == "Hard")
            {
                GameLevel = "Easy";
                lblGameMode.Text = GameLevel;
                GenerateRandomNumber(GameLevel);
                StatusLabel.Text = Language == "En" ?
                        "Another random number was generated ,for change game mode " :
                        "برای تغییر حالت بازی ،یک عدد تصادفی دیگر تولید شد";
                SaveLastAction();
            }
            else
            {
                StatusLabel.Text = Language == "En" ?
                        "> You are in a easy mode right now" :
                        "شما هم اکنون در حالت آسان هستید.";
            }
        }
        //View Player Profile Functions
        private void myIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Name == "None" || Name == "نامشخص") && (Age == "None" || Age == "نامشخص") && (Type == "None" || Type == "نامشخص") && (GameLevel == "None" || GameLevel == "نامشخص"))
            {
                try
                {
                    FileStream fs = new FileStream(@"C:\Previous game data\Saves\LastSave.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    string Data = sr.ReadLine();
                    string[] SplitedData = Data.Split(',');
                    lblName.Text = SplitedData[0];
                    lblAge.Text = SplitedData[2];
                    lblType.Text = SplitedData[1];
                    lblGameMode.Text = SplitedData[3];
                    sr.Close();
                    fs.Close();
                    StatusLabel.Text = Language == "En" ?
                            ">Loaded your id" :
                            "اطلاعات شما بارگزاری شد";
                    btnCheck.Visible = false;
                    picArrow.Visible = false;
                    lblAlert.Visible = false;
                    PBAR();
                }
                catch
                {
                    this.Hide();
                    Forms.GetUserID guess_ = new Forms.GetUserID(Language);
                    guess_.ShowDialog();
                    this.Show();
                    ReadSetUserInfo();
                }
            }
            else
            {
                this.Hide();
                ShowInfo info = new ShowInfo(Theme, Name, Type, Age, GameLevel, score.ToString(), CorrectNumberGuess.ToString());
                if (Theme == "Dark")
                {
                    if (Type == "Male" || Type == "آقا")
                    {
                        info.pictureBox1.Image = Properties.Resources.YellMale;
                    }
                    else if (Type == "Female" || Type == "خانم")
                    {
                        info.pictureBox1.Image = Properties.Resources.YellFemale;
                    }
                }
                else if (Theme == "Light")
                {
                    if (Type == "Male" || Type == "آقا")
                    {
                        info.pictureBox1.Image = Properties.Resources.BlackMale;
                    }
                    else if (Type == "Female" || Type == "خانم")
                    {
                        info.pictureBox1.Image = Properties.Resources.BlackFemale;
                    }
                }
                else if (Theme == "CyberPunk")
                {
                    if (Type == "Male" || Type == "آقا")
                    {
                        info.pictureBox1.Image = Properties.Resources.PinkMale;
                    }
                    else if (Type == "Female" || Type == "خانم")
                    {
                        info.pictureBox1.Image = Properties.Resources.PinkFemale;
                    }
                }
                info.ShowDialog();
                this.Show();
            }
        }
        //Get Help For Player Functions
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpUser();
        }
        private void HelpUser()
        {
            //Check the amount of points earned
            if (score >= 30)
            {
                if (GameLevel == "hard" || GameLevel == "Hard")
                {
                    Console.Beep();
                    StatusLabel.Text = Language == "En" ?
                        $"Hint: The number you have to guess is between {rndNumber - 250} and {rndNumber + 250}" :
                        $"نکته: عددی که باید حدس بزنید بین {rndNumber - 250} و {rndNumber + 250} است.";
                    score -= 30; lblScore.Text = score.ToString();
                }
                else
                {
                    Console.Beep();
                    StatusLabel.Text = Language == "En" ?
                        $"Hint: The number you have to guess is between {rndNumber - 25} and {rndNumber + 25}" :
                        $"نکته: عددی که باید حدس بزنید بین {rndNumber - 25} و {rndNumber + 25} است.";
                    score -= 20; lblScore.Text = score.ToString();
                }
                SaveLastAction();
                Save($"{Name},{Age},{Type}", GameLevel, CorrectNumberGuess.ToString(), score.ToString(), PasswordUser);
            }
            //If the number of points is less than 30, the codes of this block will be executed
            else
            {
                Console.Beep();
                StatusLabel.Text = Language == "En" ?
                        "[!] You do not have enough points to get help" :
                        "امتیاز کافی برای کمک گرفتن ندارید.";
            }
        }
        //Edit Profile Functions
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetUserID iD = new GetUserID(Language);
            iD.ShowDialog();
            this.Show();
            ReadSetUserInfo();
        }
        //Read And Set Player Informations Functions
        public void ReadSetUserInfo()
        {
            try
            {
                FileStream fs = new FileStream(pathLastSave, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string[] Data = sr.ReadLine().Split(',');
                sr.Close();
                fs.Close();
                Name = Data[0];
                Age = Data[1];
                Type = Data[2];
                GameLevel = Data[3];
                lblGameMode.Text = GameLevel;
                lblType.Text = Type;
                lblAge.Text = Age;
                lblName.Text = Name;
                btnCheck.Visible = false;
                picArrow.Visible = false;
                lblAlert.Visible = false;
            }
            catch
            {

            }

        }
        private void ReadFromFilePath(string p)
        {
            FileStream fs = new FileStream(@p, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                indexOfLine++;
                ReadFromOnlyPath = sr.ReadLine();
                readPth = ReadFromOnlyPath.Split(',');
            }
            sr.Close();
            fs.Close();

        }
        //Themes Functions
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Theme != "Dark")
                Theme = "Dark";
            else
                MessageBox.Show
                    (
                    "You already now in dark theme.",
                    "Theme",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            Change_Theme(Theme);
        }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Theme != "Light")
                Theme = "Light";
            else
                MessageBox.Show
                    (
                    "You already now in light theme.",
                    "Theme",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            Change_Theme(Theme);
        }
        private void cyberPunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Theme != "CyberPunk")
                Theme = "CyberPunk";
            else
                MessageBox.Show
                    (
                    "You already now in light theme.",
                    "Theme",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            Change_Theme(Theme);
        }
        private void Change_Theme(string Theme)
        {
            if (Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(43, 43, 43);
                statusStrip1.BackColor = Color.FromArgb(43, 43, 43);
                statusStrip1.ForeColor = Color.FromArgb(255, 128, 0);
                txtEntry.BackColor = Color.FromArgb(60, 63, 65);
                txtEntry.ForeColor = Color.FromArgb(255, 128, 0);
                LastActionList.DefaultCellStyle.BackColor = Color.FromArgb(60, 63, 65);
                LastActionList.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
                LastActionList.BackgroundColor = Color.FromArgb(60, 63, 65);
                lblAlert.ForeColor = Color.FromArgb(255, 128, 0);
                ListView.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
                ListView.DefaultCellStyle.BackColor = Color.FromArgb(60, 63, 65);
                ListView.BackgroundColor = Color.FromArgb(60, 63, 65);
                gbID.ForeColor = Color.FromArgb(255, 255, 255);
                gbSCH.ForeColor = Color.FromArgb(255, 255, 255);
                gbLastAction.ForeColor = Color.FromArgb(255, 255, 255);
                btnGetScore.BackColor = Color.White;
                btnGetScore.ForeColor = Color.Green;
                btnResetChances.BackColor = Color.White;
                btnResetChances.ForeColor = Color.Green;
                PBar.ForeColor = Color.Cyan;
                button3.ForeColor = Color.FromArgb(255, 128, 0);
                button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
                button3.FlatAppearance.MouseDownBackColor = Color.Aqua;
                button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
                button3.BackColor = Color.Black;
                button4.ForeColor = Color.FromArgb(255, 128, 0);
                button4.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
                button4.FlatAppearance.MouseDownBackColor = Color.Aqua;
                button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
                button4.BackColor = Color.Black;
                button6.ForeColor = Color.FromArgb(255, 128, 0);
                button6.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
                button6.FlatAppearance.MouseDownBackColor = Color.Aqua;
                button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
                button6.BackColor = Color.Black;

            }
            else if (Theme == "Light")
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
                statusStrip1.BackColor = Color.FromArgb(255, 255, 255);
                statusStrip1.ForeColor = Color.FromArgb(0, 0, 0);
                txtEntry.BackColor = Color.FromArgb(255, 255, 255);
                txtEntry.ForeColor = Color.FromArgb(0, 0, 0);
                LastActionList.BackgroundColor = Color.FromArgb(255, 255, 255);
                LastActionList.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                LastActionList.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                lblAlert.ForeColor = Color.FromArgb(0, 0, 0);
                ListView.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                ListView.BackgroundColor = Color.FromArgb(255, 255, 255);
                gbID.ForeColor = Color.FromArgb(0, 0, 0);
                gbSCH.ForeColor = Color.FromArgb(0, 0, 0);
                gbLastAction.ForeColor = Color.FromArgb(0, 0, 0);
                btnGetScore.BackColor = Color.FromArgb(64, 64, 64);
                btnGetScore.ForeColor = Color.White;
                btnResetChances.BackColor = Color.FromArgb(64, 64, 64);
                btnResetChances.ForeColor = Color.White;
                PBar.ForeColor = Color.FromArgb(6, 176, 37);
                ListView.DefaultCellStyle.ForeColor = Color.DarkGreen;
                button3.ForeColor = Color.FromArgb(0, 192, 192);
                button3.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
                button3.FlatAppearance.MouseDownBackColor = Color.Aqua;
                button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
                button3.BackColor = Color.White;
                button4.ForeColor = Color.FromArgb(0, 192, 192);
                button4.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
                button4.FlatAppearance.MouseDownBackColor = Color.Aqua;
                button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
                button4.BackColor = Color.White;
                button6.ForeColor = Color.FromArgb(0, 192, 192);
                button6.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
                button6.FlatAppearance.MouseDownBackColor = Color.Aqua;
                button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
                button6.BackColor = Color.White;
            }
            else if (Theme == "CyberPunk")
            {
                this.BackColor = Color.FromArgb(0, 11, 30);
                statusStrip1.BackColor = Color.FromArgb(0, 11, 30);
                statusStrip1.ForeColor = Color.FromArgb(252, 211, 62);
                txtEntry.BackColor = Color.FromArgb(115, 48, 199);
                txtEntry.ForeColor = Color.FromArgb(252, 211, 62);
                LastActionList.BackgroundColor = Color.FromArgb(0, 11, 30);
                LastActionList.DefaultCellStyle.BackColor = Color.FromArgb(0, 11, 30);
                LastActionList.DefaultCellStyle.ForeColor = Color.FromArgb(252, 211, 62);
                lblAlert.ForeColor = Color.FromArgb(211, 1, 126);
                ListView.DefaultCellStyle.ForeColor = Color.FromArgb(252, 211, 62);
                ListView.DefaultCellStyle.BackColor = Color.FromArgb(0, 11, 30);
                ListView.BackgroundColor = Color.FromArgb(0, 11, 30);
                gbID.ForeColor = Color.FromArgb(211, 1, 126);
                gbSCH.ForeColor = Color.FromArgb(211, 1, 126);
                gbLastAction.ForeColor = Color.FromArgb(211, 1, 126);
                btnGetScore.BackColor = Color.FromArgb(0, 11, 30);
                btnGetScore.ForeColor = Color.FromArgb(18, 130, 223);
                btnResetChances.BackColor = Color.FromArgb(0, 11, 30);
                btnResetChances.ForeColor = Color.FromArgb(18, 130, 223);
                PBar.ForeColor = Color.FromArgb(252, 211, 62);
                button3.ForeColor = Color.FromArgb(212, 31, 107);
                button3.FlatAppearance.BorderColor = Color.FromArgb(212, 31, 107);
                button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 1, 126);
                button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 31, 107);
                button3.BackColor = Color.FromArgb(0, 11, 30);
                button4.ForeColor = Color.FromArgb(212, 31, 107);
                button4.FlatAppearance.BorderColor = Color.FromArgb(212, 31, 107);
                button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 1, 126);
                button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 31, 107);
                button4.BackColor = Color.FromArgb(0, 11, 30);
                button6.ForeColor = Color.FromArgb(212, 31, 107);
                button6.FlatAppearance.BorderColor = Color.FromArgb(212, 31, 107);
                button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 1, 126);
                button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 31, 107);
                button6.BackColor = Color.FromArgb(0, 11, 30);
            }
            SaveTheme(Theme);
        }
        private void SaveTheme(string Theme)
        {
            string pathTheme = @"C:\Previous game data\Saves\Theme.txt";
            if (!Directory.Exists(@"C:\Previous game data\Saves"))
            {
                Directory.CreateDirectory(@"C:\Previous game data\Saves");
                FileStream fs = new FileStream(pathTheme, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(Theme);
                sw.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(pathTheme, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(Theme);
                sw.Close();
                fs.Close();
            }
        }
        //Language Functions
        private void enToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language = "En";
            lblAlert.Text = "Click the CHECK ID button\n" +
                "before doing anything.";
            lblAlert.RightToLeft = RightToLeft.No;
            label19.Text = "Name";
            label17.Text = "Age";
            label15.Text = "Type";
            label13.Text = "Game Mode";
            RowNumber.HeaderText = "Row";
            NameClm.HeaderText = "Name";
            TypeClm.HeaderText = "Type";
            AgeClm.HeaderText = "Age";
            GameModeClm.HeaderText = "Game Mode";
            ScoreClm.HeaderText = "Score";
            CNGClm.HeaderText = "Correct Number";
            ListView.RightToLeft = RightToLeft.No;
            gbID.Text = "Your ID";
            gbLastAction.Text = "Last Action";
            gbSCH.Text = "Score and Chances";
            lblCh.Text = "Chances :";
            lblS.Text = "Score :";
            btnCheck.Text = "CHECK ID";
            button2.Text = "CLOSE";
            button1.Text = "RUN";
            btnGetScore.Text = "Get Score";
            btnResetChances.Text = "Reset Chances";
            if (Name == "نامشخص")
            {
                Name = "None";
                lblName.Text = Name;
                if (Age == "نامشخص")
                {
                    Age = "None";
                    lblAge.Text = Age;
                    if (Type == "نامشخص")
                    {
                        Type = "None";
                        lblType.Text = Type;
                        if (GameLevel == "نامشخص")
                        {
                            GameLevel = "None";
                            lblGameMode.Text = GameLevel;
                        }
                    }
                }
            }
        }
        private void faToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language = "Fa";
            lblAlert.Text = "قبل از هر کاری روی دکمه بررسی اطلاعات کلیک کنید";
            lblAlert.RightToLeft = RightToLeft.Yes;
            label19.Text = "نام";
            label17.Text = "سن";
            label15.Text = "جنسیت";
            label13.Text = "حالت بازی";
            RowNumber.HeaderText = "ردیف";
            NameClm.HeaderText = "نام";
            TypeClm.HeaderText = "جنسیت";
            AgeClm.HeaderText = "سن";
            GameModeClm.HeaderText = "حالت بازی";
            ScoreClm.HeaderText = "امتیاز";
            CNGClm.HeaderText = "عدد صحیح";
            ListView.RightToLeft = RightToLeft.Yes;
            gbID.Text = "اطلاعات شما";
            gbLastAction.Text = "اخرین عملیات";
            gbSCH.Text = "امتیاز و شانس ها";
            lblCh.Text = "شانس ها :";
            lblS.Text = "امتیازات :";
            btnCheck.Text = "بررسی اطلاعات";
            button2.Text = "بستن";
            button1.Text = "اجرا";
            btnGetScore.Text = "امتیاز گرفتن";
            btnResetChances.Text = "بازگردانی شانس ها";
            if (Name == "None")
            {
                Name = "نامشخص";
                lblName.Text = Name;
                if (Age == "None")
                {
                    Age = "نامشخص";
                    lblAge.Text = Age;
                    if (Type == "None")
                    {
                        Type = "نامشخص";
                        lblType.Text = Type;
                        if (GameLevel == "None")
                        {
                            GameLevel = "نامشخص";
                            lblGameMode.Text = GameLevel;
                        }
                    }
                }
            }
        }
        //Password Functions
        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBAR();
            this.Hide();
            Password Pass = new Password(Theme);
            Pass.ShowDialog();
            SetPassUser();
            this.Show();
        }
        private void SetPassUser()
        {
            string PathPass = @"C:\Previous game data\Saves\Password";
            if (File.Exists(PathPass))
            {
                FileStream fs = new FileStream(PathPass, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                PasswordUser = sr.ReadLine().Split(',')[1];
                sr.Close();
                fs.Close();
            }
        }
        //Hack The Score
        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnGetScore.Visible == false)
                btnGetScore.Visible = true;
            else
                btnGetScore.Visible = false;
        }
        private void btnGetScore_Click(object sender, EventArgs e)
        {
            btnGetScore.Visible = false;
            score += 50;
            lblScore.Text = score.ToString();
        }
        //Hack The Chances
        private void chanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnResetChances.Visible == false)
                btnResetChances.Visible = true;
            else
                btnResetChances.Visible = false;
        }
        private void btnResetChances_Click(object sender, EventArgs e)
        {
            if (chances < 5)
            {
                chances = 5;
            }
            lblChances.Text = chances.ToString();
            btnResetChances.Visible = false;
        }
        //Run Button Function
        private void rUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Select();
        }
        //Help For The Game
        private void ViewHelp_Click(object sender, EventArgs e)
        {
            HelpShortcutKey key = new HelpShortcutKey(Language);
            key.ShowDialog();
        }
        //Basic Description Of The Game
        private void ATGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutThisGame thisGame = new AboutThisGame(Language);
            thisGame.ShowDialog();
            this.Show();
        }
        //Report a Problem
        private void reportAProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback feedback = new Feedback(Theme);
            feedback.ShowDialog();
            this.Show();

        }
        //About Us Function
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs aboutUs = new AboutUs(Language, Theme);
            aboutUs.ShowDialog();
            this.Show();
        }
        //Restart The Application
        private void button6_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Previous game data"))
                Directory.Delete(@"C:\Previous game data");
            Application.Restart();
        }
        //Go To Console Mode (when click on this button then close the app , then can this app go to console mode)
        private void button5_Click(object sender, EventArgs e)
        {
            Program.AsOpen = "Console";
            Program.CheckRun = true;
        }
        //Excel Functions
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            OpenExcel(Show_Data);
        }
        private void OpenExcel(string[] DataShow)
        {
            string PathSave = @"C:\Previous game data\Saves\GuSeaHis.csv";
            using (var writer = new StreamWriter(PathSave))
            {
                var records = new List<Foo>
                {
                    new Foo{Name = DataShow[0] , Type = DataShow[1] , Age = DataShow[2] , GameLevel = DataShow[3]}
                };
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<Foo>();
                    csv.NextRecord();
                    foreach (var record in records)
                    {
                        csv.WriteRecord(record);
                        csv.NextRecord();
                    }
                }
            }
            Process.Start(PathSave);
        }
        //Close The App
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Mouse Leave Functions
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Change_Theme(Theme);
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Change_Theme(Theme);
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            Change_Theme(Theme);
        }
        //Mouse Hover Functions
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
        }
        //Leave Functions
        private void txtEntry_Leave(object sender, EventArgs e)
        {
            if (txtEntry.Text == "")
            {
                txtEntry.Text = "|\\-NUMBER-/|";
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter a name to search data".ToLower();
                textBox1.ForeColor = Color.Gray;
            }
        }
        //Enter Functions
        private void LastActionList_Enter(object sender, EventArgs e)
        {
            if (LastActionList.Focus())
                txtEntry.Focus();
        }
        private void txtEntry_Enter(object sender, EventArgs e)
        {
            if (txtEntry.Text == "|\\-NUMBER-/|")
            {
                TxtEntryHelp = txtEntry.Text;
                txtEntry.Text = "";
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter a name to search data".ToLower())
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }
        //TextChanged Functions
        private void StatusLabel_TextChanged(object sender, EventArgs e)
        {
            LastActionList.Rows.Add($"{LastActionList.RowCount}", StatusLabel.Text);
        }
        //Set Up User Info
        public void SaveSetUserInfo(string Name, string Age, string Type, string GameMode)
        {
            this.Name = Name;
            this.Age = Age;
            this.Type = Type;
            this.GameLevel = GameMode;
            GenerateRandomNumber(GameLevel);
            SaveLastAction();
        }
        //Progress Bar
        private void PBAR()
        {
            PBar.Visible = true;
            while (PBar.Value != 100)
            {
                Thread.Sleep(5);
                PBar.Value += 5;
            }
            PBar.Value = 0;
            PBar.Visible = false;
        }
        //GridView Functions
        private void ListView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ListView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
        //Size Change Functions
        private void Guess_Game_SizeChanged_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //RUN Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (lblName.Text != "None" && lblAge.Text != "None" && lblType.Text != "None" && lblGameMode.Text != "None")
            {
                if (int.TryParse(txtEntry.Text, out Out))
                    check = CheckInput(Convert.ToInt32(txtEntry.Text), GameLevel);
                lblChances.Text = chances.ToString();
                if (check == -1)
                {
                    if (Language == "En")
                    {
                        DialogResult dialog = MessageBox.Show("You have no chance to try, do you want to continue?", "Continue The Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            chances = 5;
                            lblChances.Text = chances.ToString();
                            GenerateRandomNumber(GameLevel);
                            string Result = Language == "En" ?
                                ">>You are back in the game" :
                                "شما دوباره به بازی بازگشتید";
                            StatusLabel.Text = Result;
                            txtEntry.Focus();
                            txtEntry.Text = "";
                        }
                        if (dialog == DialogResult.No)
                        {

                        }
                    }
                    if (Language == "Fa")
                    {
                        DialogResult dialog = MessageBox.Show("شما هیچ شانسی برای امتحان کردن ندارید، آیا میخواهید باز هم ادامه دهید؟", "ادامه بازی", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
                        if (dialog == DialogResult.Yes)
                        {
                            chances = 5;
                            lblChances.Text = chances.ToString();
                            string Result = Language == "En" ?
                                ">>You are back in the game" :
                                "شما دوباره به بازی بازگشتید";
                            StatusLabel.Text = Result;
                            txtEntry.Focus();
                            txtEntry.Text = "";
                        }
                        if (dialog == DialogResult.No)
                        {

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Log In!");
                Hide();
                GetUserID getiD = new GetUserID(Language);
                getiD.ShowDialog();
                Show();
            }
        }
        //Main Functions
        private void GoToNextNumber(string GameLevel)
        {
            //Hard Level
            if (GameLevel == "hard" || GameLevel == "Hard")
            {
                score += chances * 50;
                lblScore.Text = score.ToString();
                GenerateRandomNumber(GameLevel);
                chances = 5;
            }
            //Easy Level
            else
            {
                score += chances * 10;
                lblScore.Text = score.ToString();
                GenerateRandomNumber(GameLevel);
                chances = 5;
            }
            PBAR();
        }
        public void GenerateRandomNumber(string GameLevel)
        {
            //Hard Level
            if (GameLevel == "hard" || GameLevel == "Hard")
            {
                Random rn = new Random();
                rndNumber = rn.Next(1000);

            }
            //Easy Level
            else
            {
                Random rn = new Random();
                rndNumber = rn.Next(100);

            }
            PBAR();
        }
        private int CheckInput(int number, string GameLevel)
        {
            PBAR();
            string Result;
            if (number == rndNumber)
            {
                Result = Language == "En" ?
                    ">>The entered number is correct ;You get score" :
                    "عدد وارد شده درست است ، امتیاز دریافت کردید";
                SaveLastAction();
                GoToNextNumber(GameLevel);
                CorrectNumberGuess++;
                Console.Beep();
                StatusLabel.Text = Result;
                pictureBox1.Image = Properties.Resources.ok;
                Thread.Sleep(3000);
                Result = Language == "En" ?
                    ">>Generated another number ;Pls guess again" :
                    "یک عدد تصادفی دیگر تولید شد، دوباره حدس بزنید";
                txtEntry.Focus();
                txtEntry.Text = "";
                //pictureBox1.Image = Properties.Resources.help;
                StatusLabel.Text = Result;
                return 1;
            }
            chances--;
            if (chances > 0)
            {

                if (rndNumber > number)
                {
                    Result = Language == "En" ?
                    ">>Enter a bigger number" :
                    "یک عدد بزرگتر وارد کنید";
                    Console.Beep();
                    pictureBox1.Image = Properties.Resources.cancel;
                    StatusLabel.Text = Result;
                    Thread.Sleep(1000);
                    pictureBox1.Image = Properties.Resources.help;
                    txtEntry.Focus();
                }
                else
                {
                    Result = Language == "En" ?
                    ">>Enter a smaller number" :
                    "یک عدد کوچکتر وارد کنید"; Console.Beep();
                    pictureBox1.Image = Properties.Resources.cancel;
                    StatusLabel.Text = Result;
                }
                return 0;
            }
            return -1;
        }
    }
}
