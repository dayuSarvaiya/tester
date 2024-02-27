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
using WeifenLuo.WinFormsUI.Docking;

namespace HRMS
{
    public partial class Feedback : DockContent
    {
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection Connection = new SqlConnection(AppSettings.ConnectionString);
        DataTable dtFeedback;
        private SqlDataAdapter adpFeedback;
        public Feedback()
        {
            InitializeComponent();
            btnSubmitFeedback.Click += BtnSubmitFeedback_Click;
        }

        #region Form Load
        /// <summary>
        /// Form Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Feedback_Load_1(object sender, EventArgs e)
        {
            FillData();
        }
        #endregion

        #region Button Click
        /// <summary>
        /// Button submit to submit the feedback
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmitFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow feedback = dtFeedback.NewRow();
                feedback[DBConst.Employee] = cmbEmployees.Text;
                feedback[DBConst.Comment] = txtComment.Text;
                dtFeedback.Rows.Add(feedback);
                adpFeedback.Update(dtFeedback);
                dtFeedback.Rows.Clear();
                adpFeedback.Fill(dtFeedback);
                AppGlobal.CustomMessageBox.ShowMessage("Feedback Submit Successful", "Information");
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message,"");
            }
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
                adpFeedback = new SqlDataAdapter();
                adpFeedback.SelectCommand = ClientMethod.Feedback_select();
                adpFeedback.InsertCommand = ClientMethod.Feedback_insert();
                dtFeedback = new DataTable();
                dtFeedback.TableName = TableConst.Registration;
                adpFeedback.Fill(dtFeedback);
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage("Invalid Details", "Error");
            }
        } 
        #endregion
    }
}