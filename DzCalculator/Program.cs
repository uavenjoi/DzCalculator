using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzCalculator
{
    class Program
    {
        public class Cl
        {

            public static int TakeStr(ref string a, string z, string b)
            {
                string er = "Ошибка";
                string res;
                int res2 = 0;
                int n;
                int m;
                foreach (char c in a)
                    if (Char.IsNumber(c))
                    {
                        foreach (char v in b)
                        {
                            if (Char.IsNumber(v))
                            {
                                int.TryParse(a, out n);
                                int.TryParse(b, out m);
                                switch (z)
                                {
                                    case "+":
                                        res2 = n + m;

                                        return res2;
                                    case "-":
                                        res2 = n - m;

                                        return res2;
                                    case "/":
                                        res2 = n / m;

                                        return res2;
                                    case "*":
                                        res2 = n * m;

                                        return res2;
                                }
                            }
                            else
                            {
                                switch (z)
                                {
                                    case "+":
                                        res = a + b;
                                        Console.WriteLine(res);
                                        break;
                                    case "-":
                                        res = er;
                                        Console.WriteLine(er);
                                        break;
                                    case "*":
                                        res = er;
                                        Console.WriteLine(er);
                                        break;
                                    case "/":
                                        res = er;
                                        Console.WriteLine(er);
                                        break;
                                }

                            }
                        }

                    }
                    else
                    {

                        switch (z)
                        {
                            case "+":
                                res = a + b;
                                Console.WriteLine(res);
                                break;
                            case "-":
                                res = er;
                                Console.WriteLine(er);
                                break;
                            case "*":
                                res = er;
                                Console.WriteLine(er);
                                break;
                            case "/":
                                res = er;
                                Console.WriteLine(er);
                                break;


                        }




                    }
                return res2;
            }

            public static void Main(string[] args)
            {
                string a = Console.ReadLine();
                string z = Console.ReadLine();
                string b = Console.ReadLine();


                Cl cl = new Cl();

                int test = Cl.TakeStr(ref a, z, b);
                Console.WriteLine(test);









                Console.ReadLine();


            }
        }
    }
}
