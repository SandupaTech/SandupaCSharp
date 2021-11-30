using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandupaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("How old are you? ");
            string age = Console.ReadLine();
            Console.WriteLine("Hey! " + name + ", Whats up?");
            Console.WriteLine("You are " + age + "!");
            Console.ReadLine();
        }
    }
}
