using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class LinkedList
    {
        public Node root; // head of list 

        /* Linked list Node. This inner class is made static so that 
		main() can access it */
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            } // Constructor 
        }

        /* method to create a simple linked list with 3 nodes*/
        // function to add a new node at 
        // the end of the list 
        public void AddNode(Node node)
        {
            if (root == null)
                root = node;
            else
            {
                Node temp = root;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }


        // function to reverse the list 
        public void ReverseList()
        {
            Node p = root;  
            Node n = null;

            while (p != null)
            {
                Node tmp = p.next;

                p.next = n;
                n = p;
                p = tmp;  
            }
            root = n;
        }

        // function to print the list data 
        public void PrintList()
        {
            Node current = root;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    public class Add_Two_Numbers_Represented_By_Linked_Lists
    {
        /// <summary>
        /// Input:
        //First List: 5->6->3  // represents number 563
        //Second List: 8->4->2 //  represents number 842
        //Output
        //Resultant list: 1->4->0->5  // represents number 1405
        /// </summary>

        public static void Execute()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Add_Two_Numbers_Represented_By_Linked_Lists:75946+84=?");
            LinkedList<int> ll1 = new LinkedList<int>();
            ll1.AddLast(7);
            ll1.AddLast(5);
            ll1.AddLast(9);
            ll1.AddLast(4);
            ll1.AddLast(6);

            LinkedList<int> ll2 = new LinkedList<int>();
            ll2.AddLast(8);
            ll2.AddLast(4);
            LinkedList<int> ll3 = new LinkedList<int>();

            int maxCount = ll1.Count > ll2.Count ? ll1.Count : ll2.Count;

            if (ll1.Count != ll2.Count)
            {
                //for reversing linked list
                //https://stackoverflow.com/questions/8686168/reversing-single-linked-list-in-c-sharp
                var head = ll1.First;
                while (head.Next != null)
                {
                    var next = head.Next;
                    ll1.Remove(next);
                    ll1.AddFirst(next.Value);
                }

                var head2 = ll2.First;
                while (head2.Next != null)
                {
                    var next = head2.Next;
                    ll2.Remove(next);
                    ll2.AddFirst(next.Value);
                }
            }

            //logic starts here
            int carry = 0, temp = 0;
            for (int i = 0; i < maxCount; ++i)
            {
                temp = ll1.ElementAtOrDefault(i) + ll2.ElementAtOrDefault(i);
                ll3.AddFirst((temp + carry) % 10);
                carry = (temp + carry) / 10;
            }

            foreach (int item in ll3)
            {
                Console.Write(item);
            }

            Console.WriteLine("===============================");
        }
    }
}
