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
            if (CheckArgsEmpty(args) == false)
            {
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
                            CheckFilterList(args[1], list);
                            break;
                        }
                    case "mark-in-progress":
                        {
                            break;
                        }
                    case "mark-done":
                        {
                            break;
                        }
                    default: HelpMessage(); break;
                }
            }
        }
        bool CheckArgsEmpty(string[] args)
        {
            if (args.Length == 0)
            {
                HelpMessage();
                return true;
            }
            return false;
        }

        void CheckFilterList(string arg, ListTasks list)
        {
            switch (arg)
            {
                case "todo":
                    {
                        list.ShowListFilter(EStatus.Todo);
                        break;
                    }
                case "in-progress":
                    {
                        list.ShowListFilter(EStatus.InProgress);
                        break;
                    }
                case "done":
                    {
                        list.ShowListFilter(EStatus.Done);
                        break;
                    }
                case "":
                    {
                        list.ShowFullList();
                        break;
                    }
                default: HelpMessage(); break;
            }
        }

        void HelpMessage()
        {
            Console.WriteLine("Usage: task-cli <command> [options]... ");
        }
    }
}