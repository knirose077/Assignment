using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_A
{
    public class calculator
    {     
            public double Number { get; set; }

            public void SqrRt(double n)
            {
                Number = n;
                double ans = Math.Sqrt(n);
                Console.WriteLine("The square root of number is " + ans);

            }

            public void Cube(double no)
            {
                Number = no;
                double answer = no * no * no;
                Console.WriteLine("The cube of number is " + answer);
            }
       }
  }
        

