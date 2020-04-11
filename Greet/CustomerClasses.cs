using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    class CustomerClasses
    {
        public class CurrentCustomer : ICustomer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email => "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
        }
        public class PastCustomer : ICustomer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email => "It's been a long time since we've heard from you, we want you back";
        }
        public class PotentialCustomer : ICustomer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email => "We currently have the lowest rates on Helicopter Insurance!";
        }
    }
}
