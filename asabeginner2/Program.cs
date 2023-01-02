using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your FirstName");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Enter your LastName");
        string LastName = Console.ReadLine();
        //Console.WriteLine("Hello  " +  UserName);
        Console.WriteLine("hello {0} {1}", FirstName , LastName);
    }
}
