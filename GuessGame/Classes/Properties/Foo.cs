using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace GuessGame.Classes
{
    public class Foo
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Type { get; set; }
        public string GameLevel { get; set; }
    }
    public class Doo
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Type { get; set; }
        public string GameLevel { get; set; }
        public string Score { get; set; }
        public string CorrectNumber { get; set; }
    }
    public class FooMap : ClassMap<Foo>
    {
        public FooMap()
        {
            Map(m => m.Name).Index(0).Name("name");
            Map(m => m.Type).Index(1).Name("type");
            Map(m => m.Age).Index(2).Name("age");
            Map(m => m.GameLevel).Index(3).Name("game mode");
        }

        private object Map(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
    public class DooMap : ClassMap<Doo>
    {
        public DooMap()
        {
            Map(m => m.Name).Index(0).Name("name");
            Map(m => m.Type).Index(1).Name("type");
            Map(m => m.Age).Index(2).Name("age");
            Map(m => m.GameLevel).Index(3).Name("game mode");
            Map(m => m.Score).Index(3).Name("score");
            Map(m => m.CorrectNumber).Index(3).Name("correct number");
        }

        private object Map(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
