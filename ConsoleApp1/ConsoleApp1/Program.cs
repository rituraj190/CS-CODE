using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest sp = new SimpleInterest();
            float x = sp.getsi();
            Console.WriteLine("Rate of interest for one year will be : " + x);

            float y = sp.getAmount();
            Console.WriteLine("Total amount you would pay to bank : " + y);


            compoundInterest coi = new compoundInterest();
            float c = coi.ci(100,2);
            Console.WriteLine("the compound interest on wil be : " + c);


        }
    }
}
