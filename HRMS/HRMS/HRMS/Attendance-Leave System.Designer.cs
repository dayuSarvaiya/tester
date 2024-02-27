namespace HRMS
{
    partial class Attendance_Leave_System
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

        

        private void InitializeComponent()
        {
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.dataGridViewLeaveRequests = new System.Windows.Forms.DataGridView();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnRequestLeave = new System.Windows.Forms.Button();
            this.btnViewLeaveRequests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(12, 12);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEmployees.TabIndex = 0;
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewAttendance.TabIndex = 1;
            // 
            // dataGridViewLeaveRequests
            // 
            this.dataGridViewLeaveRequests.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewLeaveRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaveRequests.Location = new System.Drawing.Point(12, 270);
            this.dataGridViewLeaveRequests.Name = "dataGridViewLeaveRequests";
            this.dataGridViewLeaveRequests.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewLeaveRequests.TabIndex = 2;
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMarkAttendance.Location = new System.Drawing.Point(13, 40);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(100, 25);
            this.btnMarkAttendance.TabIndex = 3;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewAttendance.Location = new System.Drawing.Point(118, 40);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(100, 25);
            this.btnViewAttendance.TabIndex = 4;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRequestLeave.Location = new System.Drawing.Point(12, 238);
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.Size = new System.Drawing.Size(100, 25);
            this.btnRequestLeave.TabIndex = 5;
            this.btnRequestLeave.Text = "Request Leave";
            this.btnRequestLeave.UseVisualStyleBackColor = true;
            // 
            // btnViewLeaveRequests
            // 
            this.btnViewLeaveRequests.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewLeaveRequests.Location = new System.Drawing.Point(118, 238);
            this.btnViewLeaveRequests.Name = "btnViewLeaveRequests";
            this.btnViewLeaveRequests.Size = new System.Drawing.Size(150, 25);
            this.btnViewLeaveRequests.TabIndex = 6;
            this.btnViewLeaveRequests.Text = "View Leave Requests";
            this.btnViewLeaveRequests.UseVisualStyleBackColor = true;
            // 
            // Attendance_Leave_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 432);
            this.Controls.Add(this.btnViewLeaveRequests);
            this.Controls.Add(this.btnRequestLeave);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.btnMarkAttendance);
            this.Controls.Add(this.dataGridViewLeaveRequests);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Controls.Add(this.comboBoxEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Attendance_Leave_System";
            this.Text = "Attendance and Leave System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveRequests)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.DataGridView dataGridViewLeaveRequests;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnRequestLeave;
        private System.Windows.Forms.Button btnViewLeaveRequests;
    }
}
