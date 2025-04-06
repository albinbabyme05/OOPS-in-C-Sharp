using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICustomer
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        DateTime DateOfBirth { get; set; }
        string Address { get; set; }

        void UpdateDetails(string email, string phoneNumber);
        string GetFullName();
        int GetAge();
        

        
    }
}
