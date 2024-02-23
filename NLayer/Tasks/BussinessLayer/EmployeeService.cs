using DataAccessLayer;
using DataAccessLayer.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer {
    public class EmployeeService {
        public List<Employee> GetEmployees() {
            using (var context = new EmployeesRepository()) {
                return context.GetEmployees().ToList();
            }
        }
    }
}
