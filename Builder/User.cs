using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class User
    {
        private int phone;
        private int cp;
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Phone {
            get 
            {
                return phone;
            }
            set 
            { 
                if (value < 600000000)
                {
                    throw new ArgumentException("The phone number is lower than expected.", nameof(Phone));
                }
                if (value > 999999999)
                {
                    throw new ArgumentException("The phone number is higher than expected.", nameof(Phone));
                }
                phone = value;
            }
        }

        public int CP
        {
            get { return cp; }
            set
            {
                if (value < 1000)
                {
                    throw new ArgumentException("The CP number is lower than expected.", nameof(CP));
                }
                if (value > 30000)
                {
                    throw new ArgumentException("The CP number is higher than expected.", nameof(CP));
                }
                cp = value;
            }
        }

        public bool IsAdmin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
