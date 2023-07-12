using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ATMIMPLEMANTATION
{
    public class Program
    {
        static void Main(string[] args)
        {

            char agn;
            char agn1;
      

            Console.WriteLine("Welcome in Bm Bank\n");
           

                do

                {

                    Options k = new Options();
                    int num;

                    Console.WriteLine("Please Select Any Function.\n");
          
              

                { 
                    Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.\nPress 3 for balance an Amount \nPress 4 for Exit");
               
                    num = Convert.ToInt32(Console.ReadLine());

                    switch (num)

                    {
                        case 3:

                            k.CalacBalnc();

                            break;

                        case 1:

                            k.Caladeposet();

                            break;

                        case 2:

                            k.CalacWithdraw();

                            break;


                        case 4:

                            Console.WriteLine("Thank's for use BM Bank");

                            break;

                        default:

                            Console.WriteLine("Invalid Selection!!!");

                            break;

                    } 
                }


                    Console.WriteLine("\nDo you want to continue this program ? (y / n)");

                agn = Convert.ToChar(Console.ReadLine());

            }
                while (agn == 'y');

            Console.ReadKey();

        }

    }

}
