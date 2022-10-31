using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// Node Class
    /// </summary>
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor with Data
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            this.Data = data;
        }

        /// <summary>
        /// All parameter Constructor
        /// </summary>
        /// <param name="data">node data</param>
        /// <param name="next">reference to the next node in the list</param>
        public Node(int data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
