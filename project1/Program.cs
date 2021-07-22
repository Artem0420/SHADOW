using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ведитe число!");
            string str;
            str = Console.ReadLine();
            Console.WriteLine(str);
            int a;
            bool resalt = int.TryParse(str, out a);
            if(resalt)
            {
                Console.WriteLine("Всё круто)))" + a);
            }
            else
            {
                Console.WriteLine("Ты меня обманул и всёл букву " + str+" (((((");
            }
            
            Console.ReadKey();

        }
    }
}
