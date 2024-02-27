using HRMS;
using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PMS
{
    public partial class FileAttchment : DockContent
    {
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection connnection = new SqlConnection(AppSettings.ConnectionString);

        DataTable dtFileAttchment;
        private SqlDataAdapter adpFileAttchment;
        DataTable dt;
        DataSet ds = new DataSet();

        #region Subscribe Component
        public FileAttchment()
        {
            InitializeComponent();
            comboattch.KeyPress += Comboattch_KeyPress;
        }
        #endregion

        /// <summary>
        /// KeyPress Event For ComboAttch File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Comboattch_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboattch.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Fill Data Function
        /// </summary>
        void FillData()
        {
            adpFileAttchment = new SqlDataAdapter();
            adpFileAttchment.InsertCommand = ClientMethod.FileAttchment_insert();
            adpFileAttchment.SelectCommand = ClientMethod.FileAttchment_select();
            dtFileAttchment = new DataTable();
            dtFileAttchment.TableName = TableConst.FileAttchment;
            adpFileAttchment.Fill(dtFileAttchment);
        }

        /// <summary>
        /// Button Browsw Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileOpen = new OpenFileDialog();
            FileOpen.Title = "My Files";
            FileOpen.InitialDirectory = @"c:\";
            FileOpen.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            FileOpen.FilterIndex = 2;
            FileOpen.RestoreDirectory = true;
            if (FileOpen.ShowDialog() == DialogResult.OK)
            {
                txtFileSubmit.Text = FileOpen.FileName;
            }
        }

        /// <summary>
        /// TextBox Project ID KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProjectID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Button Save Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FileAttachValidation())
                {
                    return;
                }
                else
                {
                    DataRow FileAttchment = dtFileAttchment.NewRow();
                    FileAttchment[DBConst.ProjectID] = txtProjectID.Text;
                    FileAttchment[DBConst.FileName] = txtFileName.Text;
                    FileAttchment[DBConst.AttchmentType] = comboattch.Text;
                    FileAttchment[DBConst.Description] = txtDesc.Text;
                    FileAttchment[DBConst.FileSubmit] = txtFileSubmit.Text;
                    dtFileAttchment.Rows.Add(FileAttchment);
                    adpFileAttchment.Update(dtFileAttchment);
                    dtFileAttchment.Rows.Clear();
                    adpFileAttchment.Fill(dtFileAttchment);
                    AppGlobal.CustomMessageBox.ShowMessage("Successfully Inserted", "Information");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// FileAttchment validation Function
        /// </summary>
        /// <returns></returns>
        private bool FileAttachValidation()
        {
            errorattchtype = new ErrorProvider();
            errorProjectid.Clear();
            errorFileName.Clear();
            errorattchtype.Clear();
            errorDesc.Clear();
            errorSubmitFile.Clear();
            bool valid = true;
            if (string.IsNullOrEmpty(txtProjectID.Text))
            {
                errorProjectid.SetError(txtProjectID, "ProjectID is Required");
                valid = false;
                txtProjectID.Focus();
            }
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                errorFileName.SetError(txtFileName, "FileName is Required");
                valid = false;
                txtFileName.Focus();
            }
            if (string.IsNullOrEmpty(comboattch.Text))
            {
                errorattchtype.SetError(comboattch, "FileType is Required");
                valid = false;
                comboattch.Focus();
            }
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                errorDesc.SetError(txtDesc, "Description is required");
                valid = false;
                txtDesc.Focus();
            }
            if (string.IsNullOrEmpty(txtFileSubmit.Text))
            {
                errorSubmitFile.SetError(txtFileSubmit, "File is Required");
                valid = false;
                txtFileSubmit.Focus();
            }
            if (!valid)
            {
                return false;
            }
            return valid;
        }

        /// <summary>
        /// Call FillData Function in FileAttchment Loead Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileAttchment_Load(object sender, EventArgs e)
        {
            FillData();
        }
        /// <summary>
        /// Button Cancel Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtProjectID.Text = String.Empty;
            txtFileName.Text = String.Empty;
            txtDesc.Text = String.Empty;
            comboattch.Text = String.Empty;
            txtFileSubmit.Text = String.Empty;
        }

        /// <summary>
        /// TextBox FileSubmit KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFileSubmit_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFileSubmit.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}