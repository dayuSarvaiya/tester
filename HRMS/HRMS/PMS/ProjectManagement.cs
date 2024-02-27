using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ProjectManagement
{
    public partial class Project_ManagementForm : DockContent
    {
        #region connection
        /// <summary>
        /// Connection string
        /// </summary>
        public static AppSetting AppSetting = new AppSetting();
        public static SqlConnection Connection = new SqlConnection(AppSetting.ConnectionString);

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

        #region initialization
        /// <summary>
        /// initialization
        /// </summary>
        public Project_ManagementForm()
        {
            InitializeComponent();
            this.Load += Project_ManagementForm_Load;
            btnAdd.Click += BtnAdd_Click;
            btnReset.Click += BtnReset_Click;
            btnSave.Click += BtnSave_Click;
            cmbProjectId.SelectedIndexChanged += CmbProjectId_SelectedIndexChanged;
            txtProjectName.KeyPress += TxtProjectName_KeyPress;
            txtManagerName.KeyPress += TxtManagerName_KeyPress;
            dataGridViewProjectManagement.CellClick += DataGridViewProjectManagement_CellClick;
            EnableFalse();
            ButtonGrid();
        }

        private void DataGridViewProjectManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewProjectManagement.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult results = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (results == DialogResult.Yes)
                {
                    int Project_ID;
                    Project_ID = Convert.ToInt32(dataGridViewProjectManagement.Rows[e.RowIndex].Cells["Project_ID"].Value);
                    dataGridViewProjectManagement.Rows.RemoveAt(e.RowIndex);
                    Connection.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("ProjectManagementDelete", Connection);
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
            if (dataGridViewProjectManagement.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                DataGridViewRow selectedRow = dataGridViewProjectManagement.Rows[e.RowIndex];
                int Project_ID = Convert.ToInt32(selectedRow.Cells["Project_ID"].Value);
                string Project_Name = selectedRow.Cells["Project_Name"].Value.ToString();
                string Manager_Name = selectedRow.Cells["Manager_Name"].Value.ToString();
                string StartDate = selectedRow.Cells["StartDate"].Value.ToString();
                string Expected_EndDate = selectedRow.Cells["Expected_EndDate"].Value.ToString();
                string Actual_EndDate = selectedRow.Cells["Actual_EndDate"].Value.ToString();
                string Technology = selectedRow.Cells["Technology"].Value.ToString();
                string Required_Tools = selectedRow.Cells["Required_Tools"].Value.ToString();
                string Description = selectedRow.Cells["Description"].Value.ToString();
                cmbProjectId.Text=Convert.ToString(Project_ID);
                txtProjectName.Text = Project_Name;
                txtManagerName.Text = Manager_Name;
                dateTimePickerStartDate.Text = StartDate;
                dateTimePickerEndDate.Text = Expected_EndDate;
                dateTimePickerActualEnddate.Text = Actual_EndDate;
                txtTechnology.Text = Technology;
                richtxtRequiredTools.Text = Required_Tools;
                richtxtDescription.Text = Description;
            }
        }
        #endregion

        #region formload buttonclick event and other events
        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Project_ManagementForm_Load(object sender, EventArgs e)
        {
            cmbProjectId.Enabled = true;
            LoadComboBoxData();
            LoadDatainGrid();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnSave, "Click me to execute.");
        }

        #region Button click 
        /// <summary>
        /// save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation_Project())
                {
                    return;
                }
                else
                {
                    if (cmbProjectId.Enabled == false)
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(SPConst.SpProject_ManagementInsert, Connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(DBConst.Project_Name, txtProjectName.Text);
                        cmd.Parameters.AddWithValue(DBConst.Manager_Name, txtManagerName.Text);
                        cmd.Parameters.AddWithValue(DBConst.Startdate, dateTimePickerStartDate.Text);
                        cmd.Parameters.AddWithValue(DBConst.Expected_EndDate, dateTimePickerEndDate.Text);
                        cmd.Parameters.AddWithValue(DBConst.Actual_EndDate, dateTimePickerActualEnddate.Text);
                        cmd.Parameters.AddWithValue(DBConst.Technology, txtTechnology.Text);
                        cmd.Parameters.AddWithValue(DBConst.Required_Tools, richtxtRequiredTools.Text);
                        cmd.Parameters.AddWithValue(DBConst.Description, richtxtDescription.Text);
                        SqlDataReader sqlDataReader = cmd.ExecuteReader();
                        AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for Record Inserted", "Information");
                        Connection.Close();
                        LoadDatainGrid();
                        Reset();
                        EnableFalse();
                    }
                    else
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(SPConst.SpProject_ManagementUpdate, Connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(DBConst.Project_Id, cmbProjectId.Text);
                        cmd.Parameters.AddWithValue(DBConst.Project_Name, txtProjectName.Text);
                        cmd.Parameters.AddWithValue(DBConst.Manager_Name, txtManagerName.Text);
                        cmd.Parameters.AddWithValue(DBConst.Startdate, dateTimePickerStartDate.Text);
                        cmd.Parameters.AddWithValue(DBConst.Expected_EndDate, dateTimePickerEndDate.Text);
                        cmd.Parameters.AddWithValue(DBConst.Actual_EndDate, dateTimePickerActualEnddate.Text);
                        cmd.Parameters.AddWithValue(DBConst.Technology, txtTechnology.Text);
                        cmd.Parameters.AddWithValue(DBConst.Required_Tools, richtxtRequiredTools.Text);
                        cmd.Parameters.AddWithValue(DBConst.Description, richtxtDescription.Text);
                        SqlDataReader sqlDataReader = cmd.ExecuteReader();
                        AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for Record Updated", "Information");
                        Connection.Close();
                        LoadDatainGrid();
                        Reset();
                        EnableFalse();
                    }
                    return;
                }
            }
            catch (SqlException ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {ex.Message}", "ErrorMessage");
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {ex.Message}", "ErrorMessage");
            }
        }

        /// <summary>
        /// reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
            cmbProjectId.Enabled = true;
            EnableFalse();
            cmbProjectId.Items.Clear();
            LoadComboBoxData();
        }

        /// <summary>
        /// add new click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            cmbProjectId.Enabled = false;
            Enabletrue();
            int nextId = GetNextId();
            cmbProjectId.Items.Add(nextId);
            cmbProjectId.SelectedItem = (nextId);
        }
        #endregion

        #region keypress event of textbox
        /// <summary>
        /// keypress event of txtManagerName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtManagerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypresstxt(e);
        }

        /// <summary>
        /// keypress event txtProject_Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypresstxt(e);
        }
        #endregion

        /// <summary>
        /// select id in combobox and retrieve data from table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbProjectId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Enabletrue();
                Connection.Open();
                if (!string.IsNullOrWhiteSpace(cmbProjectId.Text))
                {
                    SqlCommand cmd = new SqlCommand(SPConst.SpProjectManagementGetData, Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(DBConst.Project_Id, Convert.ToInt32(cmbProjectId.Text));
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        txtProjectName.Text = dataReader[DBConst.Project_Name].ToString();
                        txtManagerName.Text = dataReader[DBConst.Manager_Name].ToString();
                        dateTimePickerStartDate.Text = dataReader[DBConst.Startdate].ToString();
                        dateTimePickerEndDate.Text = dataReader[DBConst.Expected_EndDate].ToString();
                        dateTimePickerActualEnddate.Text = dataReader[DBConst.Actual_EndDate].ToString();
                        txtTechnology.Text = dataReader[DBConst.Technology].ToString();
                        richtxtRequiredTools.Text = dataReader[DBConst.Required_Tools].ToString();
                        richtxtDescription.Text = dataReader[DBConst.Description].ToString();
                    }
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region functions
        /// <summary>
        /// reset 
        /// </summary>
        private void Reset()
        {
            try
            {
                cmbProjectId.SelectedIndexChanged -= CmbProjectId_SelectedIndexChanged;
                cmbProjectId.SelectedIndex = -1;
                cmbProjectId.SelectedIndexChanged += CmbProjectId_SelectedIndexChanged;
                txtProjectName.Text = "";
                txtManagerName.Text = "";
                dateTimePickerStartDate.Text = "";
                dateTimePickerEndDate.Text = "";
                dateTimePickerActualEnddate.Text = "";
                txtTechnology.Text = "";
                richtxtRequiredTools.Text = "";
                richtxtDescription.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// textbox validation 
        /// </summary>
        /// <returns></returns>
        private bool Validation_Project()
        {
            var errorProvider = new ErrorProvider();
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            errorProvider.Clear();
            bool valid = true;
            DateTime fromdate = Convert.ToDateTime(dateTimePickerStartDate.Text);
            DateTime todate = Convert.ToDateTime(dateTimePickerEndDate.Text);
            DateTime actualtodate = Convert.ToDateTime(dateTimePickerActualEnddate.Text);
            if (string.IsNullOrEmpty(cmbProjectId.Text))
            {
                errorProvider3.SetError(cmbProjectId, "Projectid is required");
                valid = false;
                cmbProjectId.Focus();
            }
            if (string.IsNullOrEmpty(txtProjectName.Text))
            {
                errorProvider1.SetError(txtProjectName, "ProjectName is required");
                valid = false;
                txtProjectName.Focus();
            }
            if (string.IsNullOrEmpty(txtManagerName.Text))
            {
                errorProvider2.SetError(txtManagerName, "ManagerName is required");
                valid = false;
                txtManagerName.Focus();
            }
            if (string.IsNullOrEmpty(txtTechnology.Text))
            {
                errorProvider4.SetError(txtTechnology, "Technology is required");
                valid = false;
                txtTechnology.Focus();
            }
            if (string.IsNullOrEmpty(txtTechnology.Text))
            {
                errorProvider5.SetError(richtxtRequiredTools, "required tools is required");
                valid = false;
                richtxtRequiredTools.Focus();
            }
            if (string.IsNullOrEmpty(txtTechnology.Text))
            {
                errorProvider6.SetError(richtxtDescription, "Technology is required");
                valid = false;
                richtxtDescription.Focus();
            }
            if (fromdate < todate && fromdate < actualtodate)
            {
                TimeSpan timeSpan = todate.Subtract(fromdate);
            }
            else
            {
                errorProvider7.SetError(dateTimePickerStartDate, "start date must be less and not equal to end date and actual end date");
                valid = false;
                dateTimePickerStartDate.Focus();
            }

            DateTime enddate = Convert.ToDateTime(dateTimePickerEndDate.Text);
            DateTime actualenddate = Convert.ToDateTime(dateTimePickerActualEnddate.Text);
            if (enddate <= actualenddate)
            {
                TimeSpan timeSpan = enddate.Subtract(actualenddate);
            }
            else
            {
                errorProvider8.SetError(dateTimePickerActualEnddate, "Actual end date must be greater then Expected end date");
                valid = false;
                dateTimePickerActualEnddate.Focus();
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
        /// Load data in data grid view
        /// </summary>
        private void LoadDatainGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(SPConst.SpProject_ManagementSelect, Connection);
                command.CommandType = CommandType.StoredProcedure;
                Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                Connection.Close();
                dataGridViewProjectManagement.DataSource = dt;
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {ex.Message}", "ErrorMessage");
            }
        }

        private void ButtonGrid()
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dataGridViewProjectManagement.Columns.Add(deleteButton);

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "dataGridViewDeleteButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.dataGridViewProjectManagement.Columns.Add(EditButton);
        }

        /// <summary>
        /// load all data from database table
        /// </summary>
        /// <returns></returns>
        private DataTable LoadDataFromDatabase()
        {
            DataTable dataTable = new DataTable();
            Connection.Open();
            SqlCommand command = new SqlCommand(SPConst.SpProjectManagementGetProjectid, Connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            Connection.Close();
            return dataTable;
        }

        /// <summary>
        /// retrieve project id data in combobox
        /// </summary>
        private void LoadComboBoxData()
        {
            try
            {
                DataTable dataTable = LoadDataFromDatabase();
                cmbProjectId.Items.Clear();
                cmbProjectId.SelectedText.ToString();
                foreach (DataRow row in dataTable.Rows)
                {
                    int itemId = Convert.ToInt32(row[DBConst.Project_Id]);
                    cmbProjectId.Items.Add(itemId);
                }
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Leave requested for {ex.Message}", "ErrorMessage");
            }
        }

        /// <summary>
        /// to get next value 
        /// </summary>
        /// <returns></returns>
        private int GetNextId()
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(SPConst.SpProjectManagementGetNextValue, Connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter returnValue = command.Parameters.Add(DBConst.Returnvalue, SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                int nextProjectId = (int)returnValue.Value;
                Connection.Close();
                return nextProjectId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// enable true button and textbox
        /// </summary>
        private void Enabletrue()
        {
            txtProjectName.Enabled = true;
            txtManagerName.Enabled = true;
            txtTechnology.Enabled = true;
            dateTimePickerStartDate.Enabled = true;
            dateTimePickerEndDate.Enabled = true;
            dateTimePickerActualEnddate.Enabled = true;
            richtxtRequiredTools.Enabled = true;
            richtxtDescription.Enabled = true;
            btnSave.Enabled = true;
            btnReset.Enabled = true;
        }

        /// <summary>
        /// enable false button and textbox
        /// </summary>
        private void EnableFalse()
        {
            txtProjectName.Enabled = false;
            txtManagerName.Enabled = false;
            txtTechnology.Enabled = false;
            dateTimePickerStartDate.Enabled = false;
            dateTimePickerEndDate.Enabled = false;
            dateTimePickerActualEnddate.Enabled = false;
            richtxtRequiredTools.Enabled = false;
            richtxtDescription.Enabled = false;
            btnSave.Enabled = false;
            btnReset.Enabled = false;
        }

        /// <summary>
        /// keypress function of textbox
        /// </summary>
        /// <param name="e"></param>
        private static void Keypresstxt(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}