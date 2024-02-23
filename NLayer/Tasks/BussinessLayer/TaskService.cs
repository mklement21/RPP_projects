using DataAccessLayer;
using DataAccessLayer.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLayer {
    public class TaskService {
        public List<Task> LoadCompleted() {
            using (var context = new TaskRepository()) {
                return context.LoadCompleted().ToList();
            }
        }

        public List<Task> LoadNotCompleted() {
            using (var context = new TaskRepository()) {
                return context.LoadNotCompleted().ToList();
            }
        }

        public void Complete (Task odabrani) {
            using (var context = new TaskRepository()) {
                 context.Complete(odabrani);
            }
        }

        public void AddNew(Task task) {
            using (var context = new TaskRepository()) {
                context.AddNew(task);
            }
        }
    }
}
