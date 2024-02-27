using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PMS
{
    public partial class TaskManagement : DockContent
    {
        #region connection and variable declare
        /// <summary>
        /// Global variable Declaration and Connection
        /// </summary>
        private DataTable DtTaskManagement;
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection Connection = new SqlConnection(AppSettings.ConnectionString);
        private SqlDataAdapter adpTaskManagement;
        private DataTable Datatable;

        public bool Valid { get; private set; }
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

        #region Subscribe Component
        public TaskManagement()
        {
            InitializeComponent();
            DtTaskManagement = new DataTable();
            ProjectComboBox();
            ComboTaskid();
            txtTaskname.Enabled = false;
            btnAddNew.Click += BtnAddnew_Click;
            comboProjectID.KeyPress += ComboProjectID_KeyPress;
            comboTaskType.KeyPress += ComboTaskType_KeyPress;
            dataGridViewTaskInfo.CellClick += DataGridViewTaskInfo_CellClick;
            cmbTaskId.SelectedIndexChanged += ComboTaskid_SelectedIndexChanged;
            comboProjectID.SelectedIndexChanged += ComboProjectID_SelectedIndexChanged;
            cmbTaskId.KeyPress += ComboTaskid_KeyPress;
        }
        #endregion

        #region Form Load
        /// <summary>
        /// TaskManagement Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskManagement_Load(object sender, EventArgs e)
        {
            ButtonGrid();
            GridButton();
            try
            {
                adpTaskManagement = new SqlDataAdapter();
                adpTaskManagement.SelectCommand = ClientMethod.TaskManagement_select();
                adpTaskManagement.InsertCommand = ClientMethod.TaskManagement_insert();
                DtTaskManagement = new DataTable();
                DtTaskManagement.TableName = TableConst.TaskManagement;
                adpTaskManagement.Fill(DtTaskManagement);
                dataGridViewTaskInfo.DataSource = DtTaskManagement = LoadTaskManger();
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {ex.Message}", "ErrorMessage");
            }
            UpdateDataSaveClick();          
        }

       
        #endregion

        #region Grid CellClick
        /// <summary>
        /// cellClick to Fetch textbox data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewTaskInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewTaskInfo.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult results = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (results == DialogResult.Yes)
                {
                    int Project_ID;
                    Project_ID = Convert.ToInt32(dataGridViewTaskInfo.Rows[e.RowIndex].Cells["Project_ID"].Value);
                    dataGridViewTaskInfo.Rows.RemoveAt(e.RowIndex);
                    Connection.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("TaskManagementDelete", Connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Project_ID", Project_ID);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Successful Deleted");
                        }
                        else
                        {
                            MessageBox.Show("Data Not Deleted");

                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                    finally
                    {
                        Connection.Close();
                    }
                }
            }
            if (dataGridViewTaskInfo.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                DataGridViewRow selectedRow = dataGridViewTaskInfo.Rows[e.RowIndex];
                int Project_ID = Convert.ToInt32(selectedRow.Cells["Project_ID"].Value);
                int Task_ID = Convert.ToInt32(selectedRow.Cells["Task_ID"].Value);
                string Project = selectedRow.Cells["Project"].Value.ToString();
                string TaskName = selectedRow.Cells["TaskName"].Value.ToString();
                string Description = selectedRow.Cells["Description"].Value.ToString();
                string Owner = selectedRow.Cells["Owner"].Value.ToString();
                string Status = selectedRow.Cells["Status"].Value.ToString();
                string StartDate = selectedRow.Cells["StartDate"].Value.ToString();
                string CompletionDate = selectedRow.Cells["CompletionDate"].Value.ToString();
                string TaskType = selectedRow.Cells["TaskType"].Value.ToString();
                comboProjectID.Text = Convert.ToString(Project_ID);
                cmbTaskId.Text = Convert.ToString(Task_ID);
                txtProject.Text = Project;
                txtTaskname.Text = TaskName;
                richTxtDesc.Text = Description;
                ComboOwner.Text = Owner;
                ComboStatus.Text = Status;
                dateTimePickerStartDate.Text = StartDate;
                dateTimePickerComplitionDate.Text = CompletionDate;
                comboTaskType.Text = TaskType;
            }
        }
        #endregion

        #region Button Click event
        /// <summary>
        /// Add New ID 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddnew_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            ClearInput();
            cmbTaskId.Enabled = false;
            int nextId = NextId();
            cmbTaskId.Items.Add(nextId);
            cmbTaskId.SelectedItem = (nextId);
            txtTaskname.Enabled = true;
            txtTaskname.Text = "";
        }

        /// <summary>
        /// Click Cancel Button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
            cmbTaskId.Items.Clear();
            ComboTaskid();
            BtnSave.Enabled = false;
        }

        /// <summary>
        /// Button Save 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Project = txtProject.Text;
                string TaskName = txtTaskname.Text;
                string Description = richTxtDesc.Text;
                string Owner = ComboOwner.Text;
                string Status = ComboStatus.Text;
                string StartDate = dateTimePickerStartDate.Text;
                string CompletionDate = dateTimePickerComplitionDate.Text;
                string TaskType = comboTaskType.Text;
                foreach (DataGridViewRow row in dataGridViewTaskInfo.Rows)
                {
                    row.Cells["Project"].Value = Project;
                    row.Cells["TaskName"].Value = TaskName;
                    row.Cells["Description"].Value = Description;
                    row.Cells["Owner"].Value = Owner;
                    row.Cells["Status"].Value = Status;
                    row.Cells["StartDate"].Value = StartDate;
                    row.Cells["CompletionDate"].Value = CompletionDate;
                    row.Cells["TaskType"].Value = TaskType;
                    break;
                }
                if (!TaskMvalidation())
                {
                    return;
                }
                else
                {
                    if (cmbTaskId.Enabled == false)
                    {
                        DataRow taskManagement = DtTaskManagement.NewRow();
                        taskManagement[DBConst.Project] = txtProject.Text;
                        taskManagement[DBConst.TaskName] = txtTaskname.Text;
                        taskManagement[DBConst.Description] = richTxtDesc.Text;
                        taskManagement[DBConst.Owner] = ComboOwner.Text;
                        taskManagement[DBConst.Status] = ComboStatus.Text;
                        taskManagement[DBConst.TaskType] = comboTaskType.Text;
                        taskManagement[DBConst.StartDate] = dateTimePickerStartDate.Text;
                        taskManagement[DBConst.CompletionDate] = dateTimePickerComplitionDate.Text;
                        taskManagement[DBConst.Project_ID] = comboProjectID.Text;
                        taskManagement[DBConst.Task_ID] = cmbTaskId.Text;
                        DtTaskManagement.Rows.Add(taskManagement);
                        adpTaskManagement.Update(DtTaskManagement);
                        DtTaskManagement.Rows.Clear();
                        adpTaskManagement.Fill(DtTaskManagement);

                        DataTable dt = LoadTaskManger();
                        dataGridViewTaskInfo.DataSource = dt;
                        dataGridViewTaskInfo.Columns[0].HeaderText = "Project";
                        dataGridViewTaskInfo.Columns[1].HeaderText = "TaskName";
                        dataGridViewTaskInfo.Columns[2].HeaderText = "Description";
                        dataGridViewTaskInfo.Columns[3].HeaderText = "Oner";
                        dataGridViewTaskInfo.Columns[4].HeaderText = "Status";
                        dataGridViewTaskInfo.Columns[5].HeaderText = "StartDate";
                        dataGridViewTaskInfo.Columns[6].HeaderText = "CompletionDate";
                        dataGridViewTaskInfo.Columns[7].HeaderText = "Task_ID";
                        dataGridViewTaskInfo.Columns[8].HeaderText = "TaskType";
                        dataGridViewTaskInfo.Columns[9].HeaderText = "Project_ID";
                    }
                    else
                    {
                        DataRow taskManagement = DtTaskManagement.NewRow();
                        taskManagement[DBConst.Project] = txtProject.Text;
                        taskManagement[DBConst.TaskName] = txtTaskname.Text;
                        taskManagement[DBConst.Description] = richTxtDesc.Text;
                        taskManagement[DBConst.Owner] = ComboOwner.Text;
                        taskManagement[DBConst.Status] = ComboStatus.Text;
                        taskManagement[DBConst.TaskType] = comboTaskType.Text;
                        taskManagement[DBConst.StartDate] = dateTimePickerStartDate.Text;
                        taskManagement[DBConst.CompletionDate] = dateTimePickerComplitionDate.Text;
                        taskManagement[DBConst.Project_ID] = comboProjectID.Text;
                        taskManagement[DBConst.Task_ID] = cmbTaskId.Text;
                        DtTaskManagement.Rows.Add(taskManagement);
                        adpTaskManagement.Update(DtTaskManagement);
                        DtTaskManagement.Rows.Clear();
                        adpTaskManagement.Fill(DtTaskManagement);

                        DataTable dt = LoadTaskManger();
                        dataGridViewTaskInfo.DataSource = dt;
                        dataGridViewTaskInfo.Columns[0].HeaderText = "Project";
                        dataGridViewTaskInfo.Columns[1].HeaderText = "TaskName";
                        dataGridViewTaskInfo.Columns[2].HeaderText = "Description";
                        dataGridViewTaskInfo.Columns[3].HeaderText = "Oner";
                        dataGridViewTaskInfo.Columns[4].HeaderText = "Status";
                        dataGridViewTaskInfo.Columns[5].HeaderText = "StartDate";
                        dataGridViewTaskInfo.Columns[6].HeaderText = "CompletionDate";
                        dataGridViewTaskInfo.Columns[7].HeaderText = "Task_ID";
                        dataGridViewTaskInfo.Columns[8].HeaderText = "TaskType";
                        dataGridViewTaskInfo.Columns[9].HeaderText = "Project_ID";
                        UpdateDataSaveClick();
                    }
                }
                Cancel();
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {ex.Message}", "ErrorMessage");
            }
        }
        #endregion

        #region Combobox selected index change event
        /// <summary>
        /// Select Project Id From Database to comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            try
            {
                string selectedID = comboProjectID.SelectedItem.ToString();
                SqlConnection connection = new SqlConnection(AppSettings.ConnectionString);
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SPConst.GetProjectName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProjectID", selectedID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtProject.Text = reader["Project_Name"].ToString();
                    }
                    else
                    {
                        txtProject.Text = string.Empty;
                    }
                    connection.Close();
                }
                cmbTaskId.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// combotaskid index change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboTaskid_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            try
            {
                string selectedID = cmbTaskId.SelectedItem.ToString();
                SqlConnection connection = new SqlConnection(AppSettings.ConnectionString);
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SPConst.TaskManagement_GetDetails, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TaskID", selectedID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTaskname.Text = reader[DBConst.TaskName].ToString();
                        comboTaskType.Text = reader[DBConst.TaskType].ToString();
                        richTxtDesc.Text = reader[DBConst.Description].ToString();
                        ComboOwner.Text = reader[DBConst.Owner].ToString();
                        ComboStatus.Text = reader[DBConst.Status].ToString();
                        dateTimePickerStartDate.Text = reader[DBConst.StartDate].ToString();
                        dateTimePickerComplitionDate.Text = reader[DBConst.CompletionDate].ToString();
                    }
                    else
                    {
                        txtTaskname.Text = string.Empty;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {ex.Message}", "ErrorMessage");
            }
        } 
        #endregion

        #region Keypress event of combobox
        /// <summary>
        /// combotaskid keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboTaskid_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbTaskId.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// key press event of task tyape combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboTaskType_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboStatus.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// KeyPress Event For ProjectId comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboProjectID_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboProjectID.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Key Press Event For ComboBox status can not allow any key press 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboStatus.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Private function
        /// <summary>
        /// fuction Clear Input
        /// </summary>
        private void ClearInput()
        {
            txtTaskname.Text = string.Empty;
            richTxtDesc.Text = string.Empty;
            ComboOwner.Text = string.Empty;
            ComboStatus.Text = string.Empty;
            comboTaskType.Text = string.Empty;
        }

        /// <summary>
        /// Load data TaskManagement
        /// </summary>
        /// <returns></returns>
        private static DataTable LoadTaskManger()
        {
            SqlCommand cmd = new SqlCommand("TaskManagement_select", Connection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Validation before submit button
        /// </summary>
        /// <returns></returns>
        public bool TaskMvalidation()
        {
            var errorProvider = new ErrorProvider();
            errorProviderTaskName.Clear();
            errorProviderDescription.Clear();
            errorProviderOwner.Clear();
            errorProviderStatus.Clear();
            errorProviderTaskType.Clear();
            errorProviderSD.Clear();
            errorProviderCD.Clear();
            errorProviderProjectId.Clear();
            errorProviderTaskID.Clear();
            bool valid = true;
            if (string.IsNullOrEmpty(txtTaskname.Text))
            {
                errorProviderTaskName.SetError(txtTaskname, "Please Enter the TaskName");
                Valid = false;
                txtTaskname.Focus();
            }
            if (string.IsNullOrEmpty(richTxtDesc.Text))
            {
                errorProviderDescription.SetError(richTxtDesc, "Please Enter the Description");
                Valid = false;
                richTxtDesc.Focus();
            }
            if (string.IsNullOrEmpty(ComboOwner.Text))
            {
                errorProviderOwner.SetError(ComboOwner, "Please Enter the Owner");
                Valid = false;
                ComboOwner.Focus();
            }
            if (string.IsNullOrEmpty(ComboStatus.Text))
            {
                errorProviderStatus.SetError(ComboStatus, "Please Select the Status");
                Valid = false;
                ComboStatus.Focus();
            }
            if (string.IsNullOrEmpty(comboTaskType.Text))
            {
                errorProviderTaskType.SetError(comboTaskType, "Please Select the TaskType");
                Valid = false;
                comboTaskType.Focus();
            }
            if (string.IsNullOrEmpty(dateTimePickerStartDate.Text))
            {
                errorProviderSD.SetError(dateTimePickerStartDate, "Please Select the StartDate");
                Valid = false;
                dateTimePickerStartDate.Focus();
            }
            if (string.IsNullOrEmpty(dateTimePickerComplitionDate.Text))
            {
                errorProviderCD.SetError(dateTimePickerComplitionDate, "Please Select Complete Date");
                Valid = false;
                dateTimePickerComplitionDate.Focus();
            }
            if (string.IsNullOrEmpty(cmbTaskId.Text))
            {
                errorProviderTaskID.SetError(cmbTaskId, "please select task id");
                valid = false;
                cmbTaskId.Focus();
            }
            if (string.IsNullOrEmpty(comboProjectID.Text))
            {
                errorProviderProjectId.SetError(comboProjectID, "please select project id");
                valid = false;
                comboProjectID.Focus();
            }
            if (!valid)
            {
                return false;
            }
            else
            {
                return valid;
            }
        }

        /// <summary>
        /// Updatedata 
        /// </summary>
        private void UpdateDataSaveClick()
        {
            try
            {
                adpTaskManagement = new SqlDataAdapter();
                adpTaskManagement.SelectCommand = ClientMethod.TaskManagement_select();
                adpTaskManagement.InsertCommand = ClientMethod.TaskManagement_Update();
                DtTaskManagement = new DataTable();
                DtTaskManagement.TableName = TableConst.TaskManagement;
                adpTaskManagement.Fill(DtTaskManagement);
                dataGridViewTaskInfo.DataSource = DtTaskManagement = LoadTaskManger();
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {ex.Message}", "ErrorMessage");
            }
        }

        /// <summary>
        /// project combobox for project name
        /// </summary>
        private void ProjectComboBox()
        {
            try
            {
                SqlConnection connection = new SqlConnection(AppSettings.ConnectionString);
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GetDistinctProjectID", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboProjectID.Items.Add(reader["Project_ID"].ToString());
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fill Task_ID Database to comboBox
        /// </summary>
        private void ComboTaskid()
        {
            try
            {
                SqlConnection connection = new SqlConnection(AppSettings.ConnectionString);
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GetDistinctTaskID", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbTaskId.Items.Add(reader["Task_ID"].ToString());
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Get Next Task ID
        /// </summary>
        /// <returns></returns>
        private int NextId()
        {

            try
            {
                SqlConnection connection = new SqlConnection(AppSettings.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("TaskManagement_GetNextValue", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter returnValue = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                int nextTask_ID = (int)returnValue.Value;
                connection.Close();
                return nextTask_ID;
            }
            catch (Exception ex)
            {
                Connection.Close();
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        /// <summary>
        /// Update to Return 1
        /// </summary>
        /// <returns></returns>
        private int GetRecordIdToUpdate()
        {
            return 1;
        }

        /// <summary>
        /// KeyPress  Event For TaskType ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///  /// <summary>
        /// Cancel button function
        /// </summary>
        private void Cancel()
        {
            txtProject.Text = string.Empty;
            txtTaskname.Text = string.Empty;
            richTxtDesc.Text = string.Empty;
            ComboOwner.Text = string.Empty;
            ComboStatus.Text = string.Empty;
            comboTaskType.Text = string.Empty;
            comboProjectID.Text = string.Empty;
            cmbTaskId.Text = string.Empty;
            cmbTaskId.Enabled = true;
        }

        /// <summary>
        /// function for edit and delete in grid view
        /// </summary>
        private void GridButton()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(SPConst.TaskManagement_select, Connection);
                command.CommandType = CommandType.StoredProcedure;
                Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                Connection.Close();
                dataGridViewTaskInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message, "Error"); ;
            }
        }

        /// <summary>
        /// function for add button in grid
        /// </summary>
        private void ButtonGrid()
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Deletefromgrid";
            deleteButton.HeaderText = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            dataGridViewTaskInfo.Columns.Add(deleteButton);

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "Editfromgrid";
            EditButton.HeaderText = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            EditButton.Text = "Edit";
            dataGridViewTaskInfo.Columns.Add(EditButton);
        }
        #endregion        
    }
}