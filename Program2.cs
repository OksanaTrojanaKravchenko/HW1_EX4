using System;

namespace EX4
{
    class Program2
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Contains("number"))
                {
                    char[] charsToTrimNumber = { '-', 'n', 'u', 'm', 'b', 'e', 'r', '=', ' ' };
                    int trimmedNumber;
                    if (int.TryParse(args[i].Trim(charsToTrimNumber), out trimmedNumber))
                    {
                        Console.WriteLine($"number: { trimmedNumber}");
                    }
                    else
                    {
                        Console.WriteLine("number is a mandatory parameter");
                    }
                }
                if (args[i].Contains("string"))
                {
                    string[] newSplitedString = args[i].Split('=');
                    char[] charsToTrimString = { '"', ' ' };
                    if (newSplitedString.Length > 0)
                    {
                        string trimmedString = newSplitedString[1].Trim(charsToTrimString);
                        Console.WriteLine($"string: { trimmedString}");
                    }
                    else
                    {
                        Console.WriteLine("string: was skipped");
                    }
                }
                if (args[i].Contains("flag"))
                {
                    bool flag = true;
                    if (args[i].Contains("false"))
                    {
                        flag = false;
                    }
                    Console.WriteLine($"flag: {flag}");
                }
            }
            Console.ReadLine();
        }
    }
}
