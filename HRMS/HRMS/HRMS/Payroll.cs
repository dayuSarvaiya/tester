using HRMS.AppClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace HRMS
{
    public partial class Payroll : DockContent
    {
        private double double_;
        public Payroll()
        {
            InitializeComponent();
            btnCalculatePayroll.Click += BtnCalculatePayroll_Click;
        }

        /// <summary>
        /// Button calculate click event for payroll 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculatePayroll_Click(object sender, EventArgs e)
        {
            if (!ValidateNumericInput(txtBasicSalary, "Basic Salary") ||
                !ValidateNumericInput(txtHRA, "HRA") ||
                !ValidateNumericInput(txtConveyanceAllowance, "Conveyance Allowance") ||
                !ValidateNumericInput(txtMedicalAllowance, "Medical Allowance") ||
                !ValidateNumericInput(txtSpecialAllowance, "Special Allowance") ||
                !ValidateNumericInput(txtESIC, "ESIC") ||
                !ValidateNumericInput(txtPF, "PF") ||
                !ValidateNumericInput(txtProfessionalTax, "Professional Tax") ||
                !ValidateNumericInput(txtBonusYearly, "Yearly Bonus"))
            {
                AppGlobal.CustomMessageBox.ShowMessage("Please enter valid numeric values for all input fields.", "Error");
                return;
            }
            double basicSalary = double.Parse(txtBasicSalary.Text);
            double hra = double.Parse(txtHRA.Text);
            double conveyanceAllowance = double.Parse(txtConveyanceAllowance.Text);
            double medicalAllowance = double.Parse(txtMedicalAllowance.Text);
            double specialAllowance = double.Parse(txtSpecialAllowance.Text);
            double grossSalary = basicSalary + hra + conveyanceAllowance + medicalAllowance + specialAllowance;
            txtGrossSalary.Text = grossSalary.ToString();
            double esic = double.Parse(txtESIC.Text);
            double pf = double.Parse(txtPF.Text);
            double professionalTax = double.Parse(txtProfessionalTax.Text);
            double totalDeductions = esic + pf + professionalTax;
            txtDeductions.Text = totalDeductions.ToString();
            double netMonthlyPayout = grossSalary - totalDeductions;
            txtNetMonthlyPayout.Text = netMonthlyPayout.ToString();
            double bonusYearly = double.Parse(txtBonusYearly.Text);
            double totalYearlySalary = netMonthlyPayout * 12 + bonusYearly;
            txtBonusYearly.Text = bonusYearly.ToString();
            txtTotalYearlySalary.Text = totalYearlySalary.ToString();
        }

        /// <summary>
        /// validation function
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private bool ValidateNumericInput(TextBox textBox, string fieldName)
        {
            if (!double.TryParse(textBox.Text, out double_))
            {
                AppGlobal.CustomMessageBox.ShowMessage($"Please enter a valid numeric value for {fieldName}.", "Error");
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
            return true;
        }
    }
}