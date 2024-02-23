using BussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tasks {
    public partial class Tasks : Form {
        private TaskService taskService = new TaskService();
        private EmployeeService employeeService = new EmployeeService();
        public Tasks() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            LoadCompleted();
            LoadEmployees();
            LoadNotCompleted();
            Prioritet();
        }

        private void LoadEmployees() {
            cmbEmployee.DataSource = employeeService.GetEmployees().ToList();
        }
        private void Prioritet() {
            int jedan = 1;
            int dva = 2;
            int tri = 3;
            cmbPrioritet.Items.Add(jedan);
            cmbPrioritet.Items.Add(dva);
            cmbPrioritet.Items.Add(tri);
        }

        private void LoadNotCompleted() {
            dgvNotCompleted.DataSource = taskService.LoadNotCompleted().ToList();
            dgvNotCompleted.Columns["Employee"].Visible = false;
        }

        private void LoadCompleted() {
            dgvCompleted.DataSource = taskService.LoadCompleted().ToList();
            dgvCompleted.Columns["Employee"].Visible = false;
        }

        private void btnComplete_Click(object sender, EventArgs e) {
            var selected = dgvNotCompleted.CurrentRow.DataBoundItem as Task;
            taskService.Complete(selected);

            LoadCompleted();
            LoadNotCompleted();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var desp = txtDescription.Text;
            var prioritet = cmbPrioritet.SelectedItem;
            var employee = cmbEmployee.SelectedItem as Employee;

            Task newTask = new Task {
                Description = desp,
                Priority = Convert.ToInt32(prioritet),
                Employee = employee,
            };
            taskService.AddNew(newTask);
            LoadCompleted();
            LoadNotCompleted();
        }
    }
}
