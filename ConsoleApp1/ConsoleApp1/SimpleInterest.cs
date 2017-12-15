using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SimpleInterest
    {
        int p ;
        int r = 12;
        float t ;

        public SimpleInterest()
        {
            Console.WriteLine("How much amount you want?");
            string value = Console.ReadLine();
            p = Convert.ToInt32(value);

            Console.WriteLine("For how long you need (months)");
            string interest = Console.ReadLine();
            float temp = Convert.ToInt32(interest);
                     
                t = temp / 12;
                        

        }


        public float getsi()
        {
            
            float si = p * r * t / 100;
            return si;
        }

        public float getAmount()
        {
            float amount = p + getsi(); 
            return amount;
        }
    }
}

