using System;
using static System.Console;

namespace assignment5
{
    class Customer
    {
        int CustomerId { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        long Phone { get; set; }
        string City { get; set; }

        public Customer()
        {
            CustomerId = 0;
            Name = " ";
            Age = 0;
            Phone = 0;
            City = " ";
        }
        public Customer(int customerid,string name,int age,long phone,string city)
        {
            CustomerId = customerid;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }
        public static void
            DisplayCustomer(Customer customer)
        {
            WriteLine($"Customer Id:{customer.CustomerId}");
            WriteLine($"Name:{customer.Name}");
            WriteLine($"Age:{customer.Age}");
            WriteLine($"Phone:{customer.Phone}");
            WriteLine($"City:{customer.City}");
        }
        ~Customer()
        {
           
        }
        class Details
        {
            public static void Main()
            {
                WriteLine("Enter Customer Id");
                int customerid= int.Parse(ReadLine());

                WriteLine("Enter Name");
                string name = ReadLine();

                WriteLine("Enter Age");
                int age = int.Parse(ReadLine());

                WriteLine("Enter Customer Phone Number");
                long phone = Convert.ToInt64(ReadLine());

                WriteLine("Enter City");
                string city =ReadLine();

                Customer details = new Customer(customerid, name, age, phone, city);
                Customer.DisplayCustomer(details);



            }
        }
    }
}
