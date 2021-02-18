using System;
using System.Collections.Generic;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { };
            int input = 1;
            while (numbers.Count == 0)
            {
                Console.Write("Enter the first number: ");
                input = Int32.Parse(Console.ReadLine());
                if (input > 0)
                {
                    numbers.Add(input);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            

            while (input != 0)
            {
                Console.Write("Enter the next number (0 if no more): ");
                input = Int32.Parse(Console.ReadLine());
                if (input != 0)
                {
                    if (input > 0)
                    {
                    numbers.Add(input);
                    } else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
            }

            int number1, number2, euclidMod, GCD = -1, LCM = -1, GCDforLCM, LCMnumber1, LCMnumber2;
            if (numbers.Count <= 1)
            {
                Console.WriteLine("Not enough numbers.");
            } else
            {
                for (int i = 1; i <= numbers.Count - 1; i++)
                {
                    if (GCD == -1)
                    {
                        number1 = numbers[i - 1];
                    } else
                    {
                        number1 = GCD;
                    }
                    number2 = numbers[i];
                    euclidMod = number1 % number2;
                    while (euclidMod != 0)
                    {
                        number1 = number2;
                        number2 = euclidMod;
                        euclidMod = number1 % number2;
                    }
                    GCD = number2;
                    if (LCM == -1)
                    {
                        LCM = numbers[i - 1] * numbers[i] / GCD;
                    } else
                    {
                        LCMnumber1 = LCM;
                        LCMnumber2 = numbers[i];
                        euclidMod = LCMnumber1 % LCMnumber2;
                        while (euclidMod != 0)
                        {
                            LCMnumber1 = LCMnumber2;
                            LCMnumber2 = euclidMod;
                            euclidMod = LCMnumber1 % LCMnumber2;
                        }
                        GCDforLCM = LCMnumber2;
                        LCM = LCM * numbers[i] / GCDforLCM;
                    }
                }

                Console.WriteLine("GCD: " + GCD);
                Console.WriteLine("LCM: " + LCM);

            }
        }
    }
}
