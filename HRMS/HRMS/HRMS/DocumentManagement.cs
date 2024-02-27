using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HRMS
{
    public partial class DocumentManagement : DockContent
    {
        public DataTable DataTableDocument_Management;
        public SqlDataAdapter DataAdapterDocument_Management;
        public DocumentManagement()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
        }
        /// <summary>
        /// Button Clear Field Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtFilename.Clear();
            txtDescription.Clear();
        }

        /// <summary>
        /// Button Delete Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                AppGlobal.CustomMessageBox.ShowMessage("Please select a file to delete.", "Error");
            }
        }

        /// <summary>
        /// Button Update Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string description = txtDescription.Text;
                selectedRow.Cells["Description"].Value = description;
            }
            else
            {
                AppGlobal.CustomMessageBox.ShowMessage("Please select a file to update.", "Error");
            }
        }

        /// <summary>
        /// Button Add Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string fileType = Path.GetExtension(filename);
                string description = txtDescription.Text;
                dataGridView1.Rows.Add(filename, fileType, description);
            }
        }
        /// <summary>
        /// Document DocumentManagement Load Page Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocumentManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Filename";
            dataGridView1.Columns[1].Name = "Filetype";
            dataGridView1.Columns[2].Name = "Description";           
        }
    }
}