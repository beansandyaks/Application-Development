using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsoleAppYear3.Basics
{
    public class Interpolation
    {
        public static void StringInterpolation()
        {
            Console.WriteLine("Insert group name: ");
            string? groupName = Console.ReadLine();

            Console.WriteLine("First Name: ");
            string? firstName = Console.ReadLine();
            
            Console.WriteLine("Last Name: ");
            string? lastName = Console.ReadLine();

            Console.WriteLine($"Hello {groupName}, My name is {firstName} {lastName}.");
        }
    }
}
