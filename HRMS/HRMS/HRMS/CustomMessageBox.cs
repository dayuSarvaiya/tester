using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HRMS
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
            btnOK.Click += BtnOK_Click;
        }

        #region Button Click
        /// <summary>
        /// Yes button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        /// <summary>
        /// No button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        /// <summary>
        /// OK Button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion

        #region Function
        /// <summary>
        /// Function for Show message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="alertType"></param>
        public void ShowMessage(string message, string alertType)
        {
            labelMessage.Text = message;
            switch (alertType)
            {
                case "Information":
                    pictureBoxIcon.Image = SystemIcons.Information.ToBitmap();
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnOK.Visible = false;
                    break;
                case "Error":
                    pictureBoxIcon.Image = SystemIcons.Error.ToBitmap();
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnOK.Visible = true;
                    break;
                default:
                    break;
            }
            this.ShowDialog();
        }
        #endregion
    }
}