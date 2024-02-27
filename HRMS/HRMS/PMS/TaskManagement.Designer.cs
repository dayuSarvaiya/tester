namespace PMS
{
    partial class TaskManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagement));
            this.cmbTaskId = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerComplitionDate = new System.Windows.Forms.DateTimePicker();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.ComboOwner = new System.Windows.Forms.ComboBox();
            this.txtTaskname = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblCompletionDate = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblOwner = new System.Windows.Forms.Label();
            this.LblDesc = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.Label();
            this.errorProviderProject = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTaskName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCD = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSD = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTaskType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTaskID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProjectId = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTask = new System.Windows.Forms.Label();
            this.comboProjectID = new System.Windows.Forms.ComboBox();
            this.richTxtDesc = new System.Windows.Forms.RichTextBox();
            this.comboTaskType = new System.Windows.Forms.ComboBox();
            this.lblTasktype = new System.Windows.Forms.Label();
            this.dataGridViewTaskInfo = new System.Windows.Forms.DataGridView();
            this.LblProject = new System.Windows.Forms.Label();
            this.errorProviderStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOwner = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblProjectID = new System.Windows.Forms.Label();
            this.errorProviderDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaskName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaskType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaskID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProjectId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTaskId
            // 
            this.cmbTaskId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTaskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaskId.FormattingEnabled = true;
            this.cmbTaskId.Items.AddRange(new object[] {
            "PMS_1",
            "PMS_2"});
            this.cmbTaskId.Location = new System.Drawing.Point(516, 15);
            this.cmbTaskId.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTaskId.Name = "cmbTaskId";
            this.cmbTaskId.Size = new System.Drawing.Size(155, 28);
            this.cmbTaskId.TabIndex = 53;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(169, 162);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(155, 26);
            this.dateTimePickerStartDate.TabIndex = 44;
            // 
            // LblStartDate
            // 
            this.LblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.LblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.Location = new System.Drawing.Point(80, 163);
            this.LblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(86, 20);
            this.LblStartDate.TabIndex = 43;
            this.LblStartDate.Text = "Start Date";
            // 
            // dateTimePickerComplitionDate
            // 
            this.dateTimePickerComplitionDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerComplitionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerComplitionDate.Location = new System.Drawing.Point(516, 162);
            this.dateTimePickerComplitionDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerComplitionDate.Name = "dateTimePickerComplitionDate";
            this.dateTimePickerComplitionDate.Size = new System.Drawing.Size(155, 26);
            this.dateTimePickerComplitionDate.TabIndex = 42;
            // 
            // ComboStatus
            // 
            this.ComboStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "Complete",
            "In Progress",
            "On Hold"});
            this.ComboStatus.Location = new System.Drawing.Point(169, 126);
            this.ComboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(155, 28);
            this.ComboStatus.TabIndex = 41;
            // 
            // ComboOwner
            // 
            this.ComboOwner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboOwner.FormattingEnabled = true;
            this.ComboOwner.Location = new System.Drawing.Point(516, 88);
            this.ComboOwner.Margin = new System.Windows.Forms.Padding(2);
            this.ComboOwner.Name = "ComboOwner";
            this.ComboOwner.Size = new System.Drawing.Size(155, 28);
            this.ComboOwner.TabIndex = 40;
            // 
            // txtTaskname
            // 
            this.txtTaskname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTaskname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskname.Location = new System.Drawing.Point(516, 52);
            this.txtTaskname.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskname.Name = "txtTaskname";
            this.txtTaskname.Size = new System.Drawing.Size(155, 26);
            this.txtTaskname.TabIndex = 39;
            // 
            // txtProject
            // 
            this.txtProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProject.Enabled = false;
            this.txtProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(169, 52);
            this.txtProject.Margin = new System.Windows.Forms.Padding(2);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(155, 26);
            this.txtProject.TabIndex = 38;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(291, 283);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 25);
            this.BtnSave.TabIndex = 37;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(430, 283);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 25);
            this.BtnCancel.TabIndex = 36;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // LblCompletionDate
            // 
            this.LblCompletionDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCompletionDate.AutoSize = true;
            this.LblCompletionDate.BackColor = System.Drawing.Color.Transparent;
            this.LblCompletionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompletionDate.Location = new System.Drawing.Point(384, 163);
            this.LblCompletionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCompletionDate.Name = "LblCompletionDate";
            this.LblCompletionDate.Size = new System.Drawing.Size(134, 20);
            this.LblCompletionDate.TabIndex = 35;
            this.LblCompletionDate.Text = "Completion Date";
            // 
            // LblStatus
            // 
            this.LblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(80, 129);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(57, 20);
            this.LblStatus.TabIndex = 34;
            this.LblStatus.Text = "Status";
            // 
            // LblOwner
            // 
            this.LblOwner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblOwner.AutoSize = true;
            this.LblOwner.BackColor = System.Drawing.Color.Transparent;
            this.LblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOwner.Location = new System.Drawing.Point(384, 91);
            this.LblOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOwner.Name = "LblOwner";
            this.LblOwner.Size = new System.Drawing.Size(58, 20);
            this.LblOwner.TabIndex = 33;
            this.LblOwner.Text = "Owner";
            // 
            // LblDesc
            // 
            this.LblDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblDesc.AutoSize = true;
            this.LblDesc.BackColor = System.Drawing.Color.Transparent;
            this.LblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.Location = new System.Drawing.Point(79, 198);
            this.LblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(95, 20);
            this.LblDesc.TabIndex = 32;
            this.LblDesc.Text = "Description";
            // 
            // TaskName
            // 
            this.TaskName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TaskName.AutoSize = true;
            this.TaskName.BackColor = System.Drawing.Color.Transparent;
            this.TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.Location = new System.Drawing.Point(384, 55);
            this.TaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(94, 20);
            this.TaskName.TabIndex = 31;
            this.TaskName.Text = "Task Name";
            // 
            // errorProviderProject
            // 
            this.errorProviderProject.ContainerControl = this;
            // 
            // errorProviderTaskName
            // 
            this.errorProviderTaskName.ContainerControl = this;
            // 
            // errorProviderCD
            // 
            this.errorProviderCD.ContainerControl = this;
            // 
            // errorProviderSD
            // 
            this.errorProviderSD.ContainerControl = this;
            // 
            // errorProviderTaskType
            // 
            this.errorProviderTaskType.ContainerControl = this;
            // 
            // errorProviderTaskID
            // 
            this.errorProviderTaskID.ContainerControl = this;
            // 
            // errorProviderProjectId
            // 
            this.errorProviderProjectId.ContainerControl = this;
            // 
            // lblTask
            // 
            this.lblTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTask.AutoSize = true;
            this.lblTask.BackColor = System.Drawing.Color.Transparent;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(384, 18);
            this.lblTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(67, 20);
            this.lblTask.TabIndex = 51;
            this.lblTask.Text = "Task ID";
            // 
            // comboProjectID
            // 
            this.comboProjectID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProjectID.FormattingEnabled = true;
            this.comboProjectID.Items.AddRange(new object[] {
            "PMS_1",
            "PMS_2"});
            this.comboProjectID.Location = new System.Drawing.Point(169, 15);
            this.comboProjectID.Margin = new System.Windows.Forms.Padding(2);
            this.comboProjectID.Name = "comboProjectID";
            this.comboProjectID.Size = new System.Drawing.Size(155, 28);
            this.comboProjectID.TabIndex = 50;
            // 
            // richTxtDesc
            // 
            this.richTxtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtDesc.Location = new System.Drawing.Point(169, 198);
            this.richTxtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.richTxtDesc.MaxLength = 100;
            this.richTxtDesc.Name = "richTxtDesc";
            this.richTxtDesc.Size = new System.Drawing.Size(502, 71);
            this.richTxtDesc.TabIndex = 48;
            this.richTxtDesc.Text = "";
            // 
            // comboTaskType
            // 
            this.comboTaskType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboTaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTaskType.FormattingEnabled = true;
            this.comboTaskType.Items.AddRange(new object[] {
            "Bug",
            "Development",
            "Unit Testing"});
            this.comboTaskType.Location = new System.Drawing.Point(169, 88);
            this.comboTaskType.Margin = new System.Windows.Forms.Padding(2);
            this.comboTaskType.Name = "comboTaskType";
            this.comboTaskType.Size = new System.Drawing.Size(152, 28);
            this.comboTaskType.TabIndex = 47;
            // 
            // lblTasktype
            // 
            this.lblTasktype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTasktype.AutoSize = true;
            this.lblTasktype.BackColor = System.Drawing.Color.Transparent;
            this.lblTasktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasktype.Location = new System.Drawing.Point(76, 91);
            this.lblTasktype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTasktype.Name = "lblTasktype";
            this.lblTasktype.Size = new System.Drawing.Size(86, 20);
            this.lblTasktype.TabIndex = 46;
            this.lblTasktype.Text = "Task Type";
            // 
            // dataGridViewTaskInfo
            // 
            this.dataGridViewTaskInfo.AllowUserToAddRows = false;
            this.dataGridViewTaskInfo.AllowUserToResizeColumns = false;
            this.dataGridViewTaskInfo.AllowUserToResizeRows = false;
            this.dataGridViewTaskInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewTaskInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskInfo.Location = new System.Drawing.Point(79, 322);
            this.dataGridViewTaskInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTaskInfo.Name = "dataGridViewTaskInfo";
            this.dataGridViewTaskInfo.RowHeadersWidth = 51;
            this.dataGridViewTaskInfo.Size = new System.Drawing.Size(592, 235);
            this.dataGridViewTaskInfo.TabIndex = 45;
            // 
            // LblProject
            // 
            this.LblProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblProject.AutoSize = true;
            this.LblProject.BackColor = System.Drawing.Color.Transparent;
            this.LblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProject.Location = new System.Drawing.Point(80, 55);
            this.LblProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(62, 20);
            this.LblProject.TabIndex = 30;
            this.LblProject.Text = "Project";
            // 
            // errorProviderStatus
            // 
            this.errorProviderStatus.ContainerControl = this;
            // 
            // errorProviderOwner
            // 
            this.errorProviderOwner.ContainerControl = this;
            // 
            // lblProjectID
            // 
            this.lblProjectID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(79, 18);
            this.lblProjectID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(84, 20);
            this.lblProjectID.TabIndex = 49;
            this.lblProjectID.Text = "Project ID";
            // 
            // errorProviderDescription
            // 
            this.errorProviderDescription.ContainerControl = this;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(675, 19);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(25, 24);
            this.btnAddNew.TabIndex = 54;
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // TaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 573);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbTaskId);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.dateTimePickerComplitionDate);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.ComboOwner);
            this.Controls.Add(this.txtTaskname);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblCompletionDate);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblOwner);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.comboProjectID);
            this.Controls.Add(this.richTxtDesc);
            this.Controls.Add(this.comboTaskType);
            this.Controls.Add(this.lblTasktype);
            this.Controls.Add(this.dataGridViewTaskInfo);
            this.Controls.Add(this.LblProject);
            this.Controls.Add(this.lblProjectID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskManagement";
            this.Text = "TaskManagement";
            this.Load += new System.EventHandler(this.TaskManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaskName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaskType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaskID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProjectId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTaskId;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerComplitionDate;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.ComboBox ComboOwner;
        private System.Windows.Forms.TextBox txtTaskname;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblCompletionDate;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblOwner;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Label TaskName;
        private System.Windows.Forms.ErrorProvider errorProviderProject;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.ComboBox comboProjectID;
        private System.Windows.Forms.RichTextBox richTxtDesc;
        private System.Windows.Forms.ComboBox comboTaskType;
        private System.Windows.Forms.Label lblTasktype;
        private System.Windows.Forms.DataGridView dataGridViewTaskInfo;
        private System.Windows.Forms.Label LblProject;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.ErrorProvider errorProviderTaskName;
        private System.Windows.Forms.ErrorProvider errorProviderCD;
        private System.Windows.Forms.ErrorProvider errorProviderSD;
        private System.Windows.Forms.ErrorProvider errorProviderTaskType;
        private System.Windows.Forms.ErrorProvider errorProviderTaskID;
        private System.Windows.Forms.ErrorProvider errorProviderProjectId;
        private System.Windows.Forms.ErrorProvider errorProviderStatus;
        private System.Windows.Forms.ErrorProvider errorProviderOwner;
        private System.Windows.Forms.ErrorProvider errorProviderDescription;
        private System.Windows.Forms.Button btnAddNew;
    }
}