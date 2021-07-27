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
         

            while (true)
            {
                string otvet = "";
                string otvet1 = "";
                int limit = 0;
                int interes = 1;
                
                Console.WriteLine("Ведите сколько цифр вы хотитепроверить");
                string imput = Console.ReadLine();
                bool resul = int.TryParse(imput, out limit);
                if (resul == true)
                {
                    while (interes <= limit)
                    {


                        Console.WriteLine("Веди " + interes + " чисел");
                        double a = double.Parse(Console.ReadLine());
                        interes++;
                        if (a % 2 == 0)
                        {
                            string stroka = Convert.ToString(a);
                            otvet = otvet + " " + stroka;


                        }
                        else
                        {
                            string stroka = Convert.ToString(a);
                            otvet1 = otvet1 + " " + stroka;
                        }

                    }

                }
                else
                {

                    Console.WriteLine("Ты всёл букву");


                }
                Console.WriteLine("Ваши четные числа " + otvet);
                Console.WriteLine("Ваши не четные числа " + otvet1);






                Console.ReadKey();
            }
           
        }
    }
}
