namespace HRMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picPMS = new System.Windows.Forms.PictureBox();
            this.picHRMS = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHRMS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PMS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "HRMS";
            // 
            // picPMS
            // 
            this.picPMS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picPMS.Image = ((System.Drawing.Image)(resources.GetObject("picPMS.Image")));
            this.picPMS.Location = new System.Drawing.Point(118, 173);
            this.picPMS.Name = "picPMS";
            this.picPMS.Size = new System.Drawing.Size(246, 172);
            this.picPMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPMS.TabIndex = 5;
            this.picPMS.TabStop = false;
            // 
            // picHRMS
            // 
            this.picHRMS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picHRMS.Image = ((System.Drawing.Image)(resources.GetObject("picHRMS.Image")));
            this.picHRMS.Location = new System.Drawing.Point(428, 173);
            this.picHRMS.Name = "picHRMS";
            this.picHRMS.Size = new System.Drawing.Size(246, 172);
            this.picHRMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHRMS.TabIndex = 6;
            this.picHRMS.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(763, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(35, 33);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(113, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "HUMAN CAPITAL AND  PROJECT MANAGEMENT SYSTEM";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.picHRMS);
            this.Controls.Add(this.picPMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHRMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPMS;
        private System.Windows.Forms.PictureBox picHRMS;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label3;
    }
}