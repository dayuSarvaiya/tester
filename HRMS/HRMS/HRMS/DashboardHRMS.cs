using PMS;
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
    public partial class DashboardHRMS : Form
    {
        public DashboardHRMS()
        {
            InitializeComponent();
            createUserToolStripMenuItem.Click += CreateUserToolStripMenuItem_Click;
            timeOnOffToolStripMenuItem.Click += TimeOnOffToolStripMenuItem_Click;
            dailyStatusReportToolStripMenuItem.Click += DailyStatusReportToolStripMenuItem_Click;
            attendanceAndLeaveSystemToolStripMenuItem.Click += AttendanceAndLeaveSystemToolStripMenuItem_Click;
            feedbackToolStripMenuItem.Click += FeedbackToolStripMenuItem_Click;
            payrollToolStripMenuItem.Click += PayrollToolStripMenuItem_Click;
            documentManagementToolStripMenuItem.Click += DocumentManagementToolStripMenuItem_Click;
            dailyWorkStatusAndHoursToolStripMenuItem.Click += DailyWorkStatusAndHoursToolStripMenuItem_Click;
        }          

        #region click event
        /// <summary>
        /// DocumentManagement click event in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocumentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentManagement documentManagement = new DocumentManagement();
            documentManagement.Show(hrmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// Dailyworkstatusandhours click event in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailyWorkStatusAndHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daily_Work_Status_and_Hours daily_Work_Status_And = new Daily_Work_Status_and_Hours();
            daily_Work_Status_And.Show(hrmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// Payroll click event in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            payroll.Show(hrmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// Feedback click event in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.Show(hrmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// Attendanceleavesystem click event in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttendanceAndLeaveSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance_Leave_System attendance_Leave = new Attendance_Leave_System();
            attendance_Leave.Show(hrmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// DailystatusReport click event in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailyStatusReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// TimeInoff click event in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeOnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeOnOff timeOnOff = new TimeOnOff();
            timeOnOff.Show(hrmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// registration click event in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show(hrmsDockPanel, DockState.Document);
        }
        #endregion
    }
}