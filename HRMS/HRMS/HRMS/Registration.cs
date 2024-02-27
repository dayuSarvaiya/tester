using HRMS;
using HRMS.AppClass;
using HRMS.DBClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PMS
{
    public partial class Registration : DockContent
    {
        public static AppSetting AppSettings = new AppSetting();
        public static SqlConnection connection = new SqlConnection(AppSettings.ConnectionString);
        DataTable dtRegistration;
        private SqlDataAdapter adpRegistration;
        SqlCommand cmd;
        static Regex validate_password = PasswordValidation();
        DataTable dt;
        DataSet ds = new DataSet();
        private object password;
        #region Subscribe Component
        public Registration()
        {
            InitializeComponent();
            btnSubmit.Click += BtnSubmit_Click;
            txtFirstName.KeyPress += TxtFirstName_KeyPress;
            txtLastName.KeyPress += TxtLastName_KeyPress;
            txtEmail.Leave += TxtEmail_Leave;
            txtUsername.KeyPress += TxtUsername_KeyPress;
            txtPassword.Leave += TxtPassword_Leave;
            TextBoxConf.Leave += TextBoxConf_Leave;
            txtMiddleName.KeyPress += TxtMiddleName_KeyPress;
            txtMobileno.KeyPress += TxtMobileno_KeyPress;
            comboBlood.KeyPress += ComboBlood_KeyPress;
            txtUsername.Enter += TxtUsername_Enter;
            txtUsername.Leave += TxtUsername_Leave;
        }
        #endregion

        /// <summary>
        /// Button Submit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!RegistrationValidation())
                {
                    return;
                }
                else
                {
                    DataRow registration = dtRegistration.NewRow();
                    registration[DBConst.Firstname] = txtFirstName.Text;
                    registration[DBConst.Lastname] = txtLastName.Text;
                    registration[DBConst.Username] = txtUsername.Text;
                    registration[DBConst.Email] = txtEmail.Text;
                    registration[DBConst.Password] = txtPassword.Text;
                    registration[DBConst.Middlename] = txtMiddleName.Text;
                    registration[DBConst.Address] = richTextBoxAddress.Text;
                    registration[DBConst.MobileNo] = txtMobileno.Text;
                    registration[DBConst.BloodGroup] = comboBlood.Text;
                    registration[DBConst.Gender] = radioBtnMale.Checked ? "Male" : "Female";
                    dtRegistration.Rows.Add(registration);
                    adpRegistration.Update(dtRegistration);
                    dtRegistration.Rows.Clear();
                    adpRegistration.Fill(dtRegistration);
                    AppGlobal.CustomMessageBox.ShowMessage("Successfully Inserted","Information");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message,"");
            }
        }

        /// <summary>
        /// TextBox Username Leave Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "FirstName+LastName";
                txtUsername.ForeColor = Color.Silver;
                return;
            }
            SqlCommand cmd = new SqlCommand("CheckUsernameExists", connection);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                try
                {
                    connection.Open();
                    int usernameExists = Convert.ToInt32(cmd.ExecuteScalar());

                    if (usernameExists == 1)
                    {
                        AppGlobal.CustomMessageBox.ShowMessage($"Username {txtUsername.Text} already exists","Error");
                    }
                }
                catch (Exception ex)
                {
                    AppGlobal.CustomMessageBox.ShowMessage(ex.Message,"");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// TextBox Username Enter Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "FirstName+LastName")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// ComboBox BloodGroup KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBlood_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBlood.Text = string.Empty; e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// KeyPress Event TextBox Mobileno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMobileno_KeyPress(object sender, KeyPressEventArgs e)
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
        /// TextBox MiddleName KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// TextBox Conform Password Leave Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxConf_Leave(object sender, EventArgs e)
        {
            if (TextBoxConf.Text != txtPassword.Text)
            {
                AppGlobal.CustomMessageBox.ShowMessage("Confirm Password is Incorrect!!","Error");
                return;
            }
            else
            {
                ErpPassword.Clear();
            }
        }

        /// <summary>
        /// TextBox Password Leave Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                ErpPassword.SetError(this.txtPassword, "Please enter the Password!");
            }
            else
            {
                ErpPassword.Clear();
            }
        }

        /// <summary>
        /// TextBox Username KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"\uD83D[\uDE00-\uDEFF]|[\u2600-\u26FF]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// TextBox Email Leave Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                Regex Expression;
                if (txtEmail.Text.Trim() != string.Empty)
                {
                    Expression = new Regex(@"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$");
                    if (!Expression.IsMatch(txtEmail.Text.Trim()))
                    {
                        AppGlobal.CustomMessageBox.ShowMessage("E-mail address format is not correct.", "Error");
                        txtEmail.Focus();
                        return;
                    }
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("CheckEmailExists", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    int emailExists = (int)cmd.ExecuteScalar();
                    if (emailExists == 1)
                    {
                        AppGlobal.CustomMessageBox.ShowMessage(string.Format("Email {0} already exists", txtEmail.Text),"Error");
                        txtEmail.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                AppGlobal.CustomMessageBox.ShowMessage(ex.Message,"");
            }

            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// TextBox LastName KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// TextBox FirstName KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            adpRegistration = new SqlDataAdapter();
            adpRegistration.SelectCommand = ClientMethod.Registration_select();
            adpRegistration.InsertCommand = ClientMethod.Registration_insert();
            dtRegistration = new DataTable();
            dtRegistration.TableName = TableConst.Registration;
            adpRegistration.Fill(dtRegistration);
        }
        /// <summary>
        /// Regex String Function(Password validation)
        /// </summary>
        /// <returns></returns>
        private static Regex PasswordValidation()
        {
            string pattern = ("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$");
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// Copy Password code
        /// </summary>
        private const Keys K_Copy = Keys.Control | Keys.C;
        private const Keys K_Past = Keys.Control | Keys.V;
        /// <summary>
        /// Validation Function
        /// </summary>
        /// <returns></returns>
        public bool RegistrationValidation()
        {
            var errorProvider = new ErrorProvider();
            ErpFirstName.Clear();
            ErpLastName.Clear();
            ErpEmail.Clear();
            ErpUsername.Clear();
            ErpPassword.Clear();
            ErpMobileNo.Clear();
            ErpAddress.Clear();
            ErpConfoPassword.Clear();
            errorProviderGender.Clear();
            ErpUsername.Clear();
            bool valid = true;
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                ErpFirstName.SetError(txtFirstName, "Please Enter the FirstName");
                valid = false;
                txtFirstName.Focus();
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                ErpLastName.SetError(txtLastName, "Please Enter the LastName");
                valid = false;
                txtLastName.Focus();
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                ErpEmail.SetError(txtEmail, "Please Enter the EmailId");
                valid = false;
                txtEmail.Focus();
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                ErpUsername.SetError(txtUsername, "Please Enter the Username");
                valid = false;
                txtUsername.Focus();
            }
            var input = txtPassword.Text;
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ErpPassword.SetError(txtPassword, "Please Enter the Password");
                valid = false;
                txtPassword.Focus();
            }
            else if (validate_password.IsMatch(txtPassword.Text) != true)
            {
                MessageBox.Show("Password must be atleast 8 to 15 characters. It contains atleast one Upper And Lower case,Special Characters and numbers.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return false;
            }
            else if (TextBoxConf.Text != txtPassword.Text)
            {
                MessageBox.Show("Confirm Password is Incorrect!!");
                TextBoxConf.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextBoxConf.Text))
            {
                ErpPassword.SetError(TextBoxConf, "Please Enter the ConfirmPassword");
                valid = false;
                TextBoxConf.Focus();
            }
            string MobileNumber = txtMobileno.Text.Trim();
            if (string.IsNullOrEmpty(txtMobileno.Text))
            {
                ErpMobileNo.SetError(txtMobileno, "Please Enter the MobileNumber");
                valid = false;
                txtMobileno.Focus();
            }
            else if (MobileNumber.Length == 10)
            {
                txtMobileno.Text = MobileNumber;
            }
            else
            {
                MessageBox.Show("Invalid Input.Please Enter 10 digit Number");
                txtMobileno.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(richTextBoxAddress.Text))
            {
                ErpAddress.SetError(richTextBoxAddress, "Please Enter the Address");
                valid = false;
                richTextBoxAddress.Focus();
            }
            if (string.IsNullOrEmpty(TextBoxConf.Text))
            {
                ErpConfoPassword.SetError(TextBoxConf, "Please Enter the Confirm Password");
                valid = false;
                TextBoxConf.Focus();
            }
            if (string.IsNullOrEmpty(lblGender.Text))
            {
                errorProviderGender.SetError(lblGender, "Please select the Gender");
                valid = false;
                lblGender.Focus();
            }
            if (!radioBtnMale.Checked && !radioBtnFemale.Checked)
            {
                errorProviderGender.SetError(radioBtnMale, "Please select a gender.");
            }
            else
            {
                errorProviderGender.SetError(radioBtnMale, null);
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
        /// Call Fill Data Function on Registration Load Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registration_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}