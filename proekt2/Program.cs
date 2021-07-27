using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string otvet = " ";
            int limit = 0;
            int interes = 1;
            for (int i = 0; i < 50000; i++)
            {
                
                Console.WriteLine("Ведите сколько цифр вы хотитепроверить");
                string imput = Console.ReadLine();
                bool resul = int.TryParse(imput, out limit);
                if (resul == true)
                {
                    while (interes<=limit)
                    {
                        
                        
                        Console.WriteLine("Веди "+interes+" чисел");
                        double a = double.Parse(Console.ReadLine()).PadRight(10);
                        interes++;
                        if (a%2==0)
                        {
                            string stroka =Convert.ToString(a);
                            otvet = otvet + stroka;
                            

                        }
                        else
                        {

                        }

                    }

                }
                else
                {
                    int g = 0;
                    g = 2 - i;
                    Console.WriteLine("Ты всёл букву");
                    Console.WriteLine("У тебя осталось " + g + " попыток ");
              
                }
                Console.WriteLine(otvet);
            }
            Console.Clear();
            Console.ReadKey();
        }
    }
}
