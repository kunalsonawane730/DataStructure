using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LinkedLists
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            System.Console.WriteLine(data + " inserted in th list ");
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                System.Console.WriteLine("Linked list is empty");
                return;
            }
            System.Console.WriteLine("\nLinkedList elements Are:");
            while (temp != null)
            {
                System.Console.Write(temp.data + " ");
                temp = temp.next;
            }
            System.Console.WriteLine("\n");
        }

        public Node InsertAtPerticularPostion(int position, int data)
        {
            if (position < 1)
            {
                System.Console.WriteLine("Position is not valid.");
            }
            if (position == 1)
            {
                Node node1 = new Node(data);
                node1.next = this.head;
                head = node1;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;

                }
                if (position != 1)
                {
                    System.Console.WriteLine("Invalid position.");
                }

            }
            System.Console.WriteLine("\n inserting value: " + data + " Postion " + position);
            return head;
        }

        public void AddingInReverse(int data)
        {
            Node node2 = new Node(data);
            if (this.head == null)
            {
                this.head = node2;
            }
            else
            {
                Node temp = this.head;
                head = node2;
                head.next = temp;
            }
            System.Console.WriteLine(data + " added in  reverse order \n ");
        }

        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            System.Console.WriteLine("First Node Removed.");
            return this.head;
        }

        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                head = null;
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            System.Console.WriteLine("Last Node Removed.");
            return head;
        }

        public int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }

            if (count >= 0)
            {
                System.Console.WriteLine("result fount at " + count + " location");
                return count;
            }
            else
            {
                System.Console.WriteLine("list is empty");
                return -1;

            }
        }

        public void DeleteAtPerticularPosition(int position)
        {
            Node temp = new Node(position);
            if (this.head == null)
            {
                System.Console.WriteLine("Linked list is empty");
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            System.Console.WriteLine("Node Deleted on" + position + " Position");
        }

        public void size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                System.Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                System.Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            System.Console.WriteLine("linked list size is :" + count);
        }
    
    }
}
