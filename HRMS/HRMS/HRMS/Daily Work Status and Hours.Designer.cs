namespace HRMS
{
    partial class Daily_Work_Status_and_Hours
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboEmployees = new System.Windows.Forms.ComboBox();
            this.comboProjectId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richWorkDetails = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtTotalHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Location = new System.Drawing.Point(204, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(17, 86);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerDate.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Work In Details";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.Location = new System.Drawing.Point(63, 289);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 25);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // comboEmployees
            // 
            this.comboEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmployees.FormattingEnabled = true;
            this.comboEmployees.Items.AddRange(new object[] {
            "Dhruv",
            "Ram",
            "Raj",
            "Jeet"});
            this.comboEmployees.Location = new System.Drawing.Point(205, 88);
            this.comboEmployees.Name = "comboEmployees";
            this.comboEmployees.Size = new System.Drawing.Size(145, 24);
            this.comboEmployees.TabIndex = 14;
            // 
            // comboProjectId
            // 
            this.comboProjectId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboProjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProjectId.FormattingEnabled = true;
            this.comboProjectId.Location = new System.Drawing.Point(17, 29);
            this.comboProjectId.Name = "comboProjectId";
            this.comboProjectId.Size = new System.Drawing.Size(135, 24);
            this.comboProjectId.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Project ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Project Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Date";
            // 
            // richWorkDetails
            // 
            this.richWorkDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richWorkDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richWorkDetails.Location = new System.Drawing.Point(17, 209);
            this.richWorkDetails.Name = "richWorkDetails";
            this.richWorkDetails.Size = new System.Drawing.Size(333, 57);
            this.richWorkDetails.TabIndex = 32;
            this.richWorkDetails.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Employee Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Start Time";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "End Time";
            // 
            // txtProject
            // 
            this.txtProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(204, 29);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(146, 23);
            this.txtProject.TabIndex = 38;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(17, 146);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 23);
            this.txtStartDate.TabIndex = 39;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(205, 146);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 23);
            this.txtEndDate.TabIndex = 40;
            // 
            // txtTotalHours
            // 
            this.txtTotalHours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHours.Location = new System.Drawing.Point(311, 146);
            this.txtTotalHours.Name = "txtTotalHours";
            this.txtTotalHours.ReadOnly = true;
            this.txtTotalHours.Size = new System.Drawing.Size(57, 23);
            this.txtTotalHours.TabIndex = 41;
            // 
            // Daily_Work_Status_and_Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.txtTotalHours);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richWorkDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboProjectId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Daily_Work_Status_and_Hours";
            this.Text = "Daily_Work_Status_and_Hours";
            this.Load += new System.EventHandler(this.Daily_Work_Status_and_Hours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboEmployees;
        private System.Windows.Forms.ComboBox comboProjectId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richWorkDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtTotalHours;
    }
}