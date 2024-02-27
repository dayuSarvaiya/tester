namespace PMS
{
    partial class FileAttchment
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
            this.openFileDialogBrowes = new System.Windows.Forms.OpenFileDialog();
            this.errorProjectid = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFileName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorattchtype = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSubmitFile = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialogMulti = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFileSubmit = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.comboattch = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProjectid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorattchtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubmitFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogBrowes
            // 
            this.openFileDialogBrowes.FileName = "openFileDialog1";
            // 
            // errorProjectid
            // 
            this.errorProjectid.ContainerControl = this;
            // 
            // errorFileName
            // 
            this.errorFileName.ContainerControl = this;
            // 
            // errorattchtype
            // 
            this.errorattchtype.ContainerControl = this;
            // 
            // errorDesc
            // 
            this.errorDesc.ContainerControl = this;
            // 
            // errorSubmitFile
            // 
            this.errorSubmitFile.ContainerControl = this;
            // 
            // openFileDialogMulti
            // 
            this.openFileDialogMulti.FileName = "openFileDialog2";
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
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(311, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtFileSubmit
            // 
            this.txtFileSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFileSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileSubmit.Location = new System.Drawing.Point(155, 259);
            this.txtFileSubmit.Name = "txtFileSubmit";
            this.txtFileSubmit.Size = new System.Drawing.Size(144, 23);
            this.txtFileSubmit.TabIndex = 27;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(155, 140);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(226, 96);
            this.txtDesc.TabIndex = 26;
            // 
            // comboattch
            // 
            this.comboattch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboattch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboattch.FormattingEnabled = true;
            this.comboattch.Items.AddRange(new object[] {
            "Image File",
            "PDF",
            "DOCX",
            "XLSX",
            "Zip",
            "CSV"});
            this.comboattch.Location = new System.Drawing.Point(155, 96);
            this.comboattch.Name = "comboattch";
            this.comboattch.Size = new System.Drawing.Size(128, 24);
            this.comboattch.TabIndex = 25;
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(155, 52);
            this.txtFileName.MaxLength = 30;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(166, 23);
            this.txtFileName.TabIndex = 24;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectID.Location = new System.Drawing.Point(155, 9);
            this.txtProjectID.MaxLength = 5;
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(166, 23);
            this.txtProjectID.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(240, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 25);
            this.button3.TabIndex = 22;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(115, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 25);
            this.button4.TabIndex = 21;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Attachment Type";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "File Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Project ID";
            // 
            // FileAttchment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtFileSubmit);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.comboattch);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FileAttchment";
            this.Text = "FileAttchment";
            this.Load += new System.EventHandler(this.FileAttchment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProjectid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorattchtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubmitFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowes;
        private System.Windows.Forms.ErrorProvider errorProjectid;
        private System.Windows.Forms.ErrorProvider errorFileName;
        private System.Windows.Forms.ErrorProvider errorattchtype;
        private System.Windows.Forms.ErrorProvider errorDesc;
        private System.Windows.Forms.ErrorProvider errorSubmitFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogMulti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFileSubmit;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox comboattch;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}