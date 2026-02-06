namespace TaskTrackerCSharp
{
    public class ListTasks
    {
        private List<Task> tasks;
        public ListTasks()
        {
            tasks = new List<Task>();
        }
        public void AddTask(string description)
        {
            DateTime actualDate = DateTime.Now;
            Task newTask = new Task();
            int idTask = 1;
            foreach (var task in tasks)
            {
                idTask++;
            }
            newTask.Id = idTask;
            newTask.Description = description;
            newTask.CreatedAt = actualDate;
            newTask.UpdatedAt = actualDate;
            newTask.Status = EStatus.Todo;
            tasks.Add(newTask);
        }

        public void ShowFullList()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"| ID: {task.Id} | Description: {task.Description} | Status: {task.Status} |");
                Console.WriteLine($"| Created at: {task.CreatedAt} | Updated at: {task.UpdatedAt} |");
            }
        }
    }
}