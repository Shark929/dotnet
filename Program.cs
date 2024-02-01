using System;

namespace Dotnet{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}