using System;


class Program
{
    static void Main()
    {
        string tempUsername = Console.ReadLine();
        string tempPassword = Console.ReadLine();

        string username = string.Empty;
        string password = "";

        if (tempUsername.Length >= 6)
        {
            username = tempUsername;
        }
        else
        {
            username = "default_username";
        }
        if(tempPassword.Length >= 8)
        {
            password = tempPassword;
        }
        else
        {
            password = "12345678";
        }
        Console.WriteLine(tempUsername);
        Console.WriteLine(tempPassword);
        Console.WriteLine(username);
        Console.WriteLine(password);

    }
}

