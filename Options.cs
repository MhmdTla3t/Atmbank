using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATMIMPLEMANTATION
{
     class Options : Atminfo
    {


        public double balance = 100000;
        public string name;

        public int account;

        public double withdraw;
        public double dep;
        public double tobal;

        public void Caladeposet()

        {

            Console.WriteLine("Enter Name of the depositor:");

            name = Console.ReadLine();

            Console.WriteLine("Enter Account Number:");

            account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Deposit Amount:");

            dep = Convert.ToDouble(Console.ReadLine());

            tobal = bal + dep;

            Console.WriteLine("——————————\n");

            Console.WriteLine("Name of the depositor: " + name);

            Console.WriteLine("Account Number: " + account);

            Console.WriteLine("Total Balance amount in the account: " + tobal);

        }

        public void CalacWithdraw()

        {

            Console.WriteLine("Enter Account Name:");

            name = Console.ReadLine();

            Console.WriteLine("Enter Account Number:");

            account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Withdraw Amount:");

            withdraw = Convert.ToDouble(Console.ReadLine());

            if (withdraw <= bal)

            {

                tobal = (bal - withdraw);

                Console.WriteLine("——————————\n");

                Console.WriteLine("Account Name: " + name);

                Console.WriteLine("Account Number: " + account);

                Console.WriteLine("After Withdraw Amount balnace is : " + tobal);
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
        }



        public void CalacBalnc()
        {
            //balance = balance + withdraw;
            Console.WriteLine("Balnce is : " + balance + withdraw);

        }


    }
}

