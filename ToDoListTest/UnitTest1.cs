using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListNS;
using System;
using System.Collections.Generic;

namespace ToDoListTest
{

    [TestClass]
    public class ToDoListTest
    {
        private ToDoListNS.Task task1;
        private ToDoListNS.Task task2;  
        private ToDoListNS.Task task3;
        private ToDoListNS.ToDoList todoList;

        [TestInitialize]
        public void testInitialize()
        {
            task1 = new ToDoListNS.Task("task1", false); 
            task2 = new ToDoListNS.Task("task2", false); 
            task3 = new ToDoListNS.Task("task3", false); 
            todoList = new ToDoListNS.ToDoList();
        }
        [TestCleanup]
        public void testCleanup()
        {
            task1 = null;
            task2 = null;
            task3 = null;
            todoList = null;
        }
        [TestMethod]
        public void TestAddtask()
        {
            Task task1 = new Task("task1", false);
            ToDoListNS.ToDoList todoList = new ToDoListNS.ToDoList();
            Assert.IsNotNull(todoList);
            todoList.addTask(task1);
            Assert.AreEqual(1, todoList.getAllTasks().Count);
            Assert.AreEqual(task1, todoList.getTask(task1.Description));
        }

        [TestMethod]
        public void TestCompleteTask()
        {
            Task task1 = new Task("task1", false);
            ToDoListNS.ToDoList todoList = new ToDoListNS.ToDoList();
            Assert.IsNotNull(todoList);
            todoList.addTask(task1);

            Assert.AreEqual(1, todoList.getAllTasks().Count);
            Assert.IsFalse(todoList.getStatus(task1.Description));
            todoList.completeTask(task1.Description);
            Assert.IsTrue(todoList.getStatus(task1.Description));
        }

        [TestMethod]
        public void testgetStatus()
        {
            Assert.IsNotNull(todoList);
            todoList.addTask(task1);
            Assert.AreEqual(false, todoList.getStatus(task1.Description));
            todoList.completeTask(task1.Description);
            Assert.AreEqual(true, todoList.getStatus(task1.Description));
        }
        [TestMethod]
        public void testRemoveTask()
        {
            Assert.IsNotNull(todoList);
            todoList.addTask(task1);
            todoList.addTask(task2);

            todoList.removeTask(task1.Description);
            Assert.IsNull(todoList.getTask(task1.Description));
        }

        [TestMethod]
        public void testGetCompletedTasks()
        {
            task1.IsComplete = true;
            task3.IsComplete = true;
            todoList.addTask(task1);
            todoList.addTask(task2);
            todoList.addTask(task3);

            List<Task> tasks = todoList.getCompletedTasks();
            Assert.AreEqual(2, tasks.Count);
        }

        [TestMethod]
        public void testGetAllTask()
        {
            Assert.IsNotNull(todoList);
            todoList.addTask(task1);
            todoList.addTask(task2);
            todoList.addTask(task3);

            Assert.AreEqual(3, todoList.getAllTasks().Count);
        }
    }
  
}
