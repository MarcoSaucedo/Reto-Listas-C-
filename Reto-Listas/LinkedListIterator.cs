using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.LinkedList
{
    internal class LinkedListIterator
    {
        public Node currentNode;

        public LinkedListIterator(Node startNode)
        {
            currentNode = startNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public string Next()
        {
            string data = currentNode.data;

            currentNode = currentNode.next;

            return data;
        }
    }
}
