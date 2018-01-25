using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlinkoAsBinaryTree
{

    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }// class Node

    class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }

        public void Add(int value)
        {
            // add non recursive
        }

        public void AddRc(int value)
        {
            // add recursive
        }

        private void AddR(ref Node N, int value)
        {
            // private recursive search for where to add the new node
        }

        public void Print(ref string newstring)
        {
            // write out tree in sorted order to the string newstring
            // implement using recursion
        }

    }// class Tree

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
