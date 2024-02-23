using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersProjects {
    public class ProjectCatalog {
        private List<Project> _projects = new List<Project>();

        public ProjectCatalog()
        {
            _projects.Add(new Project { TeamName = "T01", Description = "DescriptionA", Teacher = "Pero Peric" });
            _projects.Add(new Project { TeamName = "T02", Description = "DescriptionB", Teacher = "Pero Peric" });
            _projects.Add(new Project { TeamName = "T03", Description = "DescriptionC", Teacher = "Ivo Ivic" });
        }

        public List<Project> GetProjects (string teacher) {
            List<Project> TeacherProjects = new List<Project>();
            foreach (var project in _projects) {
                if (project.Teacher == teacher) {
                    TeacherProjects.Add(project);
                }
            }
            return TeacherProjects;
        }
    }
}
