using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGAPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to MergedString Console Application.");
                Console.WriteLine("Put the first value");
                Console.WriteLine(string.Format("Format: {0}", "ABC"));
                string valor1 = Console.ReadLine();

                Console.WriteLine("First Value = " + valor1);

                Console.WriteLine("Put the Second Value");
                Console.WriteLine(string.Format("Format: {0}", "DEF"));
                string valor2 = Console.ReadLine();


                Console.WriteLine("Second Value = " + valor2);

                string result1 = "";

                if (valor1.Length == valor2.Length)
                {
                    for (int i = 0; i < valor1.Length; i++)
                    {
                        result1 += valor1.Substring(i, 1) + valor2.Substring(i, 1);
                    }

                }
                else
                {
                    if (valor1.Length < valor2.Length)
                    {
                        for (int i = 0; i < valor2.Length; i++)
                        {
                            if (valor1.Length <= i)
                            {
                                result1 += valor2.Substring(i, 1);
                            }
                            else
                            {
                                result1 += valor1.Substring(i, 1) + valor2.Substring(i, 1);
                            }

                        }

                    }
                    else
                    {

                        for (int i = 0; i < valor1.Length; i++)
                        {
                            if (valor2.Length <= i)
                            {
                                result1 += valor1.Substring(i, 1);
                            }
                            else
                            {
                                result1 += valor1.Substring(i, 1) + valor2.Substring(i, 1);
                            }

                        }

                    }
                }

                Console.WriteLine("Result MergedString: " + result1);
                Console.Write("Press any key to try again........");
                Console.ReadKey();

            }


        }
    }
}

