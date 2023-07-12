using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMIMPLEMANTATION
{
    public class Atminfo
    {

        public double balance = 100000;
        public int password {  get; set; }
        public  string name{get ;set;}
        public int account { get; set;}
        public double withdraw { get; set;}
        public double dep { get; set;}
        public double tobal { get; set;}

        public double bal

        {

            get { return balance; }

            set { balance = value; }

        }

    }
}
