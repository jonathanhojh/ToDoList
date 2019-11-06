using System;
using System.Collections.Generic;

namespace ToDoListNS {
    public class ToDoList {

        private Dictionary<String, Task> tasks = new Dictionary<String, Task>();

        public void addTask(Task task) {
            tasks.Add(task.Description, task);
        }
        public void completeTask(String description) {
            Task task = null;
            if ( tasks.ContainsKey(description) == true) {
                task = tasks[description];
                task.IsComplete = true;
            };
        }
        public Boolean getStatus(String description) {
            Task task = null;
            if (tasks.ContainsKey(description) == true) {
                task = tasks[description];
                return task.IsComplete;
            };
            return false;
        }
        public Task getTask(String description) {
            if (tasks.ContainsKey(description) == false)
                return null;
            else
                return tasks[description];
        }
        public Task removeTask(String description) {
            Task task = tasks[description];
            tasks.Remove(description);
            return task;
        }
        public List<Task> removeAllTasks(List<Task> allTasks){
            //List<Task> allTasks = new List<Task>();
            allTasks.Clear();
            return allTasks;
        }

        public List<Task> getAllTasks() {
            List<Task> allTasks = new List<Task>();
            allTasks.AddRange(tasks.Values);
            return allTasks;
        }
        public List<Task> getCompletedTasks() {
            List<Task> completedTasks = new List<Task>();
            List<Task> allTasks = new List<Task>();
            allTasks = getAllTasks();
            foreach(Task task in allTasks)
                if (task.IsComplete == true) completedTasks.Add(task);
            return completedTasks;
        }
    }
}
