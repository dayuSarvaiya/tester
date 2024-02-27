namespace HRMS
{
    partial class UpdateIssue
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.txtAssignby = new System.Windows.Forms.TextBox();
            this.txtTastedby = new System.Windows.Forms.TextBox();
            this.dateTimeTasted = new System.Windows.Forms.DateTimePicker();
            this.txtResolvedby = new System.Windows.Forms.TextBox();
            this.dateTimeResolved = new System.Windows.Forms.DateTimePicker();
            this.richTextRemark = new System.Windows.Forms.RichTextBox();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboTaskId = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assign by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasted by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tasted Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resolved by";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resolved Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Remark";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Priority";
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "On Hold",
            "In Progress",
            "Completed",
            "Pending",
            "Tested"});
            this.comboStatus.Location = new System.Drawing.Point(120, 17);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 24);
            this.comboStatus.TabIndex = 9;
            // 
            // txtAssignby
            // 
            this.txtAssignby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignby.Location = new System.Drawing.Point(120, 52);
            this.txtAssignby.Name = "txtAssignby";
            this.txtAssignby.Size = new System.Drawing.Size(100, 23);
            this.txtAssignby.TabIndex = 10;
            // 
            // txtTastedby
            // 
            this.txtTastedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTastedby.Location = new System.Drawing.Point(120, 87);
            this.txtTastedby.Name = "txtTastedby";
            this.txtTastedby.Size = new System.Drawing.Size(100, 23);
            this.txtTastedby.TabIndex = 11;
            // 
            // dateTimeTasted
            // 
            this.dateTimeTasted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTasted.Location = new System.Drawing.Point(120, 121);
            this.dateTimeTasted.Name = "dateTimeTasted";
            this.dateTimeTasted.Size = new System.Drawing.Size(179, 23);
            this.dateTimeTasted.TabIndex = 12;
            // 
            // txtResolvedby
            // 
            this.txtResolvedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResolvedby.Location = new System.Drawing.Point(120, 157);
            this.txtResolvedby.Name = "txtResolvedby";
            this.txtResolvedby.Size = new System.Drawing.Size(100, 23);
            this.txtResolvedby.TabIndex = 13;
            // 
            // dateTimeResolved
            // 
            this.dateTimeResolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeResolved.Location = new System.Drawing.Point(120, 191);
            this.dateTimeResolved.Name = "dateTimeResolved";
            this.dateTimeResolved.Size = new System.Drawing.Size(179, 23);
            this.dateTimeResolved.TabIndex = 14;
            // 
            // richTextRemark
            // 
            this.richTextRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextRemark.Location = new System.Drawing.Point(120, 229);
            this.richTextRemark.Name = "richTextRemark";
            this.richTextRemark.Size = new System.Drawing.Size(200, 44);
            this.richTextRemark.TabIndex = 15;
            this.richTextRemark.Text = "";
            // 
            // comboPriority
            // 
            this.comboPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Items.AddRange(new object[] {
            "Blocker",
            "Critical",
            "Minor",
            "Trivial"});
            this.comboPriority.Location = new System.Drawing.Point(120, 289);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(121, 24);
            this.comboPriority.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(426, 342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(297, 344);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 21);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Create Another";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboTaskId
            // 
            this.comboTaskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTaskId.FormattingEnabled = true;
            this.comboTaskId.Location = new System.Drawing.Point(401, 15);
            this.comboTaskId.Name = "comboTaskId";
            this.comboTaskId.Size = new System.Drawing.Size(121, 24);
            this.comboTaskId.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Project Id";
            // 
            // UpdateIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 384);
            this.Controls.Add(this.comboTaskId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.richTextRemark);
            this.Controls.Add(this.dateTimeResolved);
            this.Controls.Add(this.txtResolvedby);
            this.Controls.Add(this.dateTimeTasted);
            this.Controls.Add(this.txtTastedby);
            this.Controls.Add(this.txtAssignby);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateIssue";
            this.Text = "UpdateIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.TextBox txtAssignby;
        private System.Windows.Forms.TextBox txtTastedby;
        private System.Windows.Forms.DateTimePicker dateTimeTasted;
        private System.Windows.Forms.TextBox txtResolvedby;
        private System.Windows.Forms.DateTimePicker dateTimeResolved;
        private System.Windows.Forms.RichTextBox richTextRemark;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboTaskId;
        private System.Windows.Forms.Label label9;
    }
}