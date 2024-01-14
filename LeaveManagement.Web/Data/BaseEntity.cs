namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        // Common across all tables, only needed once inherit
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
