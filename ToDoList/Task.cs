using System;

namespace ToDoListNS
{
    public class Task
    {
        private String description = null;
        private Boolean isComplete = false;


        public Task(String description)
        {
            this.description = description;
        }

        public Task(String description, Boolean isComplete)
        {
            this.description = description;
            this.isComplete = isComplete;
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        public Boolean IsComplete
        {
            get { return isComplete; }
            set { isComplete = value; }
        }

    }
}

