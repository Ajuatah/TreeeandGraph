using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeeandGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///
            Tree BST = new Tree();
            Console.Write("Enter number of elements you want to have in the tree: ");
            int numberOfElementsInTree = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfElementsInTree; i++)
            {
                Console.Write($"Enter {i} node: ");
                int node = int.Parse(Console.ReadLine());
                BST.Insert(node);

            }

            Console.WriteLine("Inorder Traversal is : ");
            BST.InOrder(BST.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();

            Console.WriteLine("pre-order Traversal is : ");
            BST.Pre_order(BST.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();

            Console.WriteLine("post-order Traversal is : ");
            BST.PostOrder(BST.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();

            Console.ReadLine();


        }
    }

    class Node1
    {
        public int value;
        public Node1 left;
        public Node1 right;

        public void Show()
        {
            Console.Write("[");
            Console.Write(value);
            Console.Write("]");
        }
    }

    class Tree
    {
        public Node1 root;
        public Tree()
        {
            root = null;
        }

        public Node1 ReturnRoot()
        {
            return root;
        }

        public void Insert(int x)
        {
            Node1 newNode = new Node1();
            newNode.value = x;

            if(root == null)root = newNode;
            else
            {
                Node1 current = root;
                Node1 parent;

                while (true)
                {
                   parent = current;
                    if (x < current.value)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Pre_order(Node1 Root)
        {
            if(Root != null)
            {
                Console.Write(Root.value+" ");
                Pre_order(Root.left);
                Pre_order(Root.right);
            }
        }

        public void InOrder(Node1 Root)
        {
            if(Root != null)
            {
                InOrder(Root.left);
                Console.Write(Root.value + " ");
                InOrder(Root.right);
            }
        }

        public void PostOrder(Node1 Root)
        {
            if(Root != null)
            {
                PostOrder(Root.left);
                PostOrder(Root.right);
                Console.Write(Root.value + " ");
            }
        }
    }
        

}
