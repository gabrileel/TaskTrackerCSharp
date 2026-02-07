namespace TaskTrackerCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Execution e = new Execution();
            // e.Start(args);

            ListTasks list = new ListTasks();
            list.AddTask("teste");
            list.AddTask("testando");
            list.ShowFullList();
        }
    }
}