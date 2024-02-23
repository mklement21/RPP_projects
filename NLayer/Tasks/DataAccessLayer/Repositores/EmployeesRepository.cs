using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositores {
    public class EmployeesRepository : IDisposable {
        private DataBaseModel Context { get; set; }
        private DbSet<Employee> Employees { get; set; }

        public EmployeesRepository()
        {
            Context = new DataBaseModel();
            Employees = Context.Set<Employee>();
        }

        public IQueryable<Employee> GetEmployees() {
            var query = from e in Employees select e;
            return query;
        }
        public void Dispose() {
            Context.Dispose();
        }
    }
}
