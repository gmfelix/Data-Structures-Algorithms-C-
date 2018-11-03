using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class BTreeNode
    {
        protected internal BTreeNode LeftChild { get; set; }
        protected internal BTreeNode RightChild { get; set; }
        protected internal int Payload { get; set; }

        BTreeNode()
        {
            LeftChild = null;
            RightChild = null;
            Payload = 0;
        }
        BTreeNode(int Payload)
        {
            LeftChild = null;
            RightChild = null;
            this.Payload = Payload;
        }

        protected internal static BTreeNode MakeDummyTree(int NumberOfElements)
        {
            Random RandomGen = new Random();
            BTreeNode Head = null;
            for(int i = 0; i < NumberOfElements; i++)
            {
                Head = BogusInsert(Head, RandomGen.Next(0, 100));
            }
            return Head;
        }

        protected internal static BTreeNode InsertNode(BTreeNode Head, int Element)
        {
            if(Head == null)
            {
                Head = new BTreeNode(Element);
                return Head;
            }
            if(Head.Payload < Element)
            {
                Head.RightChild = InsertNode(Head.RightChild, Element);
            }
            else
            {
                Head.LeftChild =InsertNode(Head.LeftChild, Element);
            }
            return Head;
        }


        protected internal static BTreeNode BogusInsert(BTreeNode Head, int Element)
        {
            if(Head == null)
            {
                Head = new BTreeNode(Element);
                return Head;
            }
            Random RandomGen = new Random();
            int random = RandomGen.Next(2);

            if(random == 1)
            {
                Head.LeftChild = BogusInsert(Head.LeftChild, Element);
            }
            else
            {
                Head.RightChild = BogusInsert(Head.RightChild, Element);
            }
            return Head;

        }
        protected internal static void LeftFirstOrder(BTreeNode Head)
        {
            if(Head == null)
            {
                return;
            }
            LeftFirstOrder(Head.LeftChild);
            Console.WriteLine(Head.Payload);
            LeftFirstOrder(Head.RightChild);
        }

        protected internal static bool IsBST(BTreeNode Head, int min, int max)
        {
            if(Head == null)
            {
                return true;
            }
            bool IsBSTLeft = IsBST(Head.LeftChild, min, Head.Payload);
            bool IsBSTRight = IsBST(Head.RightChild, Head.Payload, max);

            if(!(IsBSTLeft) || !(IsBSTRight))
            {
                return false;
            }
            if (min < Head.Payload && Head.Payload < max)
            {
                return true;
            }
            return false;
        }
    }
}
