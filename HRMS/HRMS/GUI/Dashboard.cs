using System;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Dashboard : Form
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

        #region Initialization
        public Dashboard()
        {
            InitializeComponent();
            btnLogOut.Click += BtnLogOut_Click;
            picHRMS.Click += PicHRMS_Click;
            picPMS.Click += PicPMS_Click;
        }
        #endregion

        #region Click event
        /// <summary>
        /// picturebox pms click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicPMS_Click(object sender, EventArgs e)
        {
            DashboardPMS dashboardPMS = new DashboardPMS();
            dashboardPMS.Show();
        }

        /// <summary>
        /// picturebox hrms click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicHRMS_Click(object sender, EventArgs e)
        {
            DashboardHRMS dashboardHRMS = new DashboardHRMS();
            dashboardHRMS.Show();
        }

        /// <summary>
        /// button loguot click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to Logout?", "HC&PMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
        #endregion

        #region Tooltip
        /// <summary>
        /// logout button tooltip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btnLogOut, "Logout");
        } 
        #endregion
    }
}