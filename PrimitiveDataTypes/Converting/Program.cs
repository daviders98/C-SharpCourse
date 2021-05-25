using System;

class Program
{
    static void Main()
    {
        int number = 5;
        string word = "number";
        //single quotation marks for characters
        char x = 'x';
        float pi = 3.14f;

        float integer = number;
        //TYPE CASTING A FLOAT AS AN INT
        int floating = (int)pi;
        // truncates
        Console.WriteLine(integer);
        Console.WriteLine(floating);

        string wordNumber = "5";
        //CONVERTING A STRING WITH A NUMBER TO AN INT
        int ConvertedString = Convert.ToInt32(wordNumber);
        //now stringedInteger is treated as an int, you can add, do operations, etc.
        Console.WriteLine(ConvertedString);


        int parsedString = int.Parse(wordNumber);
        Console.WriteLine(parsedString);

        //WHEN THE VALUE IS NULL, THE CONVERSION GIVES A 0 AND THE PARSE METHOD GIVES AN ERROR
    }
}
