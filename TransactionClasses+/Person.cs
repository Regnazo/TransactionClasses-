using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGUIProject
{
    internal class Person
    {
        private String mFirstName;
        private String mLastName;

        public Person()
        {
            mFirstName = "BLANK";
            mLastName = "BLANK";
        }

        public Person(String firstName, String lastName)
        {
            setFirstName(firstName);
            setLastName(lastName);
        }

        public void setFirstName(String firstName)
        {
            if (firstName != "")
                mFirstName = firstName;
        }
        public void setLastName(String lastName)
        {
            if (lastName != "")
                mLastName = lastName;
        }

        public String getFirstName() { return mFirstName; }
        public String getLastName() { return mLastName; }

        public void Print()
        {
            Console.WriteLine($"{mFirstName} {mLastName}");
        }
    }
}
