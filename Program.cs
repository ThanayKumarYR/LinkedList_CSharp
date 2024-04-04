using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinkedListed list = new LinkedListed(70, 30, 56);
                list.Display();

                LinkedListed list2 = new LinkedListed();
                list2.Add(70);
                list2.Add(30);
                list2.Add(56);
                list2.Display();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);   
            }
            
        }
    }
}
