using System;
using System.Linq;


namespace programmsrepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scream("hi i'm from kyrgyzstan"));

        }
        static string Scream(string input)
        {
            var result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += char.ToUpper(input[i]);
            }
            return result;
        }
    }
}

/*            Console.WriteLine("Enter number: ");
            double numbers = double.Parse(Console.ReadLine());

            int integer = Convert.ToInt32(numbers);
            decimal @decimal = Math.Abs(Convert.ToDecimal(numbers - integer) * 100);

            string result = ($"Integer: {integer}, Decimal: {Math.Abs(@decimal)}");
            Console.WriteLine(result);

            Console.ReadKey();*/

/*Console.WriteLine("Enter sentence: ");
            string line = Console.ReadLine();

string temp = "";
            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    temp += char.ToLower(c);
                }
            }
            string yes = IsPalindrome(temp) ? "" : "not";
Console.WriteLine($"Sentense '{line}' is {yes} a palindrome");
        }

        private static bool IsPalindrome(string temp)
{
    int i = 0;
    int j = temp.Length - 1;
    while (i < j)
    {
        if (temp[i] != temp[j])
        {
            return false;
        }
        ++i;
        --j;
    }
    return true;
}*/

/*  Console.WriteLine("Enter sentence: ");
        string sentence = Console.ReadLine();

        var result = "";

        foreach (var letter in sentence)
        {
            result = letter + result;
        }
        Console.WriteLine(result);*/
