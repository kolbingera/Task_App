using System.Collections.Generic;
using System.Linq;
using Task_App.Models;

namespace Task_App.DataAccessLayer
{
    public static class TaskContextInitializer
    {
        public static void Initialize(TaskDbContext context) 
        {
            context.Database.EnsureCreated(); //at first look if it has already been created

            if (context.Tasks.Any())
            {
                return;   // DB has been seeded if any tasks are detected
            }

            var tasks = new List<Task> //collection (list) of tasks
            {//idk how to put user input newTaskEntry in a task to be saved on the db yet
            };

            context.Tasks.AddRange(tasks);  //adding multiple entries to the db and saving the changes
            context.SaveChanges();
        }
    }
}
