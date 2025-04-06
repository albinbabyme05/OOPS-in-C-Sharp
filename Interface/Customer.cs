using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public Customer(int id, string firstName, string lastName, string email,
                                                           string phoneNumber, DateTime dob,string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dob;
            Address = address;
        }
        public int GetAge()
        {
            var toady = DateTime.Today;
            var age = toady.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > toady.AddYears(-age)) age--;
            return age;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void UpdateDetails(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void PrintCustomerDetails()
        {
            Console.WriteLine("customer full name: "+GetFullName());
            Console.WriteLine("customer id: "+Id);
            Console.WriteLine("email: "+Email);
            Console.WriteLine("phone: "+PhoneNumber);
            Console.WriteLine("age: "+GetAge());
            Console.WriteLine("address: "+Address);

        }
    }
}
