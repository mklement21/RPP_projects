using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace DataAccessLayer.Repositores {
    public class TaskRepository : IDisposable {

        protected DataBaseModel Context { get; set; }
        protected DbSet<Task> Tasks { get; set; }

        public TaskRepository()
        {
            Context = new DataBaseModel();
            Tasks = Context.Set<Task>();
        }


        public IQueryable<Task> LoadCompleted() {
            var query = from t in Tasks where t.Completed == true select t;
            return query;
        }

        public IQueryable<Task> LoadNotCompleted() {
            var query = from t in Tasks where t.Completed == false select t;
            return query;
        }

        public void Complete(Task odabrani) {
            Tasks.Attach(odabrani);
            odabrani.Completed = true;
            Context.SaveChanges();
        }

        public void AddNew (Task task) {
            Task newTask = new Task {
                Description = task.Description,
                Priority = task.Priority,
                Employee = task.Employee,
            };
            Tasks.Add(newTask);
            Context.SaveChanges();
        }

        public void Dispose() {
            Context.Dispose();
        }
    }
}
