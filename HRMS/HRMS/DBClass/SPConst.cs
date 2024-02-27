using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DBClass
{
    public class SPConst
    {
        #region All Stored Procedure
        /// <summary>
        /// Login select sp of login page HRMS
        /// </summary>
        public const string Login_select = "Login_select";

        /// <summary>
        /// Add data store procedure of Docuent management HRMS  
        /// </summary>
        public const string SpDocument_ManagementAdd = "SpDocument_ManagementAdd";

        /// <summary>
        /// Update data stored procedure of document management HRMS 
        /// </summary>
        public const string SpDocument_ManagementUpdate = "SpDocument_ManagementUpdate";

        /// <summary>
        /// Delete data stored procedure Document management HRMS
        /// </summary>
        public const string SpDocument_ManagementDelete = "SpDocument_ManagementDelete";

        /// <summary>
        /// Select stored procedure of Document Management HRMS
        /// </summary>
        public const string SpDocument_ManagementSelect = "SpDocument_ManagementSelect";

        /// <summary>
        /// Select stored procedure of Registration HRMS
        /// </summary>
        public const string Registration_select = "Registration_select";

        /// <summary>
        /// Insert stored procedure of Registration HRMS
        /// </summary>
        public const string Registration_insert = "Registration_insert";

        /// <summary>
        /// Update stored procedure of ForgotPassword HRMS
        /// </summary>
        public const string Forgot_Update = "Forgot_Update";

        /// <summary>
        /// Select stored procedure of Employee info HRMS
        /// </summary>
        public const string EmployeInfo_select = "EmployeInfo_select";

        /// <summary>
        /// Insert stored procedure of feedback HRMS
        /// </summary>
        public const string Feedback_insert = "Feedback_insert";

        /// <summary>
        /// Select stored procedure of feedback HRMS
        /// </summary>
        public const string Feedback_select = "Feedback_select";

        /// <summary>
        /// Insert Stored procedure of Timeonoff HRMS
        /// </summary>
        public const string TimeOnOff_insert = "TimeOnOff_insert";

        /// <summary>
        /// Select stored procedure of Timeonoff HRMS
        /// </summary>
        public const string TimeOnOff_select = "TimeOnOff_select";

        /// <summary>
        /// Insert stored procedure of task management PMS
        /// </summary>
        public const string TaskManagement_insert = "TaskManagement_insert";

        /// <summary>
        /// Insert stored procedure of File attechment PMS
        /// </summary>
        public const string FileAttchment_insert = "FileAttchment_insert";

        /// <summary>
        /// Select stored procedure of task management PMS
        /// </summary>
        public const string TaskManagement_select = "TaskManagement_select";

        /// <summary>
        /// Select stored procedure of file Attechment PMS
        /// </summary>
        public const string FileAttchment_select = "FileAttchment_select";

        /// <summary>
        /// Delete stored procedure of task management PMS
        /// </summary>
        public const string TaskManagement_delete = "TaskManagement_delete";

        /// <summary>
        /// Insert stored procedure of Project Management PMS
        /// </summary>
        public const string SpProject_ManagementInsert = "SpProject_ManagementInsert";

        /// <summary>
        /// Select stored procedure of Project Management PMS
        /// </summary>
        public const string SpProject_ManagementSelect = "SpProject_ManagementSelect";

        /// <summary>
        /// Update stored procedure of Project Management PMS
        /// </summary>
        public const string SpProject_ManagementUpdate = "SpProject_ManagementUpdate";

        /// <summary>
        /// get next value stored procedure of Project Management
        /// </summary>
        public const string SpProjectManagementGetNextValue = "SpProjectManagementGetNextValue";

        /// <summary>
        /// Get Project id stored procedure of Project Management
        /// </summary>
        public const string SpProjectManagementGetProjectid = "SpProjectManagementGetProjectid";

        /// <summary>
        /// get data stored procedure of Project Management
        /// </summary>
        public const string SpProjectManagementGetData = "SpProjectManagementGetData";

        /// <summary>
        /// Update stored procedure of TaskManagement
        /// </summary>
        public const string TaskManagement_Update = "TaskManagement_Update";

        /// <summary>
        /// insert stored procedure of DailyWorkStatus
        /// </summary>
        public const string DailyWorkStatus_insert = "DailyWorkStatus_insert";

        /// <summary>
        /// select stored procedure of DailyWorkStatus
        /// </summary>
        public const string DailyWorkStatus_select = "DailyWorkStatus_select";

        /// <summary>
        /// GetNextValue stored procedure of TaskManagement
        /// </summary>
        public const string TaskManagement_GetNextValue = "TaskManagement_GetNextValue";

        /// <summary>
        /// Taskname stored procedure of TaskManagement
        /// </summary>
        public const string TaskManagement_TaskName = "TaskManagement_TaskName";

        /// <summary>
        /// Grid stored procedure of TaskManagement
        /// </summary>
        public const string TaskManagementGrid = "TaskManagementGrid";

        /// <summary>
        /// GetDistinctdata stored procedure of ProjectName
        /// </summary>
        public const string GetDistinctProjectName = "GetDistinctProjectName";

        /// <summary>
        /// insert stored procedure of AddIssue
        /// </summary>
        public const string AddIssue_Insert = "AddIssue_Insert";

        /// <summary>
        /// select stored procedure of AddIssue
        /// </summary>
        public const string AddIssue_select = "AddIssue_select";

        /// <summary>
        /// Grid stored procedure of AddIssue
        /// </summary>
        public const string AddIssue_Grid = "AddIssue_Grid";

        /// <summary>
        /// Getdata stored procedure of ProjectName
        /// </summary>
        public const string GetProjectName = "GetProjectName";

        /// <summary>
        /// GetDetails stored procedure of TaskManagement
        /// </summary>
        public const string TaskManagement_GetDetails = "TaskManagement_GetDetails"; 
        #endregion
    }
}