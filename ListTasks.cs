using System.Text.Json;

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
            string fileLocation;
            string jsonSerialize;
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
            SerializeListToJson();
        }

        public void EditTaskDescription(int id, string description)
        {
            DateTime actualDate = DateTime.Now;
            foreach (var task in tasks)
            {
                if (task.Id == id)
                {
                    task.Description = description;
                    task.UpdatedAt = actualDate;
                    break;
                }
            }
        }

        public void EditTaskStatus(EStatus newStatus, int id)
        {
            DateTime actualDate = DateTime.Now;
            switch (newStatus)
            {
                case EStatus.InProgress:
                    {
                        foreach (var task in tasks)
                        {
                            if (task.Id == id)
                            {
                                task.Status = EStatus.InProgress;
                                task.UpdatedAt = actualDate;
                                break;
                            }
                        }
                        break;
                    }
                case EStatus.Done:
                    {
                        foreach (var task in tasks)
                        {
                            if (task.Id == id)
                            {
                                task.Status = EStatus.InProgress;
                                task.UpdatedAt = actualDate;
                                break;
                            }
                        }
                        break;
                    }
                default: break;
            }
        }


        public void ShowListFilter(EStatus status)
        {
            foreach (var task in tasks)
            {
                if (task.Status == status)
                {
                    PrintTaskInfo(task);  
                }
            }
        }

        public void ShowFullList()
        {
            foreach (var task in tasks)
            {
                PrintTaskInfo(task);
            }
        }

        void PrintTaskInfo(Task task)
        {
            Console.WriteLine($"| ID: {task.Id} | Description: {task.Description} | Status: {task.Status} |");
            Console.WriteLine($"| Created at: {task.CreatedAt} | Updated at: {task.UpdatedAt} |");
        }

        public void DeleteTask(int id)
        {
            foreach (var task in tasks)
            {
                if (task.Id == id)
                {
                    tasks.Remove(task);
                }
            }
            SerializeListToJson();
        }
        void SerializeListToJson(string fileLocation = "")
        {
            fileLocation += $"list{DateTime.Now.ToString("hh:mm:ss:f")}.json";
            string jsonSerialize = "";
            foreach (var task in tasks)
            {
                jsonSerialize += JsonSerializer.Serialize(task);
            }
            File.WriteAllText(fileLocation, jsonSerialize);
        }
    }
}