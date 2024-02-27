using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PMS
{
    public partial class AddIssueReport : DockContent
    {
        #region Veriable declare
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection Connection = new SqlConnection(AppSettings.ConnectionString);
        DataTable dtAddIssueReport;
        private SqlDataAdapter AdpAddIssueReport;
        SqlCommand cmd;
        DataTable dt;
        DataSet ds = new DataSet();

        public object AddIssueID { get; private set; }
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
        public AddIssueReport()
        {
            dtAddIssueReport = new DataTable();
            InitializeComponent();
            LoadDataIntoComboBox();
            comboProjectName.KeyPress += ComboProjectName_KeyPress;
            comboIssueType.KeyPress += ComboIssueType_KeyPress;
            comboPriority.KeyPress += ComboPriority_KeyPress;
        }
        #endregion

        #region Key Press
        /// <summary>
        /// ComboBox Priority KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboPriority_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboPriority.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// ComboBox IssueType KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboIssueType_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboIssueType.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// ComboBox ProjectName KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboProjectName.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Button Click
        /// <summary>
        /// Button Create Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string ProjectName = comboProjectName.Text;
                string IssueType = comboIssueType.Text;
                string Summary = txtSummary.Text;
                string Priority = comboPriority.Text;
                string DueDate = dateTimePickerDueDate.Text;
                string AffectsVersion = comboAffectsVersion.Text;
                string FixVersion = comboFixVersion.Text;
                string description = RichTextDescription.Text;
                string Assignee = txtAssignee.Text;
                foreach (DataGridViewRow row in DgvAddIssue.Rows)
                {
                    row.Cells["ProjectName"].Value = ProjectName;
                    row.Cells["IssueType"].Value = IssueType;
                    row.Cells["Summary"].Value = Summary;
                    row.Cells["Priority"].Value = Priority;
                    row.Cells["DueDate"].Value = DueDate;
                    row.Cells["AffectsVersion"].Value = AffectsVersion;
                    row.Cells["FixVersion"].Value = FixVersion;
                    row.Cells["description"].Value = description;
                    row.Cells["Assignee"].Value = Assignee;
                    break;
                }
                if (!AddIssueValidation())
                {
                    return;
                }
                else
                {
                    DataRow addIssueReport = dtAddIssueReport.NewRow();
                    addIssueReport[DBConst.ProjectName] = comboProjectName.Text;
                    addIssueReport[DBConst.IssueType] = comboIssueType.Text;
                    addIssueReport[DBConst.Summary] = txtSummary.Text;
                    addIssueReport[DBConst.Priority] = comboPriority.Text;
                    addIssueReport[DBConst.DueDate] = dateTimePickerDueDate.Text;
                    addIssueReport[DBConst.AffectsVersion] = comboAffectsVersion.Text;
                    addIssueReport[DBConst.FixVersion] = comboFixVersion.Text;
                    addIssueReport[DBConst.Assignee] = txtAssignee.Text;
                    addIssueReport[DBConst.Description] = RichTextDescription.Text;
                    if (DgvAddIssue.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = DgvAddIssue.SelectedRows[0];
                        selectedRow.Cells["ProjectName"].Value = comboProjectName.Text;
                        selectedRow.Cells["IssueType"].Value = comboIssueType.Text;
                        selectedRow.Cells["Summary"].Value = txtSummary.Text;
                        selectedRow.Cells["Priority"].Value = comboPriority.Text;
                        selectedRow.Cells["DueDate"].Value = dateTimePickerDueDate.Text;
                        selectedRow.Cells["AffectsVersion"].Value = comboAffectsVersion.Text;
                        selectedRow.Cells["FixVersion"].Value = comboFixVersion.Text;
                        selectedRow.Cells["Description"].Value = RichTextDescription.Text;
                        selectedRow.Cells["Assignee"].Value = txtAssignee.Text;
                        dtAddIssueReport.Rows.Add(addIssueReport);
                        AdpAddIssueReport.Update(dtAddIssueReport);
                        dtAddIssueReport.Rows.Clear();
                        AdpAddIssueReport.Fill(dtAddIssueReport);
                        LoadDatainGrid();
                        AppGlobal.CustomMessageBox.ShowMessage("Successfully Inserted", "Ok");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Button Cancel Click Event For Empty TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            comboProjectName.Text = string.Empty;
            comboIssueType.Text = string.Empty;
            txtSummary.Text = string.Empty;
            txtAssignee.Text = string.Empty;
            comboPriority.Text = string.Empty;
            comboFixVersion.Text = string.Empty;
            comboAffectsVersion.Text = string.Empty;
            RichTextDescription.Text = string.Empty;
        }
        #endregion

        #region Gridview Cellclick
        /// <summary>
        /// cellclick of datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAddIssue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvAddIssue.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult results = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (results == DialogResult.Yes)
                {
                    int AddIssueID;
                    AddIssueID = Convert.ToInt32(DgvAddIssue.Rows[e.RowIndex].Cells["AddIssueID"].Value);
                    DgvAddIssue.Rows.RemoveAt(e.RowIndex);
                    Connection.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("AddIssueDelete", Connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AddIssueID", AddIssueID);
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
            if (DgvAddIssue.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                DataGridViewRow selectedRow = DgvAddIssue.Rows[e.RowIndex];
                int AddIssueID = Convert.ToInt32(selectedRow.Cells["AddIssueID"].Value);
                string ProjectName = selectedRow.Cells["ProjectName"].Value.ToString();
                string IssueType = selectedRow.Cells["IssueType"].Value.ToString();
                string Summary = selectedRow.Cells["Summary"].Value.ToString();
                string Priority = selectedRow.Cells["Priority"].Value.ToString();
                string DueDate = selectedRow.Cells["DueDate"].Value.ToString();
                string AffectsVersion = selectedRow.Cells["AffectsVersion"].Value.ToString();
                string FixVersion = selectedRow.Cells["FixVersion"].Value.ToString();
                string Description = selectedRow.Cells["Description"].Value.ToString();
                string Assignee = selectedRow.Cells["Assignee"].Value.ToString();
                comboProjectName.Text = ProjectName;
                comboIssueType.Text = IssueType;
                txtSummary.Text = Summary;
                comboPriority.Text = Priority;
                dateTimePickerDueDate.Text = DueDate;
                comboAffectsVersion.Text = AffectsVersion;
                comboFixVersion.Text = FixVersion;
                RichTextDescription.Text = Description;
                txtAssignee.Text = Assignee;
            }
        }
        #endregion

        #region Function
        /// <summary>
        /// Load Data From Database to ProjectName ComboBox
        /// </summary>
        /// 
        private void LoadDataIntoComboBox()
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(SPConst.GetDistinctProjectName, Connection);
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            string project_Name = reader["Project_Name"].ToString();
                            comboProjectName.Items.Add(project_Name);

                        }
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load Data From Database to Datagridview Function
        /// </summary>
        private void LoadDatainGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(SPConst.AddIssue_Grid, Connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    Connection.Close();

                    /*var deleteButton = new DataGridViewButtonColumn();
                    deleteButton.Name = "Deletefromgrid";
                    deleteButton.HeaderText = "Delete";
                    deleteButton.UseColumnTextForButtonValue = true;
                    deleteButton.Text = "Delete";
                    DgvAddIssue.Columns.Add(deleteButton);

                    var EditButton = new DataGridViewButtonColumn();
                    EditButton.Name = "Editfromgrid";
                    EditButton.HeaderText = "Edit";
                    EditButton.UseColumnTextForButtonValue = true;
                    EditButton.Text = "Edit";
                    DgvAddIssue.Columns.Add(EditButton);*/
                    DgvAddIssue.DataSource = dt;
                }                
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message, "Error"); ;
            }
        }

        /// <summary>
        /// Fill Data Function
        /// </summary>
        void FillData()
        {
            try
            {
                AdpAddIssueReport = new SqlDataAdapter();
                AdpAddIssueReport.SelectCommand = ClientMethod.AddIssue_Select();
                AdpAddIssueReport.InsertCommand = ClientMethod.AddIssue_Insert();
                dtAddIssueReport = new DataTable();
                dtAddIssueReport.TableName = TableConst.AddIssueReport;
                AdpAddIssueReport.Fill(dtAddIssueReport);
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message, "Error");
            }
        }

        /// <summary>
        /// load event for AddIssueReport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIssueReport_Load(object sender, EventArgs e)
        {
            LoadDatainGrid();
            FillData();
        } 
        #endregion

        #region Validation
        /// <summary>
        /// AddIssue Validation Function
        /// </summary>
        /// <returns></returns>
        private bool AddIssueValidation()
        {
            try
            {
                ErrorProvider errorProvider = new ErrorProvider();
                ErpProjectName.Clear();
                ErpIssueType.Clear();
                ErpSummary.Clear();
                ErpPriority.Clear();
                ErpDueDate.Clear();
                ErpAffectsVersion.Clear();
                ErpFixVersion.Clear();
                ErpAssignee.Clear();
                ErpDesc.Clear();
                bool valid = true;

                if (string.IsNullOrEmpty(comboProjectName.Text))
                {
                    ErpProjectName.SetError(comboProjectName, "Please Select the Project Name");
                    valid = false;
                    comboProjectName.Focus();
                }
                if (string.IsNullOrEmpty(comboIssueType.Text))
                {
                    ErpIssueType.SetError(comboIssueType, "Please Select the Priority");
                    valid = false;
                    comboIssueType.Focus();
                }
                if (string.IsNullOrEmpty(txtSummary.Text))
                {
                    ErpSummary.SetError(txtSummary, "Please Write The Summary");
                    valid = false;
                    txtSummary.Focus();
                }
                if (string.IsNullOrEmpty(comboPriority.Text))
                {
                    ErpPriority.SetError(comboPriority, "Please Select the Priority");
                    valid = false;
                    comboPriority.Focus();
                }
                if (string.IsNullOrEmpty(comboAffectsVersion.Text))
                {
                    ErpAffectsVersion.SetError(comboAffectsVersion, "Please Select the AffectVersion");
                    valid = false;
                    comboAffectsVersion.Focus();
                }
                if (string.IsNullOrEmpty(comboFixVersion.Text))
                {
                    ErpFixVersion.SetError(comboFixVersion, "Please Select the Fix Version");
                    valid = false;
                    comboFixVersion.Focus();
                }
                if (string.IsNullOrEmpty(txtAssignee.Text))
                {
                    ErpAssignee.SetError(txtAssignee, "Please Write Assignee");
                    valid = false;
                    txtAssignee.Focus();
                }
                if (string.IsNullOrEmpty(RichTextDescription.Text))
                {
                    ErpDesc.SetError(RichTextDescription, "Please Write the Description");
                    valid = false;
                    RichTextDescription.Focus();
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
            catch (Exception)
            {
                throw;
            }
        }
        #endregion               
    }
}