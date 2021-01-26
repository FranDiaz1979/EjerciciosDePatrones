using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class User
    {
        private int phone;
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Street { get; set; }
        public int CP { get; set; }
        public string City { get; set; }
        public int Phone {
            get 
            {
                return phone;
            }
            set 
            { 
                if (phone < 600000000)
                {
                    throw new ArgumentException("The phone number is lower than expected.", nameof(Phone));
                }
                if (phone > 999999999)
                {
                    throw new ArgumentException("The phone number is higher than expected.", nameof(Phone));
                }
                phone = value;
            }
        }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public bool IsAdmin { get; set; }
        public string Name { get; set; }
        public string Subname { get; set; }
        public string Email { get; set; }
    }
}
