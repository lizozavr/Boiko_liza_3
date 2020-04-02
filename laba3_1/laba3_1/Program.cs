using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace laba3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> poem = new List<string>();
            poem.AddRange(new string[]
            {
                "Some say the world will end in fire, ",
                "Some say in ice.",
                "From what I’ve tasted of desire",
                "I hold with those who favor fire.",
                "But if it had to perish twice,",
                "I think I know enough of hate",
                "To say that for destruction ice",
                "Is also great",
                "And would suffice."
            });

            foreach (var i in poem)
                Console.WriteLine(i);

            Console.WriteLine("___________________");


            List<string> num = new List<string>();
            string[] s;
           foreach (var i in poem)
            {
                char[] charSeparators = new char[] { ' ' };
                s = i.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                num.Add(s.Length.ToString() + " "+i);
            }
           
            var select = from t in num //определяем каждый объект из num kak t
                         orderby t//упорядоч. по возрастанию
                         select t;//выбираем объект

            foreach (string str in select)
            {
                Console.WriteLine(str.Substring(2));
            }
            Console.ReadKey();
        }
    }
}
