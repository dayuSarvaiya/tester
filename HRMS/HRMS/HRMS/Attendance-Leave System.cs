using HRMS.AppClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HRMS
{
    public partial class Attendance_Leave_System : DockContent
    {
        private List<Employee> employees = new List<Employee>();
        private List<Attendance> attendanceRecords = new List<Attendance>();
        private List<LeaveRequest> leaveRequests = new List<LeaveRequest>();

        internal class Employee
        {
            internal string EmployeeId;
            private string v1;
            private string v2;
            private string v3;
            public string Name { get; internal set; }
            public object FirstName { get; internal set; }
            public object LastName { get; internal set; }
            public object DailyWorkStatusList { get; internal set; }
        }
        public Attendance_Leave_System()
        {
            InitializeComponent();
            InitializeData();
            LoadEmployees();
            btnMarkAttendance.Click += BtnMarkAttendance_Click;
            btnViewAttendance.Click += BtnViewAttendance_Click;
            btnViewLeaveRequests.Click += BtnViewLeaveRequests_Click;
            btnRequestLeave.Click += BtnRequestLeave_Click;
            void InitializeData()
            {
                employees.Add(new Employee { EmployeeId = "001", Name = "Dhruv" });
                employees.Add(new Employee { EmployeeId = "002", Name = "Ram" });
                employees.Add(new Employee { EmployeeId = "003", Name = "Ramanand" });
            }
            void LoadEmployees()
            {
                foreach (var employee in employees)
                {
                    comboBoxEmployees.Items.Add(employee);
                }
                if (comboBoxEmployees.Items.Count > 0)
                    comboBoxEmployees.SelectedIndex = 0;
            }
        }

        #region Click Event
        /// <summary>
        /// Button Request Click Event(Leave)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRequestLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEmployees.SelectedItem != null)
                {
                    var selectedEmployee = (Employee)comboBoxEmployees.SelectedItem;
                    var leaveRequestForm = new LeaveRequestForm(selectedEmployee.EmployeeId);
                    var result = leaveRequestForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        leaveRequests.Add(leaveRequestForm.LeaveRequest);
                        AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {selectedEmployee.Name}", "Leave Requested");
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Button Click Event View Leave Request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnViewLeaveRequests_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployees.SelectedItem != null)
            {
                var selectedEmployee = (Employee)comboBoxEmployees.SelectedItem;
                var employeeLeaveRequests = GetEmployeeLeaveRequests(selectedEmployee.EmployeeId);
                DisplayLeaveRequests(employeeLeaveRequests);
            }
        }

        /// <summary>
        /// Button Click Event View Attandance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnViewAttendance_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployees.SelectedItem != null)
            {
                var selectedEmployee = (Employee)comboBoxEmployees.SelectedItem;
                var employeeAttendance = GetEmployeeAttendance(selectedEmployee.EmployeeId);
                DisplayAttendanceHistory(employeeAttendance);
            }
        }

        /// <summary>
        /// Button Click Event Mark Attendance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMarkAttendance_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployees.SelectedItem != null)
            {
                var selectedEmployee = (Employee)comboBoxEmployees.SelectedItem;
                var attendance = new Attendance { EmployeeId = selectedEmployee.EmployeeId, Date = DateTime.Now, IsPresent = true };
                attendanceRecords.Add(attendance);
                AppGlobal.CustomMessageBox.ShowMessage($"Attendance marked for {selectedEmployee.Name} on {attendance.Date.ToShortDateString()}", "Information");
            }
        }
        #endregion

        /// <summary>
        /// Get Employee Attandance list
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        List<Attendance> GetEmployeeAttendance(string employeeId)
        {
            var employeeAttendance = new List<Attendance>();
            foreach (var attendance in attendanceRecords)
            {
                if (attendance.EmployeeId == employeeId)
                {
                    employeeAttendance.Add(attendance);
                }
            }
            return employeeAttendance;
        }

        /// <summary>
        /// Display Employee Attandance
        /// </summary>
        /// <param name="employeeAttendance"></param>
        void DisplayAttendanceHistory(List<Attendance> employeeAttendance)
        {
            dataGridViewAttendance.DataSource = employeeAttendance;
        }

        /// <summary>
        /// Get Employee Leave Request List
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        List<LeaveRequest> GetEmployeeLeaveRequests(string employeeId)
        {
            var employeeLeaveRequests = new List<LeaveRequest>();
            foreach (var leaveRequest in leaveRequests)
            {
                if (leaveRequest.EmployeeId == employeeId)
                {
                    employeeLeaveRequests.Add(leaveRequest);
                }
            }
            return employeeLeaveRequests;
        }

        /// <summary>
        /// Display Leave Request
        /// </summary>
        /// <param name="employeeLeaveRequests"></param>
        void DisplayLeaveRequests(List<LeaveRequest> employeeLeaveRequests)
        {
            dataGridViewLeaveRequests.DataSource = employeeLeaveRequests;
        }
    }
}