using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
                //EXERCISE 1 - UNCOMMENT BELOW-----------------------------
            //int? y = ReadInt("Type a number: ");
            //int? x = ReadInt("Type another number: ");
            //Console.WriteLine($"{y}+{x} = {y + x}");
            //Console.ReadLine();
                //----------------------------------------

                //EXERCISE 2 - UNCOMMENT BELOW -----------------------------
            //List<string> yearList = new List<string>();
            //for (int i = 0; i < 8; i++)
            //{
            //    string year = LeapYearCalculator("Write a year: ");
            //    if (year.Equals("Year must be between 0 and 9999.") || year.Equals("Thats not a correct year input."))
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(year);
            //    yearList.Add(year);
            //}
            //yearList.ForEach(i => Console.Write("{0}\n", i));
            //Console.ReadLine();
                //---------------------------------------------------------

                //EXERCISE 3 - UNCOMMENT BELOW-----------------------------
            //Console.Write("Enter string to see if palindrome: ");
            //string input = Console.ReadLine();
            //bool isPalindrome = IsPalindrome(input);
            //if (isPalindrome is true)
            //{
            //    Console.WriteLine($"{input} is palindrome!");
            //} else
            //{
            //    Console.WriteLine($"{input} is not palindrome!");
            //}
            //Console.ReadLine();
                //---------------------------------------------------------

                //EXERCISE 4 - UNCOMMENT BELOW-----------------------------
            //List<int> intList = new List<int>();
            //for (int i = 0; i <=100; i++)
            //{
            //    intList.Add(i);
            //}
            //WriteFizz(intList);
            //Console.ReadLine();
                //---------------------------------------------------------

                //EXERCISE 5 - UNCOMMENT BELOW-----------------------------
            //Console.Write("Enter number between 0-100: ");
            //RandomGame(int.Parse(Console.ReadLine()));
                //---------------------------------------------------------

                //EXERCISE 6 - UNCOMMENT BELOW-----------------------------
            //Console.Write("Enter number between 0-100: ");
            //RandomGameVsAi(int.Parse(Console.ReadLine()));
                //---------------------------------------------------------

        }       

        public static int? ReadInt(string input)
        {
            int? x = null;
            bool tryAgain = true;
            while (tryAgain is true)
            {
                try
                {
                    Console.Write(input);
                    x = int.Parse(Console.ReadLine());
                    tryAgain = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Thats not a number, try again: ");                
                }
            }
            return x;
        }
        public static string LeapYearCalculator (string input)
        {
            int x = 0;
            bool tryAgain = true;
            bool isLeapYear = false;
            string year = null;
            while (tryAgain is true)                
            {
                try
                {
                    Console.Write(input);
                    x = int.Parse(Console.ReadLine());
                    isLeapYear = DateTime.IsLeapYear(x);
                    tryAgain = false;
                    if (x > 9999 && x < 0)
                    {
                        Console.WriteLine("Year must be between 0 and 9999.");
                        tryAgain = true;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Thats not a correct year input, try again: ");
                }
            }
            year = x.ToString();
            if (isLeapYear is true)
            {
                return year + "*";
            }
            return year;
        }
        public static bool IsPalindrome(string input)
        {
            {
                bool isPalindrome = false;
                input = input.ToLower();
                input = input.Replace(" ", string.Empty);
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                
                string reversedString= new string(charArray);
                if (input.Equals(reversedString))
                {
                    return isPalindrome = true;
                }
                return isPalindrome;
            }
        }
        public static void WriteFizz(List<int> intList)
        {           
            foreach (int val in intList)
            {
                string fizz = IsDivisible(val, 3);
                string buzz = IsDivisible(val, 5);
                if (fizz.Equals("Fizz"))
                {
                    Console.Write("{0}\n", fizz);
                    fizz = String.Empty;
                }
                else if (buzz.Equals("Buzz"))
                {
                    Console.Write("{0}\n", buzz);
                    buzz = String.Empty;
                }
                else
                {
                    Console.Write("{0}\n", val);
                }             
            }

        }
        public static string IsDivisible(int x, int divideBy)
        {
            if ((x % divideBy) == 0 && divideBy == 3)
            {
                return "Fizz";
            }
            else if ((x % divideBy) == 0 && divideBy == 5)
            {
                return "Buzz";
            }
            else
            {
                return "Cannot divide!";
            }

        }
        public static void RandomGame (int inputNbr)
        {
            
            bool numberIsCorrect = false;
            var random = new Random();
            var number = random.Next(0, 100);          
            
            while (numberIsCorrect is false)
            {
                if (inputNbr > number)
                {
                    Console.Write("Too high, try again: ");
                    inputNbr = int.Parse(Console.ReadLine());
                }
                else if (inputNbr < number)
                {
                    Console.Write("Too low, try again: ");
                    inputNbr = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write($"{inputNbr} is correct!");
                    numberIsCorrect = true;
                }
            }
            Console.ReadLine();
        }
        public static void RandomGameVsAi(int inputNbr)
        {

            bool numberIsCorrect = false;
            var random = new Random();
            var number = random.Next(0, 100);

            while (numberIsCorrect is false)
            {
                var computerGuess = random.Next(0, 100);
                if (inputNbr > number)
                {
                    Console.Write("Too high, try again: ");
                    inputNbr = int.Parse(Console.ReadLine());              
                }
                else if (inputNbr < number)
                {
                    Console.Write("Too low, try again: ");
                    inputNbr = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write($"{inputNbr} is correct!");
                    numberIsCorrect = true;                                 
                }
                Console.WriteLine($"Computer guesses {computerGuess}");
                if (computerGuess == number)
                {
                    Console.WriteLine($"Computer is correct!");
                }
            }
            Console.ReadLine();
        }

    }
}
