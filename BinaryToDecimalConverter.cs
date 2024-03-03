using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main()
    {
        string binaryInput = GetBinaryInput();
        Console.WriteLine("Entered binary number: " + binaryInput);
        Console.ReadLine();

        int binaryOutput = BinaryToDecimal(binaryInput);
        Console.WriteLine($"The number in decimal is equal to {binaryOutput}");


    }

    // Metoda do pobierania poprawnego wejścia binarnego
    static string GetBinaryInput()
    {
        string userInput;
        bool isValid;

        do
        {
            Console.WriteLine("Enter a binary number (0s and 1s only):");
            userInput = Console.ReadLine();

            isValid = IsBinary(userInput);

            if(!isValid || userInput.Length > 8)
            {
                Console.Write("Invalid INPUT \n");
            }

        } while (!isValid || userInput.Length > 8);

        return userInput;

    }

    // Metoda sprawdzająca, czy ciąg zawiera tylko 0 i 1
    static bool IsBinary(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1')
            {
                return false;
            } 
        }
        return true;
    }


    static int BinaryToDecimal(string binaryNumber)
    {
        int power = 0;
        int decimalNumber = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--) 
        {
            if (binaryNumber[i] == '1') 
            {
                decimalNumber += (int)Math.Pow(2, power);
            }
            power++;
        }

        return decimalNumber;
    }

}
