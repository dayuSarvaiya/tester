using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Forgot : Form
    {
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection Connection = new SqlConnection(AppSettings.ConnectionString);
        DataTable DtForgot;
        private SqlDataAdapter AdpForgot;
        public Forgot()
        {
            InitializeComponent();
            #region Event
            btnChpsw.Click += BtnChpsw_Click;
            FillData(); 
            #endregion
        }

        #region Button Click
        /// <summary>
        /// Button change Password click to change  password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChpsw_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow forgot = DtForgot.NewRow();
                forgot[DBConst.Password] = txtPassword.Text;
                AdpForgot.Update(DtForgot);
                DtForgot.Rows.Clear();
                AdpForgot.Fill(DtForgot);
                AppGlobal.CustomMessageBox.ShowMessage("Successfully Inserted", "Information");
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message,"");
            }
        }
        #endregion

        #region function
        /// <summary>
        /// Fill data function 
        /// </summary>
        void FillData()
        {
            AdpForgot = new SqlDataAdapter();
            AdpForgot.UpdateCommand = ClientMethod.Forgot_Update();
            AdpForgot.SelectCommand = ClientMethod.Registration_select();
            DtForgot = new DataTable();
            DtForgot.TableName = TableConst.Registration;
            AdpForgot.Fill(DtForgot);
        } 
        #endregion        
    }        
}