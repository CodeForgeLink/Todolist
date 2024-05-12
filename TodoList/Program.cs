namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] todoList = new string[15];
            string command = "";
            int currentTaskCount = 0;

            while(command != "quit")
            {
                Console.WriteLine("Please enter a command(add, view, delete, quit):");
                command = Console.ReadLine().ToLower();

                if(command == "add")
                {

                    if(currentTaskCount < todoList.Length)
                    {
                        Console.WriteLine("Please enter a task to add:");
                        string task = Console.ReadLine();
                        todoList[currentTaskCount] = task;
                        currentTaskCount++;

                    }
                    else
                    {
                        Console.WriteLine("Todolist is full.");
                    }


                }
                else if(command == "view")
                {
                    Console.WriteLine("Your current tasks are:");

                    for(int i = 0; i < currentTaskCount; i++)
                    {
                        Console.WriteLine((i+1) + "." + todoList[i]);
                    }



                }
                else if (command == "delete")
                {
                    Console.WriteLine("Please enter the number of the task to delete:");
                    int taskNumber = int.Parse(Console.ReadLine()) - 1;

                    if(taskNumber < 0 || taskNumber >= currentTaskCount)
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                    else
                    {
                        for (int i = taskNumber; i < currentTaskCount - 1; i++)
                        {
                            todoList[i] = todoList[i + 1];
                        }

                        currentTaskCount--;
                        Console.WriteLine("Task removed");
                    }


                }
                else if(command == "quit")
                {
                    Console.WriteLine("Goodbye!");
                }

            }
        }
    }
}
