using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    //Identity User is a class, responsible for storing information related to users.
    //Just by adding a ? after the data type, we can expect the data type to hold null values.

    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? lastName { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
