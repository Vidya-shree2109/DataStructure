using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("                                 WELCOME TO DATA STRUCTURE PROGRAMS                                 \n");
            Console.WriteLine("LINKED LIST -->\n");
            LinkedListOperation list = new LinkedListOperation();
            bool check = true;
            Console.WriteLine("1.Simple Linked List\n2.Add in reverse order\n3.Exit");
            while (check)
            {
                Console.Write("\nEnter an option to execute : \n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(30);
                        list.Add(56);
                        list.Add(70);
                        list.Display();
                        break;
                    case 2:
                        list.AddInReverseOrder(56);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(70);
                        break;
                    case 3:
                        check = false;
                        break;
                }
            }
        }
    }
}