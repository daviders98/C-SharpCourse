using System;

class EntryPoint
{
    static void Main()
    {
        int someInt = 15;
        //int -> 2^32
        int intMax = int.MaxValue;
        int intMin = int.MinValue;
        Console.WriteLine(intMax + " " + intMin);

        uint someUint = 2;
        //unsigned integer, positive integers only;
        uint minUint = uint.MinValue;
        uint maxUint = uint.MaxValue;
        Console.WriteLine(minUint+" "+maxUint);
        Console.WriteLine(Math.Pow(2, 32));

        //1 byte is 8 bits
        //2^8 = 256 values, from 0 to 255
        byte someByte = 255;
        byte minByte = byte.MinValue;
        byte maxByte = byte.MaxValue;
        Console.WriteLine(minByte+" "+maxByte);

        //short byte, it has same values but from -128 to 127
        sbyte minSByte = sbyte.MinValue;
        sbyte maxSByte = sbyte.MaxValue;
        Console.WriteLine(minSByte + " " + maxSByte);

        //really big numbers 2^64
        long minLong = long.MinValue;
        long maxLong = long.MaxValue;
        Console.WriteLine(minLong);
        Console.WriteLine(maxLong);

        ulong minuLong = ulong.MinValue;
        ulong maxuLong = ulong.MaxValue;
        Console.WriteLine(minuLong);
        Console.WriteLine(maxuLong);



    }
}