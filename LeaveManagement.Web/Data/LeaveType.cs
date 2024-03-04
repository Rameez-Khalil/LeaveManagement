namespace LeaveManagement.Web.Data
{

    //These props will be translated into SQL tables/cols.
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
     

    }
}
