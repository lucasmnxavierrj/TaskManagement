﻿namespace TaskManagement.Domain.Entities
{
    public class TaskType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<AppTask> Tasks { get; set; }
    }
}
