using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanAssitance
{
    internal class BSTClass
    {
        public class Node
        {
            public int Digit;
            public Node Left, Right;

            public Node(int data)
            {
                Digit = data;
                Left = Right = null;
            }
        }

        public Node root;

        public BSTClass() 
        { 
            root = null; 
        }

        public BSTClass(int data)
        {
            root = new Node(data);
        }


        public void Place(int data)
        {
            root=Fit(root,data);
        }

        public Node Fit(Node current,int data)
        {
            if(current == null)
            {
                current = new Node(data);
                return current;
            }
            if (data<current.Digit)
            {
                current.Left = Fit(current.Left,data);
            }
            else if(data>current.Digit)
            {
                current.Right=Fit(current.Right,data);
            }
            return current;
        }

        public void InOrder()
        {
            OrderIn(root);
            Console.WriteLine();
        }

        void OrderIn(Node current)
        {
            if (current != null)
            {
                OrderIn(current.Left);
                Console.Write(current.Digit+" - ");
                OrderIn(current.Right);
            }
        }

        public void Search(int data)
        {
            Node found = linear(data, root);
            if(found != null)
            {
                Console.Write(found.Digit+" found with ");
                if(found.Left != null)
                    Console.Write(found.Left.Digit+" left side and ");
                if(found.Right!=null)
                    Console.Write(found.Right.Digit + " right side");

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(data + " not found");
            }
        }

        Node linear(int data, Node current)
        {
            if (current == null || current.Digit==data)
                return current;
            if(current.Digit>data)
                return linear(data, current.Left);
            return linear(data, current.Right);
        }

        public void Delete(int data)
        {
            root = perDelete(root, data);
        }

        Node perDelete(Node current,int data)
        {
            if (current == null)
                return current;

            if (current.Digit > data)
                current.Left = perDelete(current.Left, data);
            else if(current.Digit<data)
                current.Right = perDelete(current.Right, data);

            else
            {
                if (current.Left == null)
                    return current.Right;
                else if (current.Right == null)
                    return current.Left;

                current.Digit = findMin(current.Right);

                current.Right=perDelete(current.Right, current.Digit);
            }
            return current;
        }

        int findMin(Node current)
        {
            int min = current.Digit;
            while (current.Left!=null)
            {
                min=current.Left.Digit;
                current=current.Left;
            }
            return min;
        }

        List<Int32> tmp = new List<Int32>();

        public void Update(int oldOne,int newOne)
        {
            up(root,oldOne,newOne);
            //root=ups(root, oldOne, newOne);
            gather(root);
            //tmp.ForEach(e => Console.WriteLine(e));
            root = null;
            tmp.ForEach(e => { Place(e); });
        }

        void gather(Node current)
        {
            if(current != null)
            {
                gather(current.Left);
                tmp.Add(current.Digit);
                gather(current.Right);
            }

            //root = null;
            //tmp.ForEach(e => Place(e));
        }

        /*
        Node ups(Node current,int oldData,int newData)
        {
            if (current == null)
                return current;
            if (current.Digit > oldData)
                current.Left = ups(current.Left, oldData,newData);
            else if (current.Digit < oldData)
                current.Right = ups(current.Right, oldData,newData);
            else
            {
                current.Digit = newData;

                current.Digit = findMin(current.Right);

                current.Right=ups(current.Right, oldData,newData);
            }
            return current;
        }
        */
        void up(Node current,int oldOne,int newOne)
        {
            if (current != null)
            {
                up(current.Left,oldOne,newOne);
                if (current.Digit == oldOne)
                {
                    current.Digit = newOne;
                }
                up(current.Right,oldOne,newOne);
            }
        }
    }
}
