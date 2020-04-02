using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict1 = new Dictionary<string, string>
            {
                {"key1","2" },
                {"key2","1" },
                {"key3","8" },
                {"key4","9" },
                {"key5","6" }
            };
            Dictionary<string, string> dict2 = new Dictionary<string, string>
            {
                {"key1","7" },
                {"key2","2" },
                {"key3","8" },
                {"key4","4" },
                {"key5","6" }
            };

           foreach(KeyValuePair<string, string> keyValue1 in dict1)
            {
                foreach(KeyValuePair<string, string> keyValue2 in dict2)
                {
                    if(keyValue1.Key==keyValue2.Key && keyValue1.Value == keyValue2.Value)
                    {
                        Console.WriteLine(keyValue1.Key+" is presented in both x and y");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
