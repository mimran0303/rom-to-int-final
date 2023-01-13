using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
// using System.Collections.Specialized;


namespace romanto_int
{
    public class _numeral
    {
        static int Number(string numeral)
        {
            int integer = 0;

            Dictionary<string, int> Numerals = new Dictionary<string, int>();
            Numerals.Add("I", 1);
            Numerals.Add("V", 5);
            Numerals.Add("X", 10);
            Numerals.Add("L", 50);
            Numerals.Add("C", 100);
            Numerals.Add("D", 500);
            Numerals.Add("M", 1000);

            Dictionary<string, int> Special_Cases = new Dictionary<string, int>();
            Special_Cases.Add("IV", 4);
            Special_Cases.Add("IX", 9);
            Special_Cases.Add("XL", 40);
            Special_Cases.Add("XC", 90);
            Special_Cases.Add("CD", 400);
            Special_Cases.Add("CM", 900);

            Console.WriteLine($"Initial: SubNumeral={numeral}");

            for (int i = 0; i < numeral.Length; i++) // for checking each character at position in numeral
            {
                string subNumeral;
                subNumeral = numeral.Substring(i, numeral.Length - i);

                foreach (var entry in Special_Cases)
                {
                    //Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
                    if (subNumeral.StartsWith(entry.Key))
                    {
                        integer += entry.Value;
                        i++;
                        i++;
                        subNumeral = numeral.Substring(i, numeral.Length - i);
                    }
                }
                Console.WriteLine($"Special Cases: i={i}, SubNumeral={subNumeral}:  {integer}");
                foreach (var entry in Numerals)
                {
                    if (subNumeral.StartsWith(entry.Key))
                    {
                        integer += entry.Value;
                    }
                }
                Console.WriteLine($"Easy Cases: i={i}, SubNumeral={subNumeral}:  {integer}");
                Console.WriteLine("");
            }
            return integer;
        }

        public static void Main(String[] args)
        {
            string[] Numerals = new string[] { "II", "IX", "IVII", "VI", "MCM", "CDIVX", "VII" };

            foreach (string r in Numerals)
            {
                int result = Number(r);
                Console.WriteLine(result);
            }

            string test = "IIIV";
            int result1 = Number(test);
            Console.WriteLine("numeral to integer: " + result1);
        }
    }
}

