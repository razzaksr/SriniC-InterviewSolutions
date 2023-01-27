using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanAssitance
{
    internal class ListClass
    {
        public Node head;
        public class Node
        {
            public String FullName;
            public Node Prev;
            public Node Next;
            public Node(String fullName)
            {
                FullName = fullName;
            }
        }

        public void InsAtStart(String fullName)
        {
            Node mine = new Node(fullName);

            mine.Next=head;
            mine.Prev = null;

            if(head!=null)
                head.Prev=mine;

            head = mine;
            Console.WriteLine(fullName + " has added before all ");
        }
        public void InsAtLast(String fullName)
        {
            Node mine=new Node(fullName);
            mine.Next = null;

            if (head==null)
            {
                mine.Prev = null;
                mine = head;
                return;
            }

            Node trav = head;

            while (trav.Next!=null)
            {
                trav = trav.Next;
            }

            trav.Next = mine;
            mine.Prev=trav;

            Console.WriteLine(fullName + " has added at the end");
        }
        public void InsAtSpecific(Node users,String fullName)
        {
            if (users == null)
            {
                Console.WriteLine("Invalid Node in the list");
                return;
            }

            Node mine = new Node(fullName);

            mine.Next = users.Next;
            users.Next = mine;

            mine.Prev = users;

            if (mine.Next != null)
            {
                mine.Next.Prev=mine;
            }

            Console.WriteLine(fullName+" has added after "+users.FullName);
        }


        public void ViewByForward(Node who)
        {
            Node final = null;

            while (who != null)
            {
                Console.WriteLine(who.FullName);
                final = who;
                who = who.Next;
            }
            Console.WriteLine("Do you wish to print backward?");
            String ans = Console.ReadLine();
            switch (ans)
            {
                case "yes":
                case "YES":
                    while (final != null)
                    {
                        Console.WriteLine(final.FullName);
                        final = final.Prev;
                    }
                    break;
                default: break;
            }
        }


        public void DelAtStart()
        {
            if(head == null)
            {
                Console.WriteLine("Nothing in the list to delete");
                return;
            }

            if(head.Next != null)
            {
                String wh = head.FullName+" has deleted";
                head = head.Next;
                head.Prev = null;
                Console.WriteLine(wh);
            }
            else
            {
                String wh = head.FullName + " has deleted";
                head = null;
                Console.WriteLine(wh+"\n list is emplty now");
            }
        }
        public void DelAtSpecific(Node which)
        {
            if(which==null || head == null)
            {
                Console.WriteLine("Can't delete invalid");
                return;
            }

            // begin node
            if (which.Prev==null)
            {
                String wh = which.FullName + " has deleted";
                head = which.Next;
                head.Prev = null;
                Console.WriteLine(wh);
            }

            //last node
            if (which.Next == null)
            {
                String wh = which.FullName + " has deleted";
                which.Prev.Next = null;
                Console.WriteLine(wh);
            }

            // middle node
            if(which.Prev !=null && which.Prev.Next != null)
            {
                String wh = which.FullName + " has deleted";
                which.Prev.Next = which.Next;
                which.Next.Prev = which.Prev;
                Console.WriteLine(wh);
            }
        }

        // count number of nodes from given
        public int Count(Node current)
        {
            int total = 0;

            if (current == null)
            {
                return 0;
            }
            else
            {
                while (current!=null)
                {
                    total++;
                    current=current.Next;
                }
                return total;
            }
        }

        // search Fullname from given node
        public int Search(String fullName,Node current)
        {
            int position=1;
            if (current == null)
            {
                return -1;
            }
            else
            {
                while (current != null)
                {
                    if(current.FullName.Equals(fullName))
                        return position;
                    position++;
                    current=current.Next;
                }
                return -1;
            }
        }

        // modification
        public void Modify(String oldFullName,String newFullName,Node current)
        {
            if (current == null)
            {
                Console.WriteLine("Modification can;t happen in invalid node");
                return;
            }
            else
            {
                while (current!=null)
                {
                    if (current.FullName.Equals(oldFullName))
                    {
                        current.FullName = newFullName;
                        Console.WriteLine(newFullName + " is replaced the old " + oldFullName);
                        return;
                    }
                    current = current.Next;
                }
                Console.WriteLine(oldFullName + " not found anywhere from the current node");
            }
        }
    }
}
