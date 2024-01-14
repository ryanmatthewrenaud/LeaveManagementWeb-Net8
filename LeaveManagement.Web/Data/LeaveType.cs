namespace LeaveManagement.Web.Data
{
    // inheritting BaseEntity, as to not repeat code
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }


    }
}
