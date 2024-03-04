using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
      
        public string Name { get; set; }
        

        //EF will automatically know that this is a foreign key relationship.
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; }
    }
}
