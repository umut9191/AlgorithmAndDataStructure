using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructure
{
    public class LinkedListClass
    {
       public Node? head;
        public LinkedListClass()
        {
            head = null;
        }

        public void AddToLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("node added to head");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("node added to last");
            }
        }
        public void AddToFront(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("node added to head");
            }
            else
            {
                node.next = head;// previous head added to node's next node
                head = node;// node added to front
                Console.WriteLine("node added to last");

            }

        }

        public void PrintListMembers()
        {
            Node temp = head;
            if (head ==null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("head -> ");
                while (temp.next!=null)
                {
                    Console.WriteLine(temp.data + " -> ");
                    temp =temp.next;
                }
                Console.WriteLine(temp.data+" Last.");

            }
        }

    }
}
