using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class Queues: LinkedListed
    {
        public Queues(params int[] numbers) 
        {
            Array.Reverse(numbers);
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

        public void Append(int num)
        {
            Console.WriteLine($"Inserting the element {num} to the last of the Queue ");
            base.Append(num);
        }

        public override void Pop()
        {
            Console.WriteLine($"Poping the first element as {head.Info}");
            base.Pop();
        }

        public override void Add(params int[] numbers)
        {
            Console.WriteLine("Cannot add the elements using Add method. Use Push method !");
        }
        public override void Append(params int[] numbers)
        {
            Console.WriteLine("Cannot append multiple elements at a time !");
        }

        public override void Insert(int index, int num)
        {
            Console.WriteLine("Insert() is invalid method in Queues. Use Append to add and Pop to delete.");
        }
        public override void PopLast()
        {
            Console.WriteLine("PopLast() is invalid method in Queue. Use Push to add and Pop to delete.");
        }

        public void Peek()
        {
            if (head != null)
            {
                Console.WriteLine($"First element of the Queues is {head.Info}");
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
