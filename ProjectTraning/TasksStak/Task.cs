using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.TasksStak
{
    class Task
    {
        private string taskName;

        private int taskNumber;

        public string TaskName
        {
            get { return taskName; }

            set { taskName = value; }
        }

        public int TaskNumber
        {
            get { return taskNumber; }

            set { taskNumber = value; }
        }

        public Task(int taskNumber, string taskName)
        {
            this.TaskNumber = taskNumber;

            this.TaskName = taskName;
        }

        public override string ToString()
        {
            return this.taskNumber + " - " + this.taskName;

        }
    }
}


