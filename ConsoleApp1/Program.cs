using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*public static void Main(string[] args)
        {
            //SpiralPrint spiralPrint = new SpiralPrint();
            //ReverseNumber reverseNumber = new ReverseNumber();
            //programmingknow1 programmingknow1 = new programmingknow1();
            // programmingknow1.fishorcrab();
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
            /*int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus.pM(arr);



        }*/
        public static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] inputs = { "S;M;plasticCup()", "C;V;mobile phone" };
            string result = string.Empty;
            foreach (var input in inputs)
            {
                string newInput = input.Replace("()", string.Empty);
                string[] splitInput = newInput.Split(';');
                char condition = char.Parse(splitInput[0]);
                char type = char.Parse(splitInput[1]);
                string name = splitInput[2];
                if (condition.Equals('S'))
                {
                    Regex r = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z])|(?<=[A-Za-z])(?=[^A-Za-z])");
                    result = r.Replace(name, " ").ToLower();
                }
                else if (condition.Equals('C'))
                {
                    string[] nameSets = name.Split(' ');
                    List<string> newNameSets = new List<string>();
                    foreach (var nameSet in nameSets)
                    {
                        string newNameSet = char.ToUpper(nameSet[0]) + nameSet.Substring(1);
                        newNameSets.Add(newNameSet);
                    }
                    result = String.Join("", newNameSets);
                    if (type.Equals('V'))
                    {
                        result = char.ToLowerInvariant(result[0]) + result.Substring(1);
                    }
                    else if (type.Equals('M'))
                    {
                        result = char.ToLowerInvariant(result[0]) + result.Substring(1) + "()";
                    }
                }
                Console.WriteLine(result);
            }
        }



    }

}
