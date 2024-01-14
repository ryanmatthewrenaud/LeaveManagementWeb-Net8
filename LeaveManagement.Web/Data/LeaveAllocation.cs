using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    // inheritting BaseEntity, as to not repeat code
    public class LeaveAllocation : BaseEntity
    {

        public int NumberOfDays { get; set; }

        // Foreign key relationship
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId {  get; set; }

        public string EmployeeID { get; set; }

    }
}
