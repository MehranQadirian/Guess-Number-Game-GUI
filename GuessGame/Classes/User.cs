using System;
using System.IO;

namespace GuessGame.Class
{
    class User
    {
        protected string Name;
        protected string Type;
        protected int Age;
        public User(string Name , string Type , int Age)
        {
            this.Name = Name;
            this.Type = Type;
            this.Age = Age;
        }
        public User(string Type, int Age)
        {
            Name = "None";
            this.Type = Type;
            this.Age = Age;
        }
        public User(string Name , string Type)
        {
            this.Name = Name;
            this.Type = Type;
            Age = 0;
        }
        public User(string Name)
        {
            this.Name = Name;
            Type = "Male";
            Age = 0;
        }
        public User()
        {
            Name = "None";
            Type = "Male";
            Age = 0;
        }
        public virtual void Print()
        {
            Console.WriteLine
                (
                $"Name : {Name}\n" +
                $"Type : {Type}\n" +
                $"Age  : {Age}\n"
                );
        }
        
        public string SendData()
        {
            string AllInfo = $"{Name},{Type},{Age}";
            return AllInfo;
        }
        public virtual void SetVal(string Name, string Type, int Age, string GameLevel, string path)
        {
            this.Name = Name;
            this.Type = Type;
            this.Age = Age;
        }
        public virtual void SearchFromData(string Name) { }
        public virtual void ShowAllDataSaved() { }
        public virtual void TopPlayer() { }
        public virtual void SortListByAge() { }
        public virtual void BestGame() { }
    }
}
