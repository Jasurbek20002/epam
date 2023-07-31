using System;


class Program
{
    static string ConvertToBase(int number, int newBase)
    {
        if (newBase < 2 || newBase > 20)
            throw new ArgumentException("New base should be between 2 and 20.");

        string result = "";

        while (number > 0)
        {
            int remainder = number % newBase;
            char digit = (char)(remainder < 10 ? remainder + '0' : remainder - 10 + 'A');
            result = digit + result;
            number /= newBase;
        }

        return result;
    }

    static void Main(string[] args)
    {

        Console.Write("Enter the number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.Write("Enter the new base (2 to 20): ");
            if (int.TryParse(Console.ReadLine(), out int newBase))
            {
                try
                {
                    string convertedNumber = ConvertToBase(number, newBase);
                    Console.WriteLine($"Converted number: {convertedNumber}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input for new base. Please enter a valid integer between 2 and 20.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for number. Please enter a valid integer.");
        }

    }
}

