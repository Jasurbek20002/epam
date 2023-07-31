using System;

class Program
{
    static int MaxNonuniqueSequenceNumber(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        int max = 0;
        if (s[0] != s[1]) max++;
        if (s[s.Length-1] != s[s.Length - 2]) max++;
        for (int i = 1; i < s.Length-1; i++)
        {
            if (s[i] != s[i + 1] && s[i] != s[i - 1])
            {
                max++;
            }
        }

        return max;
    }

    static void Main(string[] args)
    {
            string inputString = Console.ReadLine();  
            int result = MaxNonuniqueSequenceNumber(inputString);
            Console.WriteLine("Maximum number of non-unique sequence: " + result);
    }
}
