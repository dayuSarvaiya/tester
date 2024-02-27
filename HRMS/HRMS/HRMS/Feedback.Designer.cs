namespace HRMS
{
    partial class Feedback
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Items.AddRange(new object[] {
            "Dhruv",
            "Ram",
            "Raj",
            "Jeet"});
            this.cmbEmployees.Location = new System.Drawing.Point(23, 25);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(134, 21);
            this.cmbEmployees.TabIndex = 0;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComment.Location = new System.Drawing.Point(23, 65);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(472, 160);
            this.txtComment.TabIndex = 1;
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmitFeedback.Location = new System.Drawing.Point(218, 243);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(100, 25);
            this.btnSubmitFeedback.TabIndex = 2;
            this.btnSubmitFeedback.Text = "Submit Feedback";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 285);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Feedback";
            this.Text = "Feedback Form";
            this.Load += new System.EventHandler(this.Feedback_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmitFeedback;
    }
}
