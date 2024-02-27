namespace HRMS
{
    partial class DashboardPMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPMS));
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sprintPlanning = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueReport = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.fileAttachment = new System.Windows.Forms.ToolStripMenuItem();
            this.pmsDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprintPlanning,
            this.IssueReport,
            this.TaskManagement,
            this.ProjectManagement,
            this.fileAttachment});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(172, 541);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sprintPlanning
            // 
            this.sprintPlanning.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sprintPlanning.ForeColor = System.Drawing.Color.Black;
            this.sprintPlanning.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sprintPlanning.Name = "sprintPlanning";
            this.sprintPlanning.Size = new System.Drawing.Size(159, 25);
            this.sprintPlanning.Text = "Sprint Planning";
            this.sprintPlanning.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // IssueReport
            // 
            this.IssueReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IssueReport.ForeColor = System.Drawing.Color.Black;
            this.IssueReport.Name = "IssueReport";
            this.IssueReport.Size = new System.Drawing.Size(159, 25);
            this.IssueReport.Text = "Issue Report";
            this.IssueReport.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.IssueReport.Click += new System.EventHandler(this.IssueReport_Click);
            // 
            // TaskManagement
            // 
            this.TaskManagement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TaskManagement.ForeColor = System.Drawing.Color.Black;
            this.TaskManagement.Name = "TaskManagement";
            this.TaskManagement.Size = new System.Drawing.Size(159, 25);
            this.TaskManagement.Text = "Task Management";
            this.TaskManagement.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TaskManagement.Click += new System.EventHandler(this.TaskManagement_Click);
            // 
            // ProjectManagement
            // 
            this.ProjectManagement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProjectManagement.ForeColor = System.Drawing.Color.Black;
            this.ProjectManagement.Name = "ProjectManagement";
            this.ProjectManagement.Size = new System.Drawing.Size(159, 25);
            this.ProjectManagement.Text = "Project Management";
            this.ProjectManagement.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ProjectManagement.Click += new System.EventHandler(this.ProjectManagement_Click);
            // 
            // fileAttachment
            // 
            this.fileAttachment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAttachment.Name = "fileAttachment";
            this.fileAttachment.Size = new System.Drawing.Size(159, 25);
            this.fileAttachment.Text = "File Attachment";
            this.fileAttachment.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // pmsDockPanel
            // 
            this.pmsDockPanel.AutoScroll = true;
            this.pmsDockPanel.AutoScrollMinSize = new System.Drawing.Size(75, 75);
            this.pmsDockPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pmsDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pmsDockPanel.Location = new System.Drawing.Point(172, 0);
            this.pmsDockPanel.Name = "pmsDockPanel";
            this.pmsDockPanel.Size = new System.Drawing.Size(886, 541);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            autoHideStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            dockPaneStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.pmsDockPanel.Skin = dockPanelSkin1;
            this.pmsDockPanel.TabIndex = 22;
            // 
            // DashboardPMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 541);
            this.Controls.Add(this.pmsDockPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Name = "DashboardPMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardPMS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sprintPlanning;
        private System.Windows.Forms.ToolStripMenuItem IssueReport;
        private System.Windows.Forms.ToolStripMenuItem TaskManagement;
        private System.Windows.Forms.ToolStripMenuItem ProjectManagement;
        private WeifenLuo.WinFormsUI.Docking.DockPanel pmsDockPanel;
        private System.Windows.Forms.ToolStripMenuItem fileAttachment;
    }
}