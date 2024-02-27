namespace ProjectManagement
{
    partial class Project_ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project_ManagementForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProject_id = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblExpectedEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblProjectname = new System.Windows.Forms.Label();
            this.lblActualEnddate = new System.Windows.Forms.Label();
            this.dateTimePickerActualEnddate = new System.Windows.Forms.DateTimePicker();
            this.lblTechnology = new System.Windows.Forms.Label();
            this.txtTechnology = new System.Windows.Forms.TextBox();
            this.cmbProjectId = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RequiredTools = new System.Windows.Forms.Label();
            this.richtxtRequiredTools = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewProjectManagement = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(433, 206);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 24);
            this.btnSave.TabIndex = 10;
            this.btnSave.Tag = "";
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblProject_id
            // 
            this.lblProject_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProject_id.AutoSize = true;
            this.lblProject_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject_id.Location = new System.Drawing.Point(42, 12);
            this.lblProject_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProject_id.Name = "lblProject_id";
            this.lblProject_id.Size = new System.Drawing.Size(80, 20);
            this.lblProject_id.TabIndex = 29;
            this.lblProject_id.Text = "Project Id";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(559, 206);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 24);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(214, 166);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(109, 23);
            this.dateTimePickerEndDate.TabIndex = 5;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(214, 121);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(109, 23);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManagerName.Location = new System.Drawing.Point(214, 85);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(109, 23);
            this.txtManagerName.TabIndex = 3;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProjectName.Location = new System.Drawing.Point(214, 44);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(109, 23);
            this.txtProjectName.TabIndex = 2;
            this.txtProjectName.Text = " ";
            // 
            // lblExpectedEndDate
            // 
            this.lblExpectedEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExpectedEndDate.AutoSize = true;
            this.lblExpectedEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedEndDate.Location = new System.Drawing.Point(42, 166);
            this.lblExpectedEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpectedEndDate.Name = "lblExpectedEndDate";
            this.lblExpectedEndDate.Size = new System.Drawing.Size(153, 20);
            this.lblExpectedEndDate.TabIndex = 23;
            this.lblExpectedEndDate.Text = "Expected End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(42, 123);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(86, 20);
            this.lblStartDate.TabIndex = 22;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblManagerName
            // 
            this.lblManagerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerName.Location = new System.Drawing.Point(42, 82);
            this.lblManagerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(123, 20);
            this.lblManagerName.TabIndex = 21;
            this.lblManagerName.Text = "Manager Name";
            // 
            // lblProjectname
            // 
            this.lblProjectname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProjectname.AutoSize = true;
            this.lblProjectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectname.Location = new System.Drawing.Point(42, 46);
            this.lblProjectname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectname.Name = "lblProjectname";
            this.lblProjectname.Size = new System.Drawing.Size(116, 20);
            this.lblProjectname.TabIndex = 20;
            this.lblProjectname.Text = "Project Name ";
            // 
            // lblActualEnddate
            // 
            this.lblActualEnddate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActualEnddate.AutoSize = true;
            this.lblActualEnddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualEnddate.Location = new System.Drawing.Point(42, 208);
            this.lblActualEnddate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualEnddate.Name = "lblActualEnddate";
            this.lblActualEnddate.Size = new System.Drawing.Size(131, 20);
            this.lblActualEnddate.TabIndex = 32;
            this.lblActualEnddate.Text = "Actual End Date";
            // 
            // dateTimePickerActualEnddate
            // 
            this.dateTimePickerActualEnddate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerActualEnddate.Location = new System.Drawing.Point(214, 208);
            this.dateTimePickerActualEnddate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerActualEnddate.Name = "dateTimePickerActualEnddate";
            this.dateTimePickerActualEnddate.Size = new System.Drawing.Size(109, 23);
            this.dateTimePickerActualEnddate.TabIndex = 6;
            // 
            // lblTechnology
            // 
            this.lblTechnology.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTechnology.AutoSize = true;
            this.lblTechnology.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnology.Location = new System.Drawing.Point(375, 12);
            this.lblTechnology.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTechnology.Name = "lblTechnology";
            this.lblTechnology.Size = new System.Drawing.Size(94, 20);
            this.lblTechnology.TabIndex = 35;
            this.lblTechnology.Text = "Technology";
            // 
            // txtTechnology
            // 
            this.txtTechnology.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTechnology.Location = new System.Drawing.Point(547, 11);
            this.txtTechnology.Margin = new System.Windows.Forms.Padding(2);
            this.txtTechnology.MaxLength = 15;
            this.txtTechnology.Name = "txtTechnology";
            this.txtTechnology.Size = new System.Drawing.Size(109, 23);
            this.txtTechnology.TabIndex = 7;
            // 
            // cmbProjectId
            // 
            this.cmbProjectId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbProjectId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectId.Items.AddRange(new object[] {
            "0"});
            this.cmbProjectId.Location = new System.Drawing.Point(214, 9);
            this.cmbProjectId.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProjectId.Name = "cmbProjectId";
            this.cmbProjectId.Size = new System.Drawing.Size(109, 25);
            this.cmbProjectId.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(193, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(193, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(193, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(193, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(526, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(193, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "*";
            // 
            // RequiredTools
            // 
            this.RequiredTools.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RequiredTools.AutoSize = true;
            this.RequiredTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiredTools.Location = new System.Drawing.Point(375, 46);
            this.RequiredTools.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RequiredTools.Name = "RequiredTools";
            this.RequiredTools.Size = new System.Drawing.Size(122, 20);
            this.RequiredTools.TabIndex = 46;
            this.RequiredTools.Text = "Required Tools";
            // 
            // richtxtRequiredTools
            // 
            this.richtxtRequiredTools.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richtxtRequiredTools.Location = new System.Drawing.Point(547, 44);
            this.richtxtRequiredTools.Margin = new System.Windows.Forms.Padding(2);
            this.richtxtRequiredTools.MaxLength = 100;
            this.richtxtRequiredTools.Name = "richtxtRequiredTools";
            this.richtxtRequiredTools.Size = new System.Drawing.Size(170, 60);
            this.richtxtRequiredTools.TabIndex = 8;
            this.richtxtRequiredTools.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(526, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 25);
            this.label9.TabIndex = 48;
            this.label9.Text = "*";
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(375, 121);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(95, 20);
            this.Description.TabIndex = 49;
            this.Description.Text = "Description";
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richtxtDescription.Location = new System.Drawing.Point(547, 121);
            this.richtxtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richtxtDescription.MaxLength = 200;
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.Size = new System.Drawing.Size(170, 57);
            this.richtxtDescription.TabIndex = 9;
            this.richtxtDescription.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(526, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "*";
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // dataGridViewProjectManagement
            // 
            this.dataGridViewProjectManagement.AllowUserToAddRows = false;
            this.dataGridViewProjectManagement.AllowUserToDeleteRows = false;
            this.dataGridViewProjectManagement.AllowUserToResizeColumns = false;
            this.dataGridViewProjectManagement.AllowUserToResizeRows = false;
            this.dataGridViewProjectManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewProjectManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewProjectManagement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewProjectManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectManagement.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProjectManagement.Location = new System.Drawing.Point(45, 247);
            this.dataGridViewProjectManagement.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProjectManagement.Name = "dataGridViewProjectManagement";
            this.dataGridViewProjectManagement.ReadOnly = true;
            this.dataGridViewProjectManagement.RowHeadersWidth = 51;
            this.dataGridViewProjectManagement.RowTemplate.Height = 24;
            this.dataGridViewProjectManagement.Size = new System.Drawing.Size(672, 202);
            this.dataGridViewProjectManagement.TabIndex = 52;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(328, 9);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(16, 20);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Project_ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(741, 525);
            this.Controls.Add(this.dataGridViewProjectManagement);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richtxtDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richtxtRequiredTools);
            this.Controls.Add(this.RequiredTools);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbProjectId);
            this.Controls.Add(this.txtTechnology);
            this.Controls.Add(this.lblTechnology);
            this.Controls.Add(this.dateTimePickerActualEnddate);
            this.Controls.Add(this.lblActualEnddate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProject_id);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblExpectedEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblManagerName);
            this.Controls.Add(this.lblProjectname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Project_ManagementForm";
            this.Text = "Project_Management";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProject_id;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblExpectedEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label lblProjectname;
        private System.Windows.Forms.Label lblActualEnddate;
        private System.Windows.Forms.DateTimePicker dateTimePickerActualEnddate;
        private System.Windows.Forms.Label lblTechnology;
        private System.Windows.Forms.TextBox txtTechnology;
        public System.Windows.Forms.ComboBox cmbProjectId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RequiredTools;
        private System.Windows.Forms.RichTextBox richtxtDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richtxtRequiredTools;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.DataGridView dataGridViewProjectManagement;
    }
}

