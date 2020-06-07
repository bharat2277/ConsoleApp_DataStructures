using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //output should be gooog for "abcagooogtech"
            string output = Palindrome.GetLongestPalindrome("abcagooogtech");

            //Arrays.printUniquePairsUsingHashtable(new int[] { 2, 4, 7, 5, 9, 10, -1 }, 9); 

            //1 1 2 3 5 8 13 21 34 55 
            FibonacciSequence.Execute();

            ///Add Two Numbers using LinkedList 
            /// Input:
            //First List: 5->6->3  // represents number 563
            //Second List: 8->4->2 //  represents number 842
            //Output
            //Resultant list: 1->4->0->5  // represents number 1405
            /// </summary> 
            Add_Two_Numbers_Represented_By_Linked_Lists.Execute();


            LinkedList list = new LinkedList();
            list.AddNode(new LinkedList.Node(85));
            list.AddNode(new LinkedList.Node(15));
            list.AddNode(new LinkedList.Node(4));
            list.AddNode(new LinkedList.Node(20));

            // List before reversal 
            Console.WriteLine("===============================");
            Console.WriteLine("Given linked list:");
            list.PrintList();

            // Reverse the list 
            list.ReverseList();

            // List after reversal 
            Console.WriteLine("Reversed linked list:");
            list.PrintList();
            Console.WriteLine("===============================");

            Console.ReadKey();
        }
    }

    // A simple C# program to introduce a linked list   
    // This code has been contributed by 29AjayKumar  
}

