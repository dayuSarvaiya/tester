using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HRMS
{
    public partial class TimeOnOff : DockContent
    {
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection Connection = new SqlConnection(AppSettings.ConnectionString);        
        private DateTime checkInTime;
        private DateTime checkOutTime;

        #region Subscribe Component
        public TimeOnOff()
        {
            InitializeComponent();
            btnCheckOut.Click += BtnCheckOut_Click;
            btnCheckIn.Click += BtnCheckIn_Click;
            timer1.Tick += Timer1_Tick;

            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        #endregion

        #region Button Click
        /// <summary>
        /// timer Tick Event For get current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            timer1.Start();
            //UpdateStatusLabel();
        }

        /// <summary>
        /// Button CheckIn click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            InsertDataToDatabase("CheckIn");
            LoadDataIntoDataGridView();
            btnCheckIn.Enabled = false;
        }

        /// <summary>
        /// Button Check Out Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            InsertDataToDatabase("CheckOut");
            LoadDataIntoDataGridView();
            btnCheckOut.Enabled = false;
        }
        #endregion

        /// <summary>
        /// Insert data to database
        /// </summary>
        /// <param name="status"></param>
        private void InsertDataToDatabase(string status)
        {
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("Timeonoff_insert", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TimeOn", DateTime.Now);
                cmd.Parameters.AddWithValue("@TimeOff", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Load data into datagridview
        /// </summary>
        private void LoadDataIntoDataGridView()
        {
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TimeOnOff", Connection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dgvTime.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Time On OFF Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void TimeOnOff_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM d,yyyy");
        }
    }
}