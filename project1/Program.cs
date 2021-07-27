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
            //dy1();
            converter();

        }
        static void dy1()   
        {
            Console.WriteLine("Ведитe число!");
            string str;
            str = Console.ReadLine();
            Console.WriteLine(str);
            int a;
            bool resalt = int.TryParse(str, out a);
            a.ToString();
            if (resalt)
            {
                Console.WriteLine("Всё круто)))" + a);
            }
            else
            {
                Console.WriteLine("Ты меня обманул и всёл букву " + str + " (((((");
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
       
        static void converter()
        {

            const double dolor = 27.04;
            const double evro = 31.82;
            double evro1;
            double dolor1;
            double grivna;
            double grivna1;
            int a2 = 0;
            int a1 = 0;
            int a3 = 0;
            int a4 = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Выберете какую валюту вы будете конвертировать\n1-$\n2-евро\n3-гривна");
                string input = Console.ReadLine();

                bool result = int.TryParse(input, out a1);
                if (result == true)
                {
                    Console.WriteLine("Молодец ты вёл цифру)))");
                    break;
                }
                else
                {
                    int g = 0;
                    g = 3 - i;
                    Console.WriteLine("Чел ты кого обмануть хочешь(((9");
                    Console.WriteLine("У тебя осталось " + g + " попыток ");
                }
            }
            Console.WriteLine("количество");
            string inpu = Console.ReadLine();
            int b = 0;
            bool resu = int.TryParse(inpu, out b);
            if (resu == true)
            {
                switch (a1)
                {
                    case 1:
                        Console.WriteLine("вы выбрали $");
                        Console.WriteLine("выберете в какую валюту конвертировать\n1-евро\n2-гривна");
                        string inp = Console.ReadLine();
                        bool resul = int.TryParse(inp, out a2);
                        if (resul == true)
                        {
                            switch (a2)
                            {
                                case 1:
                                    grivna = b * dolor;
                                    evro1 = grivna / evro;
                                    Console.WriteLine(evro1);
                                    break;
                                case 2:
                                    grivna = b * dolor;
                                    Console.WriteLine(grivna);
                                    break;
                            }
                        }
                        else
                        {
                            
                            Console.WriteLine("НЕ беси меня чел!!");
                        }
                       
                        break;
                    case 2:
                        Console.WriteLine("вы выбрали евро");
                        Console.WriteLine("выберете в какую валюту конвертировать\n1-$\n2-гривна");
                        string i = Console.ReadLine();
                        bool res = int.TryParse(i, out a3);
                        if (res == true)
                        {
                            switch (a3)
                            {
                                case 1:
                                    grivna1 = b * evro;
                                    dolor1 = grivna1 / dolor;
                                    Console.WriteLine(dolor1);
                                    break;
                                case 2:
                                    grivna = b * evro;
                                    Console.WriteLine(grivna);
                                    break;

                            }
                        }
                        else
                        {

                            Console.WriteLine("НЕ беси меня чел!!");
                        }

                       
                        break;
                    case 3:
                        Console.WriteLine("вы выбрали гривну");
                        Console.WriteLine("выберете в какую валюту конвертировать\n1-$\n2-евро");
                        string r = Console.ReadLine();
                        bool re = int.TryParse(r, out a4);
                        if (re == true)
                        {
                            switch (a4)
                            {
                                case 1:

                                    grivna = b / dolor;
                                    Console.WriteLine(grivna);
                                    break;
                                case 2:
                                    grivna = b / evro;
                                    Console.WriteLine(grivna);
                                    break;
                            }
                        }
                        else
                        {

                            Console.WriteLine("НЕ беси меня чел!!");
                        }
                       

                        break;
                }

            }
            else
            {
                Console.WriteLine("Чел ты кого обмануть хочешь,я же сказал веди ЦИЫФРУ((((");
            }





            Console.ReadKey();
        }

    }
}
