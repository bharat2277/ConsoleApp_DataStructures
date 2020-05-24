using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static ConsoleApp1.LinkedList;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] nums = { -10, -7, -3, -2, -1, 4, 5, 6 };
			/* Start with the empty list. */
			LinkedList llist = new LinkedList();

			llist.head = new Node(1);
			Node second = new Node(2);
			Node third = new Node(3);

			/* Three nodes have been allocated dynamically. 
			We have references to these three blocks as head, 
			second and third 

			llist.head	 second			 third 
				|			 |				 | 
				|			 |				 | 
			+----+------+	 +----+------+	 +----+------+ 
			| 1 | null |	 | 2 | null |	 | 3 | null | 
			+----+------+	 +----+------+	 +----+------+ */

			llist.head.next = second; // Link first node with the second node 

			/* Now next of first Node refers to second. So they 
				both are linked. 

			llist.head	 second			 third 
				|			 |				 | 
				|			 |				 | 
			+----+------+	 +----+------+	 +----+------+ 
			| 1 | o-------->| 2 | null |	 | 3 | null | 
			+----+------+	 +----+------+	 +----+------+ */

			second.next = third; // Link second node with the third node 

			/* Now next of the second Node refers to third. So all three 
				nodes are linked. 

			llist.head	 second			 third 
				|			 |				 | 
				|			 |				 | 
			+----+------+	 +----+------+	 +----+------+ 
			| 1 | o-------->| 2 | o-------->| 3 | null | 
			+----+------+	 +----+------+	 +----+------+ */


		}
	}

// A simple C# program to introduce a linked list 


	// This code has been contributed by 29AjayKumar 






}

