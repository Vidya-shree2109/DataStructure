using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedListOperation
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into Linked List !", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Is Empty !");
                return;
            }
            Console.Write("\nList -> ");
            while (temp != null)
            {
                Console.Write(temp.data + "  ");
                temp = temp.next;
            }
            Console.Write("\n");
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
            }
            Display();
        }
    }
}
