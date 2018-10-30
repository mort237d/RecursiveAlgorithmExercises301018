using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace RecursiveAlgorithmExercises301018
{
    class Program
    {
        static double count = 0;
        static void Main(string[] args)
        {
            //firstFiftyNaturalNumbersRecursive(1);
            //CheckPalindrome("8998", 0);
            //CountConsonant("ebbe", 0);
            //SumOfNumbersFrom1ToN(3, 1);
            //PrintFibonacciSeries(1, 0, 0);
            //CountTheDigitsOfAGivenNumberStringShit(12322);
            //CountTheDigitsOfAGivenNumber(12322);
            //SumOfDigitsOfANumber(621);
            //int[] array;
            //GetTheLargestElementOfAnIntegerArray(array = new int[] { 1, 6, 9, 11, 7, 13, 4 }, 0);
            //ReverseAString("racecar!", "", 0);
            //FindTheFactorialOfANumber(4, 1);
            //ConvertADecimalNumberToBinary(0,0); ?????
            //CheckANumberIsAPrimeNumberOrNot(7, 1, 100); ???
        }

        private static void firstFiftyNaturalNumbersRecursive(int i)
        {
            Console.WriteLine(i);
            if (i <= 50) firstFiftyNaturalNumbersRecursive(++i);
        }

        private static void CheckPalindrome(string input, int i)
        {
            if (i != input.Length)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    count++;
                }

                i++;
                CheckPalindrome(input, i);
            }
            else
            {
                if (count == input.Length)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }

                count = 0;
            }
            
        }

        private static void CountConsonant(string input, int i)
        {
            if (i != input.Length)
            {
                //if (input[i] != 'a' || input[i] != 'e' || input[i] != 'i' || input[i] != 'o' || input[i] != 'u' || input[i] != 'y' || input[i] != 'æ' || input[i] != 'ø' || input[i] != 'å')
                //{
                //    count++;
                //    Console.WriteLine("string: " + input[i] + "\ni: " + i + "\ncount: " + count);
                //}
                switch (input[i])
                {
                    case 'a':
                        break;
                    case 'e':
                        break;
                    case 'i':
                        break;
                    case 'o':
                        break;
                    case 'u':
                        break;
                    case 'y':
                        break;
                    case 'æ':
                        break;
                    case 'ø':
                        break;
                    case 'å':
                        break;
                    default:
                        count++;
                        Console.WriteLine("string: " + input[i] + "\ni: " + i + "\ncount: " + count);
                        break;
                }
                i++;
                CountConsonant(input, i);
            }
            else
            {
                Console.WriteLine(count);
                count = 0;
            }
        }

        private static void SumOfNumbersFrom1ToN(int input, int i)
        {
            if (i <= input)
            {
                count += i;
                i++;
                SumOfNumbersFrom1ToN(input, i);
            }
            else
            {
                Console.WriteLine(count);
                count = 0;
            }
        }

        private static void PrintFibonacciSeries(int lastNumber, int lastlastNumber, int i)
        {
            if (i <= 10)
            {
                int result = lastlastNumber + lastNumber;
                Console.WriteLine(lastlastNumber + "+" + lastNumber + "=" + result);

                lastlastNumber = lastNumber;
                lastNumber = result;
                
                i++;
                PrintFibonacciSeries(lastNumber, lastlastNumber, i);
            }
        }

        private static void CountTheDigitsOfAGivenNumberStringShit(int input)
        {
            string stringInput = input.ToString();
            Console.WriteLine(stringInput.Length);
        }
        private static void CountTheDigitsOfAGivenNumber(double input)
        {
            if (Math.Round(input) != 0)
            {   
                count++;
                input = input / 10;
                CountTheDigitsOfAGivenNumber(input);
            }
            else
            {
                Console.WriteLine(count);
            }
        }

        private static void SumOfDigitsOfANumber(double input)
        {
            if (input != 0)
            {
                var restVærdi = input / 10;
                var sidsteTal = input % 10;
                input = Math.Floor(restVærdi);
                count = count + sidsteTal;
                SumOfDigitsOfANumber(input);
            }
            else
            {
                Console.WriteLine(count);
            }
        }

        private static void GetTheLargestElementOfAnIntegerArray(int[] intArray, int i)
        {
            //Console.WriteLine(intArray.Max());
            if (i != intArray.Length)
            {
                if (count < intArray[i])
                {
                    count = intArray[i];
                }

                i++;
                GetTheLargestElementOfAnIntegerArray(intArray, i);
            }
            else
            {
                Console.WriteLine(count);
            }
        }

        private static void ReverseAString(string input, string output, int i)
        {
            if (input.Length != i)
            {
                output = output + "" + input[input.Length-1-i];
                i++;
                ReverseAString(input, output, i);
            }
            else
            {
                Console.WriteLine(output);
            }
        }

        private static void FindTheFactorialOfANumber(int input, int output)
        {
            if (input > 0)
            {
                output = output * input;
                input--;
                FindTheFactorialOfANumber(input, output);

            }
            else
            {
                Console.WriteLine(output);
            }
        }

        private static void ConvertADecimalNumberToBinary(int input, int output)
        {
            //??????????????????????????
            int value = 10;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
            //?????????????????????
        }

        private static void CheckANumberIsAPrimeNumberOrNot(int input, int i, int runs)
        {
            if (i != runs)
            {
                var some = (input / i);
                Console.WriteLine(some);
                if (some == 0)
                {
                    count++;
                    Console.WriteLine(i + "" + count);
                }
                i++;
                CheckANumberIsAPrimeNumberOrNot(input, i, runs);
            }
            else
            {
                Console.WriteLine(count);
                if (count == 1) Console.WriteLine(true);
                else Console.WriteLine(false);
            }
        }
    }
}
