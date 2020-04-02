using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace laba3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = {"Chop your own wood and it will warm you twice.",//10
                "The weak can never forgive. Forgiveness is the attribute of the strong.",//12
                "I don’t care what you think about me. I don’t think about you at all.",//15
                "Wise men speak because they have something to say; fools because they have to say something.",//16
                "Work hard to get what you like, otherwise you'll be forced to just like what you get. ",//17
                "In the End, we will remember not the words of our enemies, but the silence of our friends",};//18

            int kol = 0;
            foreach (var i in line)
            {
                char[] charSeparators = new char[] { ' ' };
                string[] a = i.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                kol += (from t in a select t).Count();
            }
            Console.WriteLine(kol);
            Console.ReadKey();
        }
    }
}
