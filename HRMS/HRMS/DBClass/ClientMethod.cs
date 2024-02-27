using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.AppClass;
using System.Runtime.CompilerServices;

namespace HRMS.DBClass
{
    public class ClientMethod
    {
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection Connection = new SqlConnection(AppSettings.ConnectionString);

        /// <summary>
        /// Select sp for login form
        /// </summary>
        /// <returns></returns>
        public static SqlCommand Login_select()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.Login_select, Connection);
                cmd.Parameters.Add("@" + DBConst.Id, SqlDbType.Int, 0, DBConst.Id);
                cmd.Parameters.Add("@" + DBConst.Username, SqlDbType.NVarChar, 50, DBConst.Username);
                cmd.Parameters.Add("@" + DBConst.Password, SqlDbType.NVarChar, 50, DBConst.Password);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// add data sp for Document Management form
        /// </summary>
        /// <returns></returns>
        public static SqlCommand Document_ManagementAdd()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.SpDocument_ManagementAdd, Connection);
                cmd.Parameters.Add("@" + DBConst.File_Name, SqlDbType.NVarChar, 20, DBConst.Username);
                cmd.Parameters.Add("@" + DBConst.Description, SqlDbType.NVarChar, 50, DBConst.Password);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// insert data for Registration form
        /// </summary>
        /// <returns></returns>
        public static SqlCommand Registration_insert()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(SPConst.Registration_insert, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Firstname, SqlDbType.NVarChar, 50, DBConst.Firstname);
                cmd.Parameters.Add("@" + DBConst.Lastname, SqlDbType.NVarChar, 50, DBConst.Lastname);
                cmd.Parameters.Add("@" + DBConst.Email, SqlDbType.NVarChar, 50, DBConst.Email);
                cmd.Parameters.Add("@" + DBConst.Username, SqlDbType.NVarChar, 50, DBConst.Username);
                cmd.Parameters.Add("@" + DBConst.Password, SqlDbType.NVarChar, 50, DBConst.Password);
                cmd.Parameters.Add("@" + DBConst.Middlename, SqlDbType.VarChar, 50, DBConst.Middlename);
                cmd.Parameters.Add("@" + DBConst.Gender, SqlDbType.NVarChar, 50, DBConst.Gender);
                cmd.Parameters.Add("@" + DBConst.MobileNo, SqlDbType.NVarChar, 50, DBConst.MobileNo);
                cmd.Parameters.Add("@" + DBConst.BloodGroup, SqlDbType.NVarChar, 50, DBConst.BloodGroup);
                cmd.Parameters.Add("@" + DBConst.Address, SqlDbType.VarChar, 50, DBConst.Address);
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// select data for Registration form
        /// </summary>
        /// <returns></returns>
        public static SqlCommand Registration_select()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.Registration_select, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// UpdateSP For Forgot Form
        /// </summary>
        /// <returns></returns>
        public static SqlCommand Forgot_Update()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(SPConst.Forgot_Update, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Password, SqlDbType.NVarChar, 50, DBConst.Password);
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// Select EmployeeInfo SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand EmployeInfo_select()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(SPConst.EmployeInfo_select, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Firstname, SqlDbType.NVarChar, 50, DBConst.Firstname);
                cmd.Parameters.Add("@" + DBConst.Middlename, SqlDbType.VarChar, 50, DBConst.Middlename);
                cmd.Parameters.Add("@" + DBConst.Lastname, SqlDbType.NVarChar, 50, DBConst.Lastname);
                cmd.Parameters.Add("@" + DBConst.Email, SqlDbType.NVarChar, 50, DBConst.Email);
                cmd.Parameters.Add("@" + DBConst.Username, SqlDbType.NVarChar, 50, DBConst.Username);
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// FeedBack Insert SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand Feedback_insert()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(SPConst.Feedback_insert, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Employee, SqlDbType.NVarChar, 50, DBConst.Employee);
                cmd.Parameters.Add("@" + DBConst.Comment, SqlDbType.NVarChar, 50, DBConst.Comment);
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// FeedBack Select SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand Feedback_select()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.Feedback_select, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// Time OnOff Insert SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand TimeOnOff_insert()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(SPConst.TimeOnOff_insert, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.UserId, SqlDbType.Int,0, DBConst.UserId);
                cmd.Parameters.Add("@" + DBConst.TimeOn, SqlDbType.NVarChar, 50, DBConst.TimeOn);
                cmd.Parameters.Add("@" + DBConst.TimeOff, SqlDbType.NVarChar, 50, DBConst.TimeOff);
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// Time OnOff Select SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand TimeOnOff_select()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.TimeOnOff_select, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// FileAttchment Insertb SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand FileAttchment_insert()
        {
            SqlCommand cmd = null;
            #region FileAttchment
            try
            {
                cmd = new SqlCommand(SPConst.FileAttchment_insert, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.ProjectID, SqlDbType.VarChar, 50, DBConst.ProjectID);
                cmd.Parameters.Add("@" + DBConst.FileName, SqlDbType.VarChar, 50, DBConst.FileName);
                cmd.Parameters.Add("@" + DBConst.AttchmentType, SqlDbType.VarChar, 50, DBConst.AttchmentType);
                cmd.Parameters.Add("@" + DBConst.Description, SqlDbType.VarChar, 50, DBConst.Description);
                cmd.Parameters.Add("@" + DBConst.FileSubmit, SqlDbType.VarChar, 50, DBConst.FileSubmit);
                #endregion
            }
            catch (Exception)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// TaskManagement Insert SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand TaskManagement_insert()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.TaskManagement_insert, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Project, SqlDbType.NVarChar, 50, DBConst.Project);
                cmd.Parameters.Add("@" + DBConst.TaskName, SqlDbType.VarChar, 50, DBConst.TaskName);
                cmd.Parameters.Add("@" + DBConst.Description, SqlDbType.VarChar, 50, DBConst.Description);
                cmd.Parameters.Add("@" + DBConst.Owner, SqlDbType.VarChar, 50, DBConst.Owner);
                cmd.Parameters.Add("@" + DBConst.Status, SqlDbType.VarChar, 50, DBConst.Status);
                cmd.Parameters.Add("@" + DBConst.StartDate, SqlDbType.DateTime, 50, DBConst.StartDate);
                cmd.Parameters.Add("@" + DBConst.CompletionDate, SqlDbType.DateTime, 50, DBConst.CompletionDate);
                cmd.Parameters.Add("@" + DBConst.Task_ID,SqlDbType.Int,0,DBConst.Task_ID);  
                cmd.Parameters.Add("@" + DBConst.TaskType, SqlDbType.NVarChar, 50, DBConst.TaskType);
                cmd.Parameters.Add("@" + DBConst.Project_ID, SqlDbType.Int,0, DBConst.Project_ID);
                Connection.Close();
            }
            catch (Exception)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// taskManagement Select SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand TaskManagement_select()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.TaskManagement_select, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// File Attchment Select SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand FileAttchment_select()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.FileAttchment_select, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// TaskManagement Delete SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand TaskManagement_delete()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.TaskManagement_delete, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// Spproject management insert
        /// </summary>
        /// <returns></returns>
        public static SqlCommand SpProject_ManagementInsert()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.SpProject_ManagementInsert, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Project_Name, SqlDbType.NVarChar, 20, DBConst.Project_Name);
                cmd.Parameters.Add("@" + DBConst.Manager_Name, SqlDbType.NVarChar, 30, DBConst.Manager_Name);
                cmd.Parameters.Add("@" + DBConst.Startdate, SqlDbType.DateTime, 20, DBConst.Startdate);
                cmd.Parameters.Add("@" + DBConst.Expected_EndDate, SqlDbType.DateTime, 20, DBConst.Expected_EndDate);
                cmd.Parameters.Add("@" + DBConst.Actual_EndDate, SqlDbType.DateTime, 20, DBConst.Actual_EndDate);
                cmd.Parameters.Add("@" + DBConst.Technology, SqlDbType.NVarChar, 20, DBConst.Technology);
                cmd.Parameters.Add("@" + DBConst.Required_Tools, SqlDbType.NVarChar, 20, DBConst.Required_Tools);
                cmd.Parameters.Add("@" + DBConst.Description, SqlDbType.NVarChar, 20, DBConst.Description);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// store procedure for update
        /// </summary>
        /// <returns></returns>
        public static SqlCommand SpProject_ManagementUpdate()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(SPConst.SpProject_ManagementUpdate, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Project_Id, SqlDbType.Int, 0, DBConst.Project_Id);
                cmd.Parameters.Add("@" + DBConst.Project_Name, SqlDbType.NVarChar, 50, DBConst.Project_Name);
                cmd.Parameters.Add("@" + DBConst.Manager_Name, SqlDbType.NVarChar, 30, DBConst.Manager_Name);
                cmd.Parameters.Add("@" + DBConst.Startdate, SqlDbType.DateTime, 20, DBConst.Startdate);
                cmd.Parameters.Add("@" + DBConst.Expected_EndDate, SqlDbType.DateTime, 20, DBConst.Expected_EndDate);
                cmd.Parameters.Add("@" + DBConst.Actual_EndDate, SqlDbType.DateTime, 20, DBConst.Actual_EndDate);
                cmd.Parameters.Add("@" + DBConst.Technology, SqlDbType.NVarChar, 20, DBConst.Technology);
                cmd.Parameters.Add("@" + DBConst.Required_Tools, SqlDbType.NVarChar, 20, DBConst.Required_Tools);
                cmd.Parameters.Add("@" + DBConst.Description, SqlDbType.NVarChar, 20, DBConst.Description);
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();

            }
            return cmd;
        }

        /// <summary>
        /// stored procedure ProjectManagement for select data
        /// </summary>
        /// <returns></returns>
        public static SqlCommand SpProject_ManagementSelect()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.SpProject_ManagementSelect, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// update sp for task Management
        /// </summary>
        /// <returns></returns>
        public static SqlCommand TaskManagement_Update()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(SPConst.TaskManagement_Update, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Project, SqlDbType.NVarChar, 50, DBConst.Project);
                cmd.Parameters.Add("@" + DBConst.TaskName, SqlDbType.VarChar, 50, DBConst.TaskName);
                cmd.Parameters.Add("@" + DBConst.Description, SqlDbType.VarChar, 50, DBConst.Description);
                cmd.Parameters.Add("@" + DBConst.Owner, SqlDbType.VarChar, 50, DBConst.Owner);
                cmd.Parameters.Add("@" + DBConst.Status, SqlDbType.VarChar, 50, DBConst.Status);
                cmd.Parameters.Add("@" + DBConst.StartDate, SqlDbType.DateTime, 50, DBConst.StartDate);
                cmd.Parameters.Add("@" + DBConst.CompletionDate, SqlDbType.DateTime, 50, DBConst.CompletionDate);
                cmd.Parameters.Add("@" + DBConst.Task_ID, SqlDbType.Int, 0, DBConst.Task_ID);
                cmd.Parameters.Add("@" + DBConst.TaskType, SqlDbType.NVarChar, 50, DBConst.TaskType);
                cmd.Parameters.Add("@" + DBConst.Project_ID, SqlDbType.Int, 0, DBConst.Project_ID);
            }
            catch (Exception)
            {
                return cmd = new SqlCommand();

            }
            return cmd;
        }

        /// <summary>
        /// DailyWorkStatus Insert SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand DailyWorkStatus_insert()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(SPConst.DailyWorkStatus_insert, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.Project_ID, SqlDbType.Int, 0, DBConst.Project_ID);
                cmd.Parameters.Add("@" + DBConst.Employee_Name, SqlDbType.NVarChar, 20, DBConst.Employee_Name);
                cmd.Parameters.Add("@" + DBConst.Work_in_Detail, SqlDbType.NVarChar, 100, DBConst.Work_in_Detail);
                cmd.Parameters.Add("@" + DBConst.StartTime, SqlDbType.Int, 0, DBConst.StartTime);
                cmd.Parameters.Add("@" + DBConst.EndTime, SqlDbType.Int, 0, DBConst.EndTime);
                cmd.Parameters.Add("@" + DBConst.Date, SqlDbType.DateTime, 0, DBConst.Date);
                cmd.Parameters.Add("@" + DBConst.Project_Name, SqlDbType.NVarChar, 20, DBConst.Project_Name);
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// DailyWorkStatus Select SP
        /// </summary>
        /// <returns></returns>             
        public static SqlCommand DailyWorkStatus_select()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.DailyWorkStatus_select, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }

        /// <summary>
        /// AddIssue_Select SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand AddIssue_Select()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.AddIssue_select, Connection);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();

            }
            return cmd;
        }

        /// <summary>
        /// AddIssue_Insert SP
        /// </summary>
        /// <returns></returns>
        public static SqlCommand AddIssue_Insert()
        {
            SqlCommand cmd = null;
            try
            {
                Connection.Open();
                cmd = new SqlCommand(SPConst.AddIssue_Insert, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + DBConst.ProjectName, SqlDbType.NVarChar, 50, DBConst.ProjectName);
                cmd.Parameters.Add("@" + DBConst.IssueType, SqlDbType.NVarChar, 50, DBConst.IssueType);
                cmd.Parameters.Add("@" + DBConst.Priority, SqlDbType.NVarChar, 50, DBConst.Priority);
                cmd.Parameters.Add("@" + DBConst.DueDate, SqlDbType.DateTime, 0, DBConst.DueDate);
                cmd.Parameters.Add("@" + DBConst.AffectsVersion, SqlDbType.NVarChar, 50, DBConst.AffectsVersion);
                cmd.Parameters.Add("@" + DBConst.FixVersion, SqlDbType.NVarChar, 50, DBConst.FixVersion);
                cmd.Parameters.Add("@" + DBConst.Assignee, SqlDbType.NVarChar, 50, DBConst.Assignee);
                cmd.Parameters.Add("@" + DBConst.Description, SqlDbType.NVarChar, 50, DBConst.Description);
                cmd.Parameters.Add("@" + DBConst.Summary, SqlDbType.NVarChar, 50, DBConst.Summary);
                Connection.Close();
            }
            catch (Exception ex)
            {
                return cmd = new SqlCommand();
            }
            return cmd;
        }
    }
}