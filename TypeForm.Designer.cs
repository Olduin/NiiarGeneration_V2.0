
namespace NiiarGeneration
{
    partial class TypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddItem = new System.Windows.Forms.Button();
            this.btCansel = new System.Windows.Forms.Button();
            this.dgType = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgType)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btSave);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btDelete);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btAddItem);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btCansel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgType);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(583, 334);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripContainer1.Size = new System.Drawing.Size(583, 334);
            this.toolStripContainer1.TabIndex = 28;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripContainer1.TopToolStripPanel.BackgroundImage")));
            this.toolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Window;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(407, 310);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 22);
            this.btSave.TabIndex = 31;
            this.btSave.Text = "Сохранить";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btDelete.Location = new System.Drawing.Point(113, 310);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(113, 22);
            this.btDelete.TabIndex = 30;
            this.btDelete.Text = "Удалить тип";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddItem
            // 
            this.btAddItem.BackColor = System.Drawing.SystemColors.Window;
            this.btAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAddItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAddItem.Location = new System.Drawing.Point(0, 310);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(113, 22);
            this.btAddItem.TabIndex = 29;
            this.btAddItem.Text = "Добавить тип";
            this.btAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddItem.UseVisualStyleBackColor = false;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // btCansel
            // 
            this.btCansel.BackColor = System.Drawing.SystemColors.Window;
            this.btCansel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCansel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCansel.Location = new System.Drawing.Point(494, 310);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(87, 22);
            this.btCansel.TabIndex = 28;
            this.btCansel.Text = "Отмена";
            this.btCansel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCansel.UseVisualStyleBackColor = false;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // dgType
            // 
            this.dgType.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgType.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgType.Location = new System.Drawing.Point(0, 0);
            this.dgType.Name = "dgType";
            this.dgType.Size = new System.Drawing.Size(581, 310);
            this.dgType.TabIndex = 24;
            this.dgType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgType_CellContentClick);
            this.dgType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgType_CellContentClick);
            // 
            // TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 334);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник типов заявки";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.DataGridView dgType;
        private System.Windows.Forms.Button btCansel;
        private System.Windows.Forms.Button btSave;
    }
}