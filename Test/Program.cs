using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //  __________Pirma uzduotis___
            //int adultAge = 18;

            //Console.WriteLine("Please enter your age");
            //int actualAge = Convert.ToInt32(Console.ReadLine());

            //if (actualAge <= adultAge)
            //{
            //    Console.WriteLine("Your age {0} is too young to to buy alcohol and drive.", actualAge);
            //}

            //else if (actualAge <= 20)
            //{
            //    Console.WriteLine("Your age {0} is too young to to buy alcohol but you can drive.", actualAge);
            //}

            //else
            //{
            //    Console.WriteLine("Your age {0} is ok to buy alcohol and drive car.", actualAge);
            //}

            //Console.ReadLine();


            //________antra uzduotis__________
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter third number: ");
            //    int num3 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter fourth number: ");
            //    double num4 = Convert.ToDouble(Console.ReadLine());

            //    if (num1 > 0 && num2 > 0 && num3 > 0 && num4 > 0)
            //    {
            //        Console.WriteLine("{0} + {1} + {2} + {3} = {4}", num1, num2, num3, num4, num1 + num2 + num3 + num4);
            //        Console.WriteLine("{0} - {1} - {2} - {3} = {4}", num1, num2, num3, num4, num1 - num2 - num3 - num4);
            //        Console.WriteLine("{0} * {1} * {2} * {3} = {4}", num1, num2, num3, num4, num1 * num2 * num3 * num4);
            //        Console.WriteLine("{0} / {1} / {2} / {3} = {4}", num1, num2, num3, num4, num1 / num2 / num3 / num4);
            //    }

            //    else
            //    {
            //        Console.Write("You entered negative number.");
            //    }
            //}
            //Console.ReadLine();

            //___________trecia uzduotis___________
            //List<int> numbers = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Enter number");
            //    int digit = Convert.ToInt32(Console.ReadLine());

            //    if (digit == 0)
            //    {
            //        Console.WriteLine("You enterd these numbers until enterd 0", digit);
            //        break;
            //    }
            //}
            //Console.ReadLine();

            //bandymai isvesti ivestus skaicius iki 0
            //numbers.AddRange(numbers);
            //numbers.Add("1");
            //int concat = String.Join(" ", numbers.ToArray());
            //if (digit == 0)   
            //    numbers.ForEach()
            //digit++
            //foreach (int digit in numbers)
            //Console.WriteLine(digit.ToString());
            // Console.WriteLine("[{0}]", int(",", numbers));
            //Array.Sort();           
            //bandymai isvesti ivestus skaicius iki 0


            ///    ___Ketvirta uzduotis____

            WordsDataBase wordsDataBase = new WordsDataBase();

            while (true)
            {
                Console.WriteLine("Enter your word");
                string word = Console.ReadLine();

                if (wordsDataBase.words.Contains(word))
                {
                    Console.WriteLine("This word is dublicate");
                }
                else
                    wordsDataBase.AddWord(word);
                Console.WriteLine("Your word was saved");
            }
        }
        //Console.ReadLine();
    }

}


