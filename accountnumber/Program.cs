using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long acno;
            Console.WriteLine("Please Enter Account Number : ");
            acno = long.Parse(Console.ReadLine());
            if( )
            {
                Console.WriteLine("it is a valid account number");
                //Console.ReadKey();
                long temp = acno % 10000;
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("Account Number Must be 10 to 15 Digits");
                //Console.WriteLine("Please Re-Enter Account Number : ");
                //acno = int.Parse(Console.ReadLine());
                //Console.ReadKey();
            }

            
            Console.ReadKey();

        }
    }
}
