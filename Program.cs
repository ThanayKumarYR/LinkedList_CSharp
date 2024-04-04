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

                LinkedListed list3 = new LinkedListed();
                list3.Append(56);
                list3.Append(30);
                list3.Append(70);
                list3.Display();    

                LinkedListed list4 = new LinkedListed(70,56);
                list4.Insert(1, 30);
                list4.Display();

                LinkedListed list5 = new LinkedListed(70, 30, 56);
                list5.Display();
                list5.pop();
                list5.Display();

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);   
            }
            
        }
    }
}
