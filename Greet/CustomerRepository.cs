using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    class CustomerRepository
    {
        List<ICustomer> _customerDirectory = new List<ICustomer>();
        public bool AddToDirectory(ICustomer customer)
        {
            int startingCount = _customerDirectory.Count;
            _customerDirectory.Add(customer);
            return _customerDirectory.Count > startingCount;
        }
        public void ListAllCustomers()
        {

        }
        public void UpdateCustomer()
        {

        }
        public bool RemoveCustomer()
        {

        }
    }
}
