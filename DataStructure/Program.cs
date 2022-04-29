using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                 WELCOME TO DATA STRUCTURE PROGRAMS                                 \n");
            Console.WriteLine("LINKED LIST -->\n");
            LinkedListOperation list = new LinkedListOperation();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}