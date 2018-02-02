using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment02
{
    class Program
    {
        public static string sentence = "How many vowels in this string";
        public static int consonantCount = 0;
        public static int vowelCount = 0;

        public static int[] array1 = {10, 56, 22, 50, 100, 63, 15};

        static void Main(string[] args)
        {
            NavigateConsoleApp();
        }

        private static void FindHighestNumInArray(int[] array1)
        {
            int biggestNum = array1[0];

            for (int i = 0; i < array1.Length; i++)
            {
                if (biggestNum < array1[i])
                {
                    biggestNum = array1[i];
                }
            }
            PrintArray(array1);
            PrintBiggestNum(biggestNum);
        }

        private static void PrintArray(int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("{0}, ", array1[i]);
            }
        }

        private static void PrintBiggestNum(int biggestNum)
        {
            Console.WriteLine("\nThe biggest number in the array is {0}\n\n", biggestNum);
            NavigateConsoleApp();
        }

        private static void GetUserInput()
        {
            Console.WriteLine("Enter an integer you want to add to then average: ");

            bool bit = int.TryParse(Console.ReadLine(), out int userInput);

            if (bit)
            {
                CalcAverage(GetNumToAverage(userInput), userInput);
            }
            else
            {
                Console.WriteLine("You entered an invalid integer.\n");
                GetUserInput();
            }
        }

        private static int GetNumToAverage(int userInput)
        {
            int numToAverage = 0;

            for (int i = 0; i <= userInput; i++)
            {
                if(numToAverage != 0)
                    Console.WriteLine("{0} + {1}", numToAverage, i);

                numToAverage += i;
            }
            return numToAverage;
        }

        private static void CalcAverage(int numToAverage, int userInput)
        {
            double printNum = numToAverage / userInput;
            Console.WriteLine("{0} / {1}", numToAverage, userInput);
            Console.WriteLine("The average of your added numbers is {0}\n\n", printNum);
            NavigateConsoleApp();
        }

        private static void GetVowelCount(string sentence)
        {
            int i = 0;
            List<string> vowels = new List<string>();
            vowels.Add("a");
            vowels.Add("e");
            vowels.Add("i");
            vowels.Add("o");
            vowels.Add("u");

            while (i < sentence.Length)
            {
                if (vowels.Contains(sentence[i].ToString()))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
                i++;
            }
            WriteVowelResponse();
        }

        private static void WriteVowelResponse()
        {
            Console.WriteLine("The string is \"{0}\"", sentence);
            Console.WriteLine("The string had {0} vowel(s) in it.", vowelCount);
            Console.WriteLine("The string had {0} consonant(s) in it.\n\n", consonantCount);
            NavigateConsoleApp();
        }

        private static void NavigateConsoleApp()
        {
            Console.WriteLine("Press A to skip to the highest number in Array finder.");
            Console.WriteLine("\n\nPress V to skip to Vowels counter.");
            Console.WriteLine("\n\nPress C to skip to Calculating the average.");
            Console.WriteLine("\n\nPress any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "a")
            {
                Console.Clear();
                FindHighestNumInArray(array1);
            }
            else if (quitKey.Key.ToString().ToLower() == "v")
            {
                Console.Clear();
                GetVowelCount(sentence);
            }
            else if (quitKey.Key.ToString().ToLower() == "c")
            {
                Console.Clear();
                GetUserInput();
            }
        }
    }
}
