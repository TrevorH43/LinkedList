using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class LinkedList
    {
        Node start;
        Node head;

        /// <summary>
        /// Linked List Constructor
        /// </summary>
        public LinkedList()
        {
            start = null;
        }
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        /// <summary>
        /// Clear the List by removing all nodes
        /// </summary>
        public void Clear()
        {
            // Iterate over the list and delete each node in the list using the Delete method
            this.Clear();
        }

        /// <summary>
        /// Returns the count of elements in the list
        /// </summary>
        /// <returns>The Count on Nodes in the Linked List</returns>
        public int Count()
        {
            // Iterate over the list and return the count of nodes in the list
            int count = 0;
            for (LinkedList n = head; n != null; n = n.next)
            {
                count++;
            }
            return count;
        }

        /// <summary>
        /// Removes the node containing the designated value
        /// </summary>
        /// <param name="value">Designated value</param>
        public void Delete(int value)
        {
            // Need to locate the value in the list.  
            // Node needs to be removed and then the before and after nodes need to be
            // rewired (not necessarily in that order of operation)

        }


        /// <summary>
        /// Searches the Linked List for the designated value
        /// </summary>
        /// <param name="value">designated search value</param>
        /// <returns>boolean indicating whether the value exists in the linked list</returns>
        public bool Find(int value)
        {
            // Iterate over the list until there are no more nodes in the list or the
            // node containing the value is found.
            // Return whether the node was found.
            var node = list.Find(5);
            while (node != null)
            {
                yield return node;
                node = node.Next;

            }
        }

        /// <summary>
        /// Inserts a node in the list based in the value.  The list will be maintained in
        /// ascending order.
        /// </summary>
        /// <param name="x">Value to insert in the list</param>
        public void Insert(int x)
        {
            // Need to locate where in the list the item belongs.
            // The ascending order of the list must be maintained when the item is added.
            // Create the new node and rewire applicable nodes to integrate the new node.
        }
        // function to insert a new_node in a list. //
        void sortedInsert(Node new_node)
        {
            Node current;

            // Special case for head node //
            if (head == null || head.data >= new_node.data)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {

                // Locate the node before point of insertion //

                current = head;

                while (current.next != null && current.next.data < new_node.data)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
        }

        /// <summary>
        /// Print out the contents of the Linked List
        /// </summary>
        public void Print()
        {
            // Iterate over the List and dump the nodes
            for (Node p = start; p != null; p = p.Next)
                Console.Write(p.Data + " ");

            Console.WriteLine("");
        }
    }
}
