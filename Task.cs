namespace TaskTrackerCSharp
{
    class Task : ITask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public EStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}