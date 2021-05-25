using System;
using System.Text;

class EntryPoint
{

    static void Main()
    {
        //using the ASCII table, we can take the hex value and assign it to a char type of variable
        //we need to use SINGLE QUOTATION MARKS AND ADD A 'u' and 4 zeros, the hex code must be within the 4 zeros
        //you should delete the hex code digits from right to left and then put the hx code.
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        //using the unicode table you can output a lot more things.
        char plusSign = '\u00f6';
        Console.WriteLine(plusSign);
    }
}
