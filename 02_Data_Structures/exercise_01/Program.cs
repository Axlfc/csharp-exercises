using System;

namespace DataStructures {
    class Program {
        public struct Customer {
            public string FullName;
            public string Phone;
            public string Address;
            public string Email;
            public bool IsNewCustomer;

            public void Render() {
                Console.WriteLine("Full Name: " + FullName);
                Console.WriteLine("Phone: " + Phone);
                Console.WriteLine("Address: " + Address);
                Console.WriteLine("Email: " + Email);
                Console.WriteLine("New Customer: " + IsNewCustomer);
            }
        }


        static void Main(string[] args) {
            // Create a data structure for a customer with these fields:
            // - Full name
            // - Phone
            // - Address
            // - E-mail
            // - If you are a new customer

            // Bonus: write a method to render this data from the structure by doing Console.WriteLine(...)

            Customer customer = new Customer
            {
                FullName = "John Smith",
                Phone = "555-1234",
                Address = "123 Main St.",
                Email = "john.smith@example.com",
                IsNewCustomer = true
            };

            customer.Render();
        }
    }
}
