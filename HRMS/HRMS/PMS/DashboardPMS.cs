using PMS;
using ProjectManagement;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HRMS
{
    public partial class DashboardPMS : Form
    {
        #region remove screen flickering
        /// <summary>
        /// to remove screen Flickering issue of control
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x2000000;
                return handleparam;
            }
        }
        #endregion
        public DashboardPMS()
        {
            #region Initialization
            InitializeComponent();
            fileAttachment.Click += FileAttachment_Click;
            #endregion
        }
        #region click event
        /// <summary>
        /// FileAttachment click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileAttachment_Click(object sender, EventArgs e)
        {
            FileAttchment fileAttchment = new FileAttchment();
            fileAttchment.Show(pmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// IssueReport click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IssueReport_Click(object sender, EventArgs e)
        {
            AddIssueReport issue_Report = new AddIssueReport();
            issue_Report.Show(pmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// Taskmanagement click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskManagement_Click(object sender, EventArgs e)
        {
            TaskManagement taskManagement = new TaskManagement();
            taskManagement.Show(pmsDockPanel, DockState.Document);
        }

        /// <summary>
        /// Projectmanagement click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectManagement_Click(object sender, EventArgs e)
        {
            Project_ManagementForm project_Management = new Project_ManagementForm();
            project_Management.Show(pmsDockPanel, DockState.Document);
        }
        #endregion
    }
}