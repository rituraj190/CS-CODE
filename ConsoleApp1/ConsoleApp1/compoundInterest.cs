using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class compoundInterest
    {

        float p;
        float n = 1;
        int r = 10;
        float t;
        float amount;

        public compoundInterest()
        {
            //Console.WriteLine("How much amount you want : ");
            //string ps = Console.ReadLine();
            //p = Convert.ToInt32(ps);

            //Console.WriteLine("For how long you need : ");
            //string ts = Console.ReadLine();
            //t = Convert.ToInt32(ts);

        }

        public float ci(float p,float t)
        {
            float nt = n * t;
            float rn = 1 + r / n;
            

            int i = 2;
            float temp;
            float temp2;


            if (nt == 1)
            {
                amount = p * rn;
            }

            else if (nt == 2)
            {
                amount = p * rn * rn;
            }


            else
            {
                do { temp = rn * rn; }

                while (i < nt);
                {
                    temp2 = temp * rn;
                    i++;
                }

                amount = p * temp2;
            }

            return amount;
            

            
        }
            

        }


    }

