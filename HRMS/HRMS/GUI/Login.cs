using HRMS.AppClass;
using PMS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Login : Form
    {
        #region Connection
        /// <summary>
        /// Connection String
        /// </summary>
        public static AppSetting appSettings = new AppSetting();
        public static SqlConnection connection = new SqlConnection(appSettings.ConnectionString); 
        #endregion

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
        public Login()
        {
            #region Initialization
            InitializeComponent(); 
            #endregion
        }
        #region Button click event
        /// <summary>
        /// Sign in button click event to insert data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Signin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (ValidateUser(username, password))
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                AppGlobal.CustomMessageBox.ShowMessage("Invalid username or password.", "Error");
            }
        }

        /// <summary>
        /// Forgot button click event to forgot password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Forgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot forgot = new Forgot();
            forgot.Show();
        }

        /// <summary>
        /// Register button click event to register data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }
        #endregion

        #region Function
        /// <summary>
        /// validation function to apply validation
        /// </summary>
        /// <returns></returns> 
        private bool ValidateUser(string username, string password)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Login_select", connection);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                {
                    return reader.HasRows;
                }
            }
        }
        #endregion
    }
}