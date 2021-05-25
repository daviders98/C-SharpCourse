using System;

class Program
{
    static void Main()
    {
        string exeFile = "Word.exe\"";
        //because the inverse slash is a reserved character, you must escape it with another one, so that it counts
        //just as one
        //whatever reserved character u want, u need to use the backslash first.
        string pathToExe = "\"c:\\Program files\\Microsoft Word\\";
        Console.WriteLine(pathToExe + exeFile);

        //There's another way to doit, u can use an @ after the equal sign. but with double quotation mark u must escape it
        string exeFile2 = @"Word.exe""";
        string pathToExe2 = @"""C:\Program files\Microsoft Word\";
        Console.WriteLine(pathToExe2 + exeFile2);
        Console.WriteLine(@"C:\Program Files\""Microsoft Programs""\'Visual Studio'");
        Console.WriteLine("C:\\Program Files\\\"Microsoft Programs\"\\'Visual Studio'");

        //With interpolation:
        Console.WriteLine($"{{{ pathToExe}{exeFile}}}");
    }
}