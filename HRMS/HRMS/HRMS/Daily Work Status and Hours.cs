
using HRMS;
using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WeifenLuo.WinFormsUI.Docking;
using static HRMS.Attendance_Leave_System;

namespace HRMS
{
    public partial class Daily_Work_Status_and_Hours : DockContent
    {
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection Connection = new SqlConnection(AppSettings.ConnectionString);
        DataTable dtDailyworkstatus;
        private SqlDataAdapter adpDailyworkstatus;

        public Daily_Work_Status_and_Hours()
        {
            InitializeComponent();
            ProjectComboBox();
            txtStartDate.TextChanged += TextBox_TextChanged;
            txtEndDate.TextChanged += TextBox_TextChanged;
            comboProjectId.SelectedIndexChanged += ComboProjectID_SelectedIndexChanged;
            btnClear.Click += BtnClear_Click;
            btnSubmit.Click += BtnSubmit_Click;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalTime();
        }

        private void CalculateTotalTime()
        {
            if (int.TryParse(txtStartDate.Text, out int startTime) &&
               int.TryParse(txtEndDate.Text, out int endTime))
            {
                int totalTime = endTime + startTime;
                int totalHours = totalTime / 60;
                int totalMinutes = totalTime % 60;
                txtTotalHours.Text = $"{totalTime}:{totalMinutes}";
            }
            else
            {
                txtTotalHours.Text = "Invalid input";
            }            
        }

        #region Button submit
        /// <summary>
        /// Submit button click event for submit data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dailyworkstatus = dtDailyworkstatus.NewRow();
                dailyworkstatus[DBConst.Project_ID] = comboProjectId.Text;
                dailyworkstatus[DBConst.Employee_Name] = comboEmployees.Text;
                dailyworkstatus[DBConst.Work_in_Detail] = richWorkDetails.Text;
                dailyworkstatus[DBConst.StartTime] = txtStartDate.Text;
                dailyworkstatus[DBConst.EndTime] = txtEndDate.Text;
                dailyworkstatus[DBConst.Date] = dateTimePickerDate.Text;
                dailyworkstatus[DBConst.Project_Name] = txtProject.Text;
                dtDailyworkstatus.Rows.Add(dailyworkstatus);
                adpDailyworkstatus.Update(dtDailyworkstatus);
                dtDailyworkstatus.Rows.Clear();
                adpDailyworkstatus.Fill(dtDailyworkstatus);
                AppGlobal.CustomMessageBox.ShowMessage("Feedback Submit Successful", "Information");
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message, "Error");
            }
        }
         

        /// <summary>
        /// clear button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            comboProjectId.Text = string.Empty;
            txtProject.Text = string.Empty;
            comboEmployees.Text = string.Empty;
            richWorkDetails.Text = string.Empty;
            btnSubmit.Enabled = false;
        }
        #endregion 

        /// <summary>
        /// project combobox load data
        /// </summary>
        private void ProjectComboBox()
        {
            SqlConnection connection = new SqlConnection(AppSettings.ConnectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetDistinctProjectID", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboProjectId.Items.Add(reader["Project_ID"].ToString());
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// comboprojectid index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedID = comboProjectId.SelectedItem.ToString();
                SqlConnection connection = new SqlConnection(AppSettings.ConnectionString);
                {
                    connection.Open();
                    string query = $"SELECT Project_Name FROM Project_Management WHERE Project_ID = {comboProjectId.SelectedItem.ToString()}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            txtProject.Text = reader["Project_Name"].ToString();
                        }
                        else
                        {
                            txtProject.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message, "Error");
            }
        }

        #region Form Load
        /// <summary>
        /// Form Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Daily_Work_Status_and_Hours_Load(object sender, EventArgs e)
        {
            FillData();
        }
        #endregion

        #region function
        /// <summary>
        /// Function to filldata
        /// </summary>
        void FillData()
        {
            try
            {
                adpDailyworkstatus = new SqlDataAdapter();
                adpDailyworkstatus.SelectCommand = ClientMethod.DailyWorkStatus_select(); 
                adpDailyworkstatus.InsertCommand = ClientMethod.DailyWorkStatus_insert();
                dtDailyworkstatus = new DataTable();
                dtDailyworkstatus.TableName = TableConst.Registration;
                adpDailyworkstatus.Fill(dtDailyworkstatus);
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage("Invalid Details", "Error");
            }
        }
        #endregion
    }
}