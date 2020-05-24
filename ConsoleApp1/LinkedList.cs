using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class LinkedList
	{
		public Node head; // head of list 

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

	}
}
