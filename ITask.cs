namespace TaskTrackerCSharp
{
    public interface ITask
    {
        int Id { get; set; }
        string Description { get; set; }
        EStatus Status { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}