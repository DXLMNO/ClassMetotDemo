using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Add A New Customer: " + " Customer Identity Number: "+ customer.IdentityNumber +" Customer Name: "+ customer.Name +" Customer Surname: "+customer.Surname);
            Console.WriteLine("Please Add Customer İnformations:" + "Customer City:" + customer.City + "Customer Age:" + customer.Age);
            Console.WriteLine("Please Add Customer's Credit Type and Point:" + "Customer Credit Type:" + customer.CreditType + "Customer Credit Point:" + customer.CreditPoint);
            Console.WriteLine("Thank You!");
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Delete Customer:" + " Please Write Customer Id:" + customer.Id + "Please Write Customer Identity Number:" + customer.IdentityNumber );
        }


        public void CustomerList(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer List:");
                Console.WriteLine("Customer:" + "  " + "ID:" + customer.Id + " "+ "Name:" + customer.Name + " " + "Surname:" + customer.Surname + " " + "City:" + customer.City + " " + "Age:" + customer.Age + " " + "CreditType:" + customer.CreditType + "Credit Point:" + customer.CreditPoint );
            }
        }









    }
}
