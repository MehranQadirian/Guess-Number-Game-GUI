using System;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace GuessGame
{
    internal static class Program
    {
        private static string Input;
        private static int check = 0 , Log = 0;
        private static string path = @"C:\Previous game data\Saves\GuAllUserInfo.txt";
        private static string pathInfo = @"C:\Previous game data\Saves\GuDataInfo-ConsoleResult.txt";
        private static string pathLastSave = @"C:\Previous game data\Saves\GuAddOfTheReserv-ConsoleResult.txt";
        private static string PathPassword = @"C:\Previous game data\Saves\Password";
        private static string Name = "", Type = "", Age = "", GameLevel = "";
        private static bool awnsered = false;
        private static int rndnumber;
        private static int n;
        public static string AsOpen;
        public static bool CheckRun = false , ProgressCheck = false , CheckExPassword = false , Unlock = false;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [STAThread]
        static void Main()
        {
            IntPtr h = Process.GetCurrentProcess().MainWindowHandle;
            if(Log == 0)
            {
                ShowWindow(h, 0);
                Forms.AboutThisGame About = new Forms.AboutThisGame("Fa");
                About.ShowDialog();
                ShowWindow(h, 5);
                Log++;
            }
            
            if (Unlock == false)
            {
                if (File.Exists(PathPassword))
                {
                    CheckExPassword = true;
                }
                if (CheckExPassword == true)
                {
                    ShowWindow(h, 0);
                    //Application.Run(new Forms.EntryPassword());
                    Forms.EntryPassword entry = new Forms.EntryPassword();
                    entry.ShowDialog();
                    if (entry.SendCheck() == true)
                    {
                        Unlock = true;
                        
                        ShowWindow(h, 5);
                    }
                    entry.Close();
                    Main();
                }
            }
            if (CheckRun == false)
            {
                Console.CursorVisible = false;
                Console.Write("Do you want to use console environment or form [");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('1');
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" : Console][");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('2');
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" : Form] ::  ");
                int W = int.Parse(Console.ReadLine());
                if (W == 1)
                {
                    AsOpen = "Console";
                    CheckRun = true;
                }
                else if (W == 2)
                {
                    AsOpen = "Form";
                    CheckRun = true;
                }
                else
                {
                    Console.WriteLine("Error : You don't have 2 more choices!");
                    Waiting();
                    CheckRun = false;
                    Main();
                }
            }
            if(AsOpen == "Form")
            {
                // Hide
                
                ShowWindow(h, 0);
                Application.Run(new Forms.Guess_Game());
                if (AsOpen == "Console")
                {
                    CheckRun = true;
                    ShowWindow(h, 5);
                    Main();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        ShowWindow(h, 5);
                        Main();
                    }

                }
            }
            else if(AsOpen == "Console")
            {
                Console.Title = "Loading Game".ToUpper();
                Random r = new Random();
                int rand, i = 0, j = 0, u = 1;
                if (ProgressCheck == false)
                    using (var progress = new ProgressBar())
                    {
                        while (progress.Value != 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Loading...\n");
                            rand = r.Next(25, 30);
                            progress.Value = ((i + 1) * 5) / 3;
                            for (j = 0; j < ((progress.Value * 3) / 5) - 1; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write('#');
                            }
                            Console.CursorLeft = 0;
                            Console.Write(' ');
                            Console.CursorLeft = 59;
                            Console.Write(' ');
                            Console.CursorLeft = 60;
                            Console.Write($"[{progress.Value}%]\t");
                            Console.CursorLeft = 66;
                            if (u == 1)
                                Console.Write('\\');
                            if (u == 2)
                                Console.Write('/');
                            if (u == 3)
                                Console.Write('—');
                            Console.CursorLeft = 1;
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(rand);
                            Console.Clear();
                            i++;
                            if (u < 3)
                                u++;
                            else
                                u = 1;
                        }
                        ProgressCheck = true;
                    }
                Console.Title = "Guess Number Game".ToUpper();
                int trying = 0;
                while (true)
                {
                    try
                    {

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        if (Directory.Exists(@"C:\Previous game data") && awnsered == false)
                        {
                            if (File.Exists(pathLastSave))
                            {
                                StreamReader reader = new StreamReader(pathLastSave);

                                string[] Data = new string[6];
                                Data = reader.ReadLine().Split(',');
                                reader.Close();
                                if (Data[0] != "")
                                {
                                    Name = Data[0];
                                    Type = Data[1];
                                    Age = Data[2];
                                    GameLevel = Data[3];
                                    if (Name != "" && Age != "" && Type != "" && GameLevel != "")
                                    {
                                        Console.WriteLine($"You are logged in!\n" +
                                            $"Wellcome {Name.ToUpper()} to guess game.\n" +
                                            $"Your information : \n" +
                                            $"Name       : {Name}\n" +
                                            $"Age        : {Age}\n" +
                                            $"Type       : {Type}\n" +
                                            $"Game Level : {GameLevel}");
                                        Console.Write("Is that your information? [y or n] : ");
                                        string aw = Console.ReadLine();
                                        AcceptingInformation(aw);
                                    }
                                }
                            }
                        }
                        if (awnsered == false)
                        {

                            Console.Clear();
                            GetValue();
                            if (!Directory.Exists(@"C:\Previous game data\Saves"))
                                Directory.CreateDirectory(@"C:\Previous game data\Saves");
                            StreamWriter sw = new StreamWriter(pathInfo);
                            sw.WriteLine($"{Name},{Type},{Age},{GameLevel}");
                            sw.Flush();
                            sw.Close();
                            StreamWriter sw1 = new StreamWriter(pathLastSave);
                            sw1.WriteLine($"{Name},{Type},{Age},{GameLevel},0,0");
                            sw1.Flush();
                            sw1.Close();
                            Main();
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Class.GuessGame guessGame = new Class.GuessGame(Name, Type, Convert.ToInt32(Age), GameLevel, path, pathLastSave, AsOpen,true);
                        Console.Clear();
                        ShowMenu();
                        while (true)
                        {
                            guessGame.PrintSC();
                            Console.Write("Entry : "); Input = Console.ReadLine();
                            if (Input == "help")
                            {
                                Console.Clear();
                                guessGame.HelpUser();
                                guessGame.SaveLastAction();
                            }
                            //To hacking game
                            else if (Input == "helpmeplsscore")
                            {
                                Console.Clear();
                                ShowMenu();
                                guessGame.SetScore();
                            }
                            //To hacking game
                            else if (Input == "helpmeplschances")
                            {
                                Console.Clear();
                                guessGame.SetChances();
                                guessGame.SaveLastAction();
                                ShowMenu();
                            }
                            else if (Input == "menu")
                            {
                                Console.Clear();
                                ShowMenu();
                            }
                            else if (Input == "myid")
                            {
                                Console.Clear();
                                ShowMenu();
                                FileStream fs = new FileStream(pathInfo, FileMode.Open, FileAccess.Read);
                                StreamReader sr = new StreamReader(fs);
                                string AllData = sr.ReadLine();
                                string[] SplitedData = AllData.Split(',');
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Your information : \n\t>");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("Name : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"{SplitedData[0].ToUpper()} , ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("Age : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"{SplitedData[2].ToUpper()} , ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("Type : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"{SplitedData[1].ToUpper()} , ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("Game Mode : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"{SplitedData[3].ToUpper()}");
                                sr.Close();
                                fs.Close();

                            }
                            else if (Input == "save")
                            {
                                Console.Clear();
                                ShowMenu();
                                guessGame.SaveToFile();
                                guessGame.SaveLastAction();
                            }
                            else if (Input == "del")
                            {
                                Console.Clear();
                                ShowMenu();
                                guessGame.DeleteFile();
                            }
                            else if (Input == "restart")
                            {
                                Console.Clear();
                                ShowMenu();
                                guessGame.ReStartGame(Name, Type, Convert.ToInt32(Age), GameLevel, path);
                                guessGame.ResetScore();
                                guessGame.SetChances();
                                guessGame.SaveLastAction();
                            }
                            else if (Input == "tohard")
                            {
                                Console.Clear();
                                if (GameLevel == "easy" || GameLevel == "Easy")
                                {
                                    GameLevel = "Hard";
                                    guessGame.ReStartGame(Name, Type, Convert.ToInt32(Age), GameLevel, path);
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("[!] Another number was generated.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Pls press any key to continue..."); Console.ReadKey();
                                    Console.Clear();
                                }
                                else if (GameLevel == "hard" || GameLevel == "Hard")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("[!] You are in a hard mode right now.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                ShowMenu();
                            }
                            else if (Input == "toeasy")
                            {
                                Console.Clear();
                                if (GameLevel == "hard" || GameLevel == "Hard")
                                {
                                    GameLevel = "Easy";
                                    guessGame.ReStartGame(Name, Type, Convert.ToInt32(Age), GameLevel, path);
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("[!] Another number was generated.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Pls press any key to continue..."); Console.ReadKey();
                                    Console.Clear();
                                }
                                else if (GameLevel == "easy" || GameLevel == "Easy")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("[!] You are in a easy mode right now.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                ShowMenu();
                            }
                            else if (Input == "search")
                            {
                                Console.Clear();
                                ShowMenu();
                                Console.Write("Enter a name for search : "); string SelectedName = Console.ReadLine();
                                guessGame.SearchFromData(SelectedName);
                            }
                            else if (Input == "show")
                            {
                                Console.Clear();
                                ShowMenu();
                                guessGame.ShowAllDataSaved();
                            }
                            else if (Input == "rsgame")
                            {
                                Console.Clear();
                                awnsered = false;
                                Main();
                            }
                            else if (Input == "count")
                            {
                                Console.Clear();
                                ShowMenu();
                                guessGame.BestGame();
                            }
                            else if (Input == "showsba")
                            {
                                Console.Clear();
                                ShowMenu();
                                guessGame.SortListByAge();
                            }
                            else if (Input == "top")
                            {
                                Console.Clear();
                                ShowMenu();
                                guessGame.TopPlayer();
                            }
                            else if (Input == "exit")
                            {
                                Console.Clear();
                                Console.Write("\nDo you want to log out? [yes][no] : ");
                                string yn = Console.ReadLine();
                                guessGame.SaveLastAction();
                                guessGame.SaveToFile();
                                Exit(yn);
                            }
                            else if (int.TryParse(Input, out n))
                            {
                                Console.Clear();
                                check = guessGame.CheckUserInput(Convert.ToInt32(Input), GameLevel);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Beep();
                                Console.WriteLine(">>Error");
                                Console.ForegroundColor = ConsoleColor.White;

                            }


                            if (check == -1)
                            {
                                Random rnd = new Random();
                                rndnumber = rnd.Next(1, 4);
                                Console.Write("Do you still want to continue? [yes or no] : ");
                                string awnser = Console.ReadLine();
                                switch (awnser)
                                {
                                    case "yes":
                                        guessGame.SaveLastAction();
                                        guessGame.SetChances();
                                        trying++;
                                        CheckTrying(trying);
                                        continue;
                                    case "no":
                                        guessGame.SaveLastAction();
                                        guessGame.Print();
                                        Console.ReadKey();
                                        break;
                                }
                                if (awnser == "no")
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n{ex.Message}");
                        Waiting();
                        Main();
                    }

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Beep();
                Console.WriteLine(">Error");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            
        }
        public static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Welcome ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Name.ToUpper());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" to guess game  => (");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(GameLevel.ToUpper());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(")");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You can use the following keywords!".ToUpper());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine
                            (
                            "[help]\t\t" +
                            "To get help\n".ToUpper() +
                            "[save]\t\t" +
                            "To saveing the data game\n".ToUpper() +
                            "[del]\t\t" +
                            "To deleteing the data game\n".ToUpper() +
                            "[search]\t" +
                            "To search among previously saved game data\n".ToUpper() +
                            "[myid]\t\t" +
                            "To show you all your information\n".ToUpper() +
                            "[tohard]\t" +
                            "Change game mode to hard mode\n".ToUpper() +
                            "[toeasy]\t" +
                            "Change game mode to easy mode\n".ToUpper() +
                            "[count]\t\t" +
                            "Display the number of games played by each player\n".ToUpper() +
                            "[show]\t\t" +
                            "Display all previously saved information or data\n".ToUpper() +
                            "[showsba]\t" +
                            "Display all the previously saved data, except ".ToUpper() +
                            "that they are sorted by the age of the users\n".ToUpper() +
                            "[top]\t\t" +
                            "Display the top 5 players\n".ToUpper() +
                            "[menu]\t\t" +
                            "Display the this menu again\n".ToUpper() +
                            "[rsgame]\t" +
                            "Restart the game to change user information ,etc\n".ToUpper() +
                            "[exit]\t\t" +
                            "Close the program\n".ToUpper()
                            );
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Or enter a number!\n".ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Exit(string input)
        {
            while (true)
            {
                if (input == "")
                {
                    Console.Write("Do you want to log out? [yes][no] : ");
                    string Input = Console.ReadLine();
                    Exit(Input);
                }
                if (input == "yes")
                {
                    Environment.Exit(0);
                    
                }
                else if (input == "no")
                {
                    Console.Clear();
                    ShowMenu();
                    Main();
                }
                else
                {
                    Console.WriteLine(">Error");
                    input = "";
                }
            }
        }
        static void CheckTrying(int trying)
        {
            Class.GuessGame guessGame = new Class.GuessGame(Name, Type, Convert.ToInt32(Age), GameLevel, path,pathLastSave,AsOpen,true);
            if (trying > 10)
            {
                Console.WriteLine("==============================================");
                switch (rndnumber)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(">>You are so dumb");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(">>I will help you, but think more next time");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(">>What did you think to yourself, did you think it was very good?");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(">>Good luck to the one who can guess my number, you don't know anything");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                guessGame.ExtraScore();
                guessGame.HelpUser();
                Console.WriteLine("==============================================");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("[!] You faild to guess this number another number was generated!");
                Console.ForegroundColor = ConsoleColor.White;
                if (GameLevel == "hard")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("[!] The random number generated in hard mode is between 0 and 1000.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("[!] The random number generated in easy mode is between 0 and 100.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                guessGame.GenerateRandomNumber(GameLevel);
            }
        }
        static void Waiting()
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Wating");
                for (int k = 0; k < 3; k++)
                {
                    Console.Write('.');
                    Thread.Sleep(1000);
                }
                Console.Clear();
            }
        }
        static void GetValue()
        {
            Console.Write("Enter your name : "); Name = Console.ReadLine();
            Console.Write("Male or female : "); Type = Console.ReadLine();
            Console.Write("How old are you : "); Age = Console.ReadLine();
            Console.Write("Hard or easy ? "); GameLevel = Console.ReadLine();
        }
        static void AcceptingInformation(string Awnser)
        {
            if (Awnser == "y" || Awnser == "Y")
                awnsered = true;
            else if (Awnser == "n" || Awnser == "N")
            {
                File.Delete(pathInfo);
                File.Delete(pathLastSave);
                awnsered = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error and press any key to reset game...");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Main();
            }
        }
        public static void Save(string Uinfo , string GameLevel , string CNG , string score)
        {
            //Class.User user = new Class.User(Name, Type, Convert.ToInt32(Age));
            string SC = score.ToString(), CNG1 = CNG.ToString(), UserInfo = Uinfo, GL = GameLevel;
            string Data = $"{SC},{CNG},{UserInfo},{GL}";
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
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nAll data are saved");
                        Console.ForegroundColor = ConsoleColor.White;
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
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nAll data are saved");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(Data);
                        sw.Close();
                        fs.Close();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nAll data are saved");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
                Waiting();
                ShowMenu();
            }
        }
    }
}
