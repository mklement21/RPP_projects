using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersProjects {
    public class ProjectReport {
        private ProjectCatalog projectCatalog = new ProjectCatalog();

        public string GenerateReport(string teacher) {
            var projects = projectCatalog.GetProjects(teacher).ToList();
            return PrepareReport(teacher, projects);
        }

        private string PrepareReport(string teacher, List<Project> projects) {
            var report = $"\nProjects for teacher {teacher}:\n";

            report += "\n=================================\n\n";

            foreach (var project in projects) {
                report += $"{project.TeamName} - {project.Description}\n";
            }

            return report;
        }
    }
}
