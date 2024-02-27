using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectManagement
{
    public partial class Project_ManagementForm : Form
    {
        private int newIdCounter = 11;

        public Project_ManagementForm()
        {
            InitializeComponent();

            this.Load += Project_ManagementForm_Load;
            cmbProjectId.Click += CmbProjectId_Click;
           
            EnableFalse();


        }
        private void CmbProjectId_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// DBconnect class
        /// </summary>
        class DBConnect
        {
            public static SqlConnection myCon = new SqlConnection("Data Source=192.168.2.6,49111;Initial Catalog=HC&PMS;User id=sa;password=Sa@1234");

            //public void CreateConnection()
            //{
            //    myCon = new SqlConnection("Data Source=192.168.2.6,49111;Initial Catalog=HC&PMS;User id=sa;password=Sa@1234");
            //    myCon.Open();
            //}
        }

        #region button click
        /// <summary>
        /// save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
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
                        InsertData();
                    }
                    else
                    {
                        UpdateData();
                    }
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            cmbProjectId.Enabled = true;
            EnableFalse();
        }

        /// <summary>
        /// add new click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            cmbProjectId.Enabled = false;
            Enabletrue();
            //LoadComboBoxData();
            int nextId = GetNextId();
            cmbProjectId.Items.Add(nextId);
            cmbProjectId.SelectedItem = (nextId);


        }
        #endregion

        #region functions
        /// <summary>
        /// to insert data in table
        /// </summary>
        private void InsertData()
        {
            try
            {
                SqlConnection con = DBConnect.myCon;
                con.Open();
                SqlCommand cmd = new SqlCommand("SpProject_ManagementInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Project_Name", txtProjectName.Text);
                cmd.Parameters.AddWithValue("@Manager_Name", txtManagerName.Text);  
                cmd.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Text);
                cmd.Parameters.AddWithValue("@ExpectedEndDate", dateTimePickerEndDate.Text);
                cmd.Parameters.AddWithValue("@Actual_EndDate", dateTimePickerActualEnddate.Text);
                cmd.Parameters.AddWithValue("@Technology", txtTechnology.Text);
                cmd.Parameters.AddWithValue("@Required_Tools", richtxtRequiredTools.Text);
                cmd.Parameters.AddWithValue("@Description", richtxtDescription.Text);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Insert operation completed!");
                cmbProjectId.Enabled = true;
                Reset();
                EnableFalse();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// to update data in table
        /// </summary>
        private void UpdateData()
        {
            try
            {

                SqlConnection con = DBConnect.myCon;
                con.Open();
                SqlCommand cmd = new SqlCommand("SpProject_ManagementUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Project_Id", cmbProjectId.Text);
                cmd.Parameters.AddWithValue("@Project_Name", txtProjectName.Text);
                cmd.Parameters.AddWithValue("@Manager_Name", txtManagerName.Text);

                cmd.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Text);
                cmd.Parameters.AddWithValue("@ExpectedEndDate", dateTimePickerEndDate.Text);
                cmd.Parameters.AddWithValue("@Actual_EndDate", dateTimePickerActualEnddate.Text);
                cmd.Parameters.AddWithValue("@Technology", txtTechnology.Text);
                cmd.Parameters.AddWithValue("@Required_Tools", richtxtRequiredTools.Text);
                cmd.Parameters.AddWithValue("@Description", richtxtDescription.Text);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Update operation completed!");
                Reset();

                EnableFalse();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// reset 
        /// </summary>
        private void Reset()
        {
            //            cmbProjectId.Text="";
            cmbProjectId.SelectedIndexChanged -= cmbProjectId_SelectedIndexChanged;
            cmbProjectId.SelectedIndex = -1;
            cmbProjectId.SelectedIndexChanged += cmbProjectId_SelectedIndexChanged;
            txtProjectName.Text = "";
            txtManagerName.Text = "";
            dateTimePickerStartDate.Text = "";
            dateTimePickerEndDate.Text = "";
            dateTimePickerActualEnddate.Text = "";
            txtTechnology.Text = "";
            richtxtRequiredTools.Text = "";
            richtxtDescription.Text = "";

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
            errorProvider9.Clear();
            errorProvider.Clear();

            bool valid = true;
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
            DateTime fromdate = Convert.ToDateTime(dateTimePickerStartDate.Text);
            DateTime todate = Convert.ToDateTime(dateTimePickerEndDate.Text);
            DateTime actualtodate = Convert.ToDateTime(dateTimePickerActualEnddate.Text);
            if (fromdate < todate && fromdate<actualtodate)
            {
                TimeSpan ts = todate.Subtract(fromdate);
            }
            else
            {
                errorProvider7.SetError(dateTimePickerStartDate, "start date must be less and not equal to end date and actual end date");
                valid = false;
                dateTimePickerStartDate.Focus();

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
        /// load all data from database table
        /// </summary>
        /// <returns></returns>
        private DataTable LoadDataFromDatabase()
        {
            DataTable dataTable = new DataTable();
            SqlConnection con = DBConnect.myCon;
            con.Open();
            SqlCommand command = new SqlCommand("SpProjectManagementGetProjectid", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        /// <summary>
        /// to get next value 
        /// </summary>
        /// <returns></returns>
        private int GetNextId()
        {
            SqlConnection con = DBConnect.myCon;
            con.Open();

            try
            {
                SqlCommand command = new SqlCommand("SpProjectManagementGetNextValue", con);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter returnValue = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                int nextProjectId = (int)returnValue.Value;
                con.Close();
                return nextProjectId;
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return -1;

            }
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
                    int itemId = Convert.ToInt32(row["Project_Id"]);
                    cmbProjectId.Items.Add(itemId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
            btnSubmit.Enabled = true;
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
            btnSubmit.Enabled = false;
            btnReset.Enabled = false;
        }

        /// <summary>
        /// keypress event of textbox
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

        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Project_ManagementForm_Load(object sender, EventArgs e)
        {
            cmbProjectId.Enabled = true;
            LoadComboBoxData();
        }

        /// <summary>
        /// select id in combobox and retrieve data from table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProjectId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enabletrue();
            SqlConnection con = DBConnect.myCon;
            con.Open();
            try
            {
                if (!string.IsNullOrWhiteSpace(cmbProjectId.Text))
                {
                    SqlCommand cmd = new SqlCommand("SpProjectManagementGetData", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Project_id", int.Parse(cmbProjectId.Text));
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        txtProjectName.Text = dataReader["Project_Name"].ToString();
                        txtManagerName.Text = dataReader["Manager_Name"].ToString();
                        dateTimePickerStartDate.Text = dataReader["StartDate"].ToString();
                        dateTimePickerEndDate.Text = dataReader["Expected_EndDate"].ToString();
                        dateTimePickerActualEnddate.Text = dataReader["Actual_EndDate"].ToString();
                        txtTechnology.Text = dataReader["Technology"].ToString();
                        richtxtRequiredTools.Text = dataReader["Required_Tools"].ToString();
                        richtxtDescription.Text = dataReader["Description"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        #region key press txtbox
        private void txtProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {

            Keypresstxt(e);
        }

        private void txtManagerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypresstxt(e);
        }
        #endregion

        private void Project_ManagementForm_Load_1(object sender, EventArgs e)
        {

        }

        private void Project_ManagementForm_Load_2(object sender, EventArgs e)
        {

        }
        
    }
}




