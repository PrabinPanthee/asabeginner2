using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your FirstName");
        string FiratName = Console.ReadLine();
        Console.WriteLine("Enter your LastName");
        string LastName = Console.ReadLine();
        //Console.WriteLine("Hello  " +  UserName);
        Console.WriteLine("hello {0} {1}", FiratName , LastName);
    }
}