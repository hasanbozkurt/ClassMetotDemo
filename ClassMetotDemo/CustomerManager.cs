using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine(customer.Name + " " +customer.LastName + " : Added");
        }
        
        public void Delete(Customer customer) 
        {
            Console.WriteLine(customer.Name + " " +customer.LastName + " :Deleted");
        }

        public void List(Customer[] customer) 
        {
            foreach (Customer customers in customer)
            {
                Console.WriteLine(customers.Name + " " + customers.LastName);
            }
        }
    }
}
