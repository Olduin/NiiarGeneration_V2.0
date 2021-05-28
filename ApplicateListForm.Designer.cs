namespace NiiarGeneration
{
    partial class ApplicateListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicateListForm));
            this.dgApplications = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAddApplicat = new System.Windows.Forms.ToolStripButton();
            this.btVehicles = new System.Windows.Forms.ToolStripButton();
            this.btType = new System.Windows.Forms.ToolStripButton();
            this.btTypeWork = new System.Windows.Forms.ToolStripButton();
            this.btCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.CbType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgApplications)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgApplications
            // 
            this.dgApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgApplications.Location = new System.Drawing.Point(0, 0);
            this.dgApplications.Name = "dgApplications";
            this.dgApplications.Size = new System.Drawing.Size(853, 375);
            this.dgApplications.TabIndex = 0;
            this.dgApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgApplications_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAddApplicat,
            this.btVehicles,
            this.btType,
            this.btTypeWork,
            this.btCustomer,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.CbType,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAddApplicat
            // 
            this.btAddApplicat.Image = ((System.Drawing.Image)(resources.GetObject("btAddApplicat.Image")));
            this.btAddApplicat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddApplicat.Name = "btAddApplicat";
            this.btAddApplicat.Size = new System.Drawing.Size(117, 22);
            this.btAddApplicat.Text = "Добавить заявку";
            this.btAddApplicat.Click += new System.EventHandler(this.btAddApplicat_Click_1);
            // 
            // btVehicles
            // 
            this.btVehicles.Image = ((System.Drawing.Image)(resources.GetObject("btVehicles.Image")));
            this.btVehicles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btVehicles.Name = "btVehicles";
            this.btVehicles.Size = new System.Drawing.Size(161, 22);
            this.btVehicles.Text = "Справочник транспорта";
            this.btVehicles.Click += new System.EventHandler(this.btVehicles_Click);
            // 
            // btType
            // 
            this.btType.Image = ((System.Drawing.Image)(resources.GetObject("btType.Image")));
            this.btType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btType.Name = "btType";
            this.btType.Size = new System.Drawing.Size(130, 22);
            this.btType.Text = "Справочник типов";
            this.btType.Click += new System.EventHandler(this.btType_Click);
            // 
            // btTypeWork
            // 
            this.btTypeWork.Image = ((System.Drawing.Image)(resources.GetObject("btTypeWork.Image")));
            this.btTypeWork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTypeWork.Name = "btTypeWork";
            this.btTypeWork.Size = new System.Drawing.Size(91, 22);
            this.btTypeWork.Text = "Виды работ";
            this.btTypeWork.ToolTipText = "Виды работ";
            this.btTypeWork.Click += new System.EventHandler(this.btTypeWork_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btCustomer.Image")));
            this.btCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(84, 22);
            this.btCustomer.Text = "Заявители";
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel1.Text = "Фильтры";
            // 
            // CbType
            // 
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(121, 25);
            this.CbType.SelectedIndexChanged += new System.EventHandler(this.CbType_SelectedIndexChanged);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgApplications);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(853, 375);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(853, 400);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // ApplicateListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 400);
            this.Controls.Add(this.toolStripContainer1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicateListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки";
            ((System.ComponentModel.ISupportInitialize)(this.dgApplications)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgApplications;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAddApplicat;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripButton btVehicles;
        private System.Windows.Forms.ToolStripButton btType;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton btTypeWork;
        private System.Windows.Forms.ToolStripButton btCustomer;
        private System.Windows.Forms.ToolStripComboBox CbType;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}