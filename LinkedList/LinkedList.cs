using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedLists
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
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }
        public void LinkedListReverseOrder(int data)
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
                head.next = temp;
            }
        }
        public Node InsertAtParticuarPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            Console.WriteLine("\nValue is Successfully Inserted in LinkedList\nAfter updation....");
            return this.head;
        }
        public void RemoveFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            this.head = head.next;
            Console.WriteLine("First element is deleted successfully");
        }
        public void RemoveLastNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            Node lastNode = this.head;
            while (lastNode.next.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = null;
            Console.WriteLine("Last element is deleted successfully");
        }
        //Searching the particular element in linked list
        public Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Element found.. " + value);
                    return temp;
                }
                temp = temp.next;

            }
            Console.WriteLine("Element not found!!!!!!!!");
            return default;
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            Console.Write("LinkedList is as : ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
    }
}