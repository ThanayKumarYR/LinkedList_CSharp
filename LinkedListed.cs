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

        public void Display()
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
    }
}
