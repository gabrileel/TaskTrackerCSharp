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
            switch (args[0])
            {
                case "add":
                    {
                        HandlingErrorString(args[1], args);
                        list.AddTask(args[1]);
                        break;
                    }
                case "update":
                    {
                        HandlingErrorInt(Convert.ToInt32(args[1]), args);
                        HandlingErrorString(args[2], args);
                        break;
                    }
                case "delete":
                    {
                        HandlingErrorInt(Convert.ToInt32(args[1]), args);
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
        void HandlingErrorInt<T>(T t, string[] args)
        {
            if (!(t is int))
            {
                Console.WriteLine("Wrong date type. Use command again.");
                Start(args);
            }
        }

        void HandlingErrorString<T>(T t, string[] args)
        {
            if (!(t is string))
            {
                Console.WriteLine("Wrong date type. Use command again.");
                Start(args);
            }
        }

        void HelpMessage()
        {
            Console.WriteLine("Usage: task-cli <command> [options]... ");
        }
    }
}