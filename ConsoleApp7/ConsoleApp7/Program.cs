using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 26,28,36,58,98};
            List<int> list2 = new List<int>() { 25,26,27,35,57,58,97};
            var birinciFerq = list1.Except(list2);

            foreach(int item in birinciFerq)
            {
                Console.WriteLine("Ikinci listde olmuyanlar:  "+item);
            }

            Console.WriteLine("             ");

            var ikinciFerq = list2.Except(list1);
            foreach (int item1 in ikinciFerq)
            {
                Console.WriteLine("Birinci listde olmuyanlar:  "+item1);
            }

        }
    }
}
