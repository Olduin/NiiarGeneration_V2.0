﻿namespace NiiarGeneration
{
    partial class ApplicatItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicatItemsForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTypeApplicat = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.cbTypeApplicate = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCansel = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgApplicat = new System.Windows.Forms.DataGridView();
            this.btAddItem = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpDateApplicate = new System.Windows.Forms.DateTimePicker();
            this.CmApplicatItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addApplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.DelApplicate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgApplicat)).BeginInit();
            this.CmApplicatItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(10, 25);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(91, 20);
            this.tbId.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Location = new System.Drawing.Point(7, 9);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(80, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Номер заявки";
            // 
            // lbTypeApplicat
            // 
            this.lbTypeApplicat.AutoSize = true;
            this.lbTypeApplicat.BackColor = System.Drawing.Color.Transparent;
            this.lbTypeApplicat.Location = new System.Drawing.Point(114, 9);
            this.lbTypeApplicat.Name = "lbTypeApplicat";
            this.lbTypeApplicat.Size = new System.Drawing.Size(26, 13);
            this.lbTypeApplicat.TabIndex = 3;
            this.lbTypeApplicat.Text = "Тип";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Location = new System.Drawing.Point(274, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(72, 13);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "Дата заявки";
            // 
            // cbTypeApplicate
            // 
            this.cbTypeApplicate.FormattingEnabled = true;
            this.cbTypeApplicate.Location = new System.Drawing.Point(107, 25);
            this.cbTypeApplicate.Name = "cbTypeApplicate";
            this.cbTypeApplicate.Size = new System.Drawing.Size(164, 21);
            this.cbTypeApplicate.TabIndex = 7;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Window;
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSave.Location = new System.Drawing.Point(669, 347);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCansel
            // 
            this.btCansel.BackColor = System.Drawing.SystemColors.Window;
            this.btCansel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCansel.Location = new System.Drawing.Point(762, 347);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(87, 23);
            this.btCansel.TabIndex = 9;
            this.btCansel.Text = "Отмена";
            this.btCansel.UseVisualStyleBackColor = false;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dgApplicat
            // 
            this.dgApplicat.AllowUserToAddRows = false;
            this.dgApplicat.AllowUserToDeleteRows = false;
            this.dgApplicat.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgApplicat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApplicat.Location = new System.Drawing.Point(0, 52);
            this.dgApplicat.Name = "dgApplicat";
            this.dgApplicat.ReadOnly = true;
            this.dgApplicat.Size = new System.Drawing.Size(849, 294);
            this.dgApplicat.TabIndex = 12;
            this.dgApplicat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgApplicat_CellClick);
            this.dgApplicat.Click += new System.EventHandler(this.dgApplicat_Click);
            // 
            // btAddItem
            // 
            this.btAddItem.BackColor = System.Drawing.SystemColors.Window;
            this.btAddItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAddItem.Location = new System.Drawing.Point(0, 347);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(113, 23);
            this.btAddItem.TabIndex = 14;
            this.btAddItem.Text = "Добавить строку";
            this.btAddItem.UseVisualStyleBackColor = false;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDelete.Location = new System.Drawing.Point(119, 347);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(113, 23);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "Удалить строку";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(238, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Создать отчет";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpDateApplicate
            // 
            this.dtpDateApplicate.CustomFormat = "";
            this.dtpDateApplicate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateApplicate.Location = new System.Drawing.Point(277, 26);
            this.dtpDateApplicate.Name = "dtpDateApplicate";
            this.dtpDateApplicate.Size = new System.Drawing.Size(200, 20);
            this.dtpDateApplicate.TabIndex = 17;
            // 
            // CmApplicatItems
            // 
            this.CmApplicatItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addApplicate,
            this.DelApplicate});
            this.CmApplicatItems.Name = "CmApplicatItems";
            this.CmApplicatItems.Size = new System.Drawing.Size(167, 48);
            // 
            // addApplicate
            // 
            this.addApplicate.Name = "addApplicate";
            this.addApplicate.Size = new System.Drawing.Size(166, 22);
            this.addApplicate.Text = "Добавить строку";
            this.addApplicate.Click += new System.EventHandler(this.addApplicate_Click);
            // 
            // DelApplicate
            // 
            this.DelApplicate.Name = "DelApplicate";
            this.DelApplicate.Size = new System.Drawing.Size(166, 22);
            this.DelApplicate.Text = "Удалить строку";
            this.DelApplicate.Click += new System.EventHandler(this.DelApplicate_Click);
            // 
            // ApplicatItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 372);
            this.Controls.Add(this.dtpDateApplicate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddItem);
            this.Controls.Add(this.dgApplicat);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbTypeApplicate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTypeApplicat);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicatItemsForm";
            this.Text = "Строки заявки";
            this.Load += new System.EventHandler(this.ApplicatItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgApplicat)).EndInit();
            this.CmApplicatItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbTypeApplicat;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cbTypeApplicate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCansel;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView dgApplicat;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpDateApplicate;
        private System.Windows.Forms.ContextMenuStrip CmApplicatItems;
        private System.Windows.Forms.ToolStripMenuItem addApplicate;
        private System.Windows.Forms.ToolStripMenuItem DelApplicate;
    }
}