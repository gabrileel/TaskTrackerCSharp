namespace TaskTrackerCSharp
{
    class Execution
    {
        public void Start(string[] args)
        {
            ListTasks list = new ListTasks();
            HandlingCommands(args, list);
        }
        void HandlingCommands(string[] args, ListTasks list)
        {
            if (args.Length == 1)
            {
                HelpMessage();
            }
            switch (args[0])
            {
                case "add":
                    {
                        list.AddTask(args[1]);
                        break;
                    }
                case "update":
                    {
                        list.EditTaskDescription(Convert.ToInt32(args[1]), args[2]);
                        break;
                    }
                case "delete":
                    {
                        list.DeleteTask(Convert.ToInt32(args[1]));
                        break;
                    }
                case "list":
                    {
                        break;
                    }
                case "mark-in-progress": break;
                case "mark-done": break;
                default: HelpMessage(); break;
            }
        }
        
        void HelpMessage()
        {
            Console.WriteLine("Usage: task-cli <command> [options]... ");
        }
    }
}