using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Arif";
            customer1.Surname = "Sığın";
            customer1.City = "İstanbul";
            customer1.Age = 26;
            customer1.IdentityNumber = 20744562137;
            customer1.CreditType = "Öğrenci Kredisi";
            customer1.CreditPoint = 0.15;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Çağlar";
            customer2.Surname = "Şahin";
            customer2.City = "İstanbul";
            customer2.Age = 30;
            customer2.IdentityNumber = 56213720744;
            customer2.CreditType = "Gelecek Yatırım";
            customer2.CreditPoint = 8.16;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Tarık";
            customer3.Surname = "Yılmaz";
            customer3.City = "İzmir";
            customer3.Age = 45;
            customer3.IdentityNumber = 44562207137;
            customer3.CreditType = "Mutlu Girişimci";
            customer3.CreditPoint = 3.32;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Damla";
            customer4.Surname = "Sığın";
            customer4.City = "İskenderun";
            customer4.Age = 25;
            customer4.IdentityNumber = 07445622137;
            customer4.CreditType = "Sağlık";
            customer4.CreditPoint = 9.21;

            //Add Customer
            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);

            //Remove Customer
            customerManager.RemoveCustomer(customer2);

            Customer[] customerList = new Customer[] {customer1, customer2, customer3, customer4};

            customerManager.CustomerList(customerList);

            //Customer List
            Console.WriteLine(customerList);


        }
    }
}
