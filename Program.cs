using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            BTreeNode BST = BTreeNode.MakeDummyTree(10);

            bool isBST = BTreeNode.IsBST(BST, int.MinValue, int.MaxValue);

            if (isBST)
            {
                Console.WriteLine("This is a BST!");
            }
            else
            {
                Console.WriteLine("This is not a BST!");
            }

            BTreeNode.LeftFirstOrder(BST);
            Console.ReadKey();
        }
    }
}