using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class Stacked : LinkedListed
    {
        public Stacked(params int[] ints) : base(ints) { }
        public void Push(int num)
        {
            Console.WriteLine($"Pushing/Adding the top element as {num}");
            base.Add(num);
        }
        public override void Pop()
        {
            Console.WriteLine($"Poping the top element as {head.Info}");
            base.Pop();
        }

        public override void Add(params int[] numbers)
        {
            Console.WriteLine("Cannot add the elements using Add method. Use Push method !");
        }

        public override void Append(params int[] numbers)
        {
            Console.WriteLine("Append() is invalid method in stack. Use Push to add and Pop to delete.");
        }

        public override void PopLast()
        {
            Console.WriteLine("PopLast() is invalid method in stack. Use Push to add and Pop to delete.");
        }

        public override void Insert(int index,int num)
        {
            Console.WriteLine("Insert() is invalid method in stack. Use Push to add and Pop to delete.");
        }
        public void Peek()
        {
            if (head != null)
            {
                Console.WriteLine($"Top of the stack is {head.Info}");
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public override void Display()
        {
            if (head != null)
            {
                NODE cur = head;
                while (cur != null)
                {
                    if (cur == head) Console.WriteLine(cur.Info + " -> top.");
                    else Console.WriteLine(cur.Info);
                    cur = cur.Next;
                }
            }
            else
            {
                Console.WriteLine("No elements in the Stack !");
            }
        }
    }
}
