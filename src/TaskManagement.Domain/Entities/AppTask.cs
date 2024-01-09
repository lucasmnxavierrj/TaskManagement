namespace TaskManagement.Domain.Entities
{
    public class AppTask
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UserId { get; set; }
        public int TaskTypeId { get; set; }
        public TaskType TaskType { get; set; }
        public User User { get; set; }
    }
}
