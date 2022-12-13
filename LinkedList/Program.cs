using LinkedList;
using System;
namespace LinkedListStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedList = new LinkedLists();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("***Linked List Problem ***");

                Console.WriteLine(" Select the option ");

                Console.WriteLine("1.CreateLinkedList\n" +
                                  "2.Display" + "\n" +
                                  "3.Exit" + "\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Display();
                        break;
                    case 2:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 3:
                        flag = false;
                        break;
                }

            }
        }
    }
}