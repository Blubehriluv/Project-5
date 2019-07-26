using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Classes
{
    public abstract class Person
    {
        protected string FirstName = "John";
        protected string LastName = "Smith";
        protected string PhoneNum = "18005551234"; 

        public Person(string fName, string lName, string pNum)
        {
            FirstName = fName;
            LastName = lName;
            PhoneNum = pNum;
        }

        public Person()
        {

        }

        public string fName
        {
            get { return FirstName; }
            set
            {
                
            }
        }

        public string lName
        {
            get { return LastName; }
            set
            {

            }
        }

        public string pNum
        {
            get { return PhoneNum; }
            set
            {

            }
        }

    }
}
