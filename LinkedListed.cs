using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    class LinkedListed
    {
        public NODE head;
        public LinkedListed(params int[] numbers)
        {
            if (numbers.Length != 0)
            {
                head = new NODE();  
                head.Info = numbers[0];
                head.Next = null;
                if (numbers.Length > 1)
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        NODE cur = new NODE();
                        cur.Info = numbers[i];
                        cur.Next = head;
                        head = cur;
                    }
                }
            }
            else { head = null; } 
        }

        public void Display()
        {
            if (head != null)
            {
                NODE cur = head;
                Console.WriteLine();
                while (cur != null)
                {
                    Console.Write(cur.Info + " ");
                    cur = cur.Next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No elements in the Linked List !");
            }
        }

        public void Add(params int[] numbers)
        {
                if (head == null)
                {
                    head = new NODE();
                    head.Info = numbers[0];
                    head.Next = null;
                }
                else 
                {
                    foreach (int num in numbers)
                    {
                        NODE cur = new NODE();
                        cur.Info = num;
                        cur.Next = head;
                        head = cur;
                    }
                }  
            
        }
    }
}
