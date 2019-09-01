using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.TasksStak
{
    class TaskList
    {
        private List<Task> listOfTasks = new List<Task>()
        {
            new Task(1, "Cook food"),

            new Task(2, "Buy Productse"),

            new Task(3, "Make tea")
        };

        public List<Task> GetTaskList()
        {
            return listOfTasks;
        }
    }
}
