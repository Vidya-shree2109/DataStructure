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
            Console.WriteLine("1.Simple Linked List\n2.Add in reverse order\n3.Append Data\n4.Insert Data\n5.Delete Data\n6.Delete Last Element\n7.Searching An Element\n8.Inserting New Element In The List\n9.Delete The Recently Added Element\n10.Exit");
            while (check)
            {
                Console.Write("\nEnter an option to execute : ");
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
                        list.Add(56);
                        list.Append(30);
                        list.Append(70);
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(70);
                        int a = list.Search(56);
                        list.InsertAtParticularPosition(a + 1, 30);
                        list.Display();
                        break;
                    case 5:
                        Console.WriteLine("\nEnter the position of the element : ");
                        int position = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNodeAtParticularPosition(position);
                        list.Display();
                        break;
                    case 6:
                        list.RemoveLastNode();
                        list.Display();
                        break;
                    case 7:
                        list.Add(30);
                        list.Add(56);
                        list.Add(70);
                        int value = list.Search(30);
                        list.Display();
                        Console.WriteLine("Element is in " + value + " position");
                        break;
                    case 8:
                        list.Add(56);
                        list.Add(30);
                        list.Add(40);
                        list.Add(70);
                        list.Display();
                        break;
                    case 9:
                        list.Add(56);
                        list.Add(30);
                        list.Add(40);
                        list.Add(70);
                        list.DeleteNodeAtParticularPosition(2);
                        list.Display();
                        break;
                    case 10:
                        check = false;
                        break;
                }
            }
        }
    }
}