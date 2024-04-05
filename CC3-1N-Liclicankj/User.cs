using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_Liclicankj
{
    public class User
    {
        public string Name { get; }
        public string Address { get; }
        public string Email { get; }
        public int PhoneNumber { get; }

        public User(string name, string address, string email, int phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}