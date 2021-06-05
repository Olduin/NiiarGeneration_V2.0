﻿
namespace NiiarGeneration
{
    partial class CustomerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditForm));
            this.btCansel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbResponsible = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCansel
            // 
            this.btCansel.BackColor = System.Drawing.SystemColors.Window;
            this.btCansel.Location = new System.Drawing.Point(334, 93);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(87, 23);
            this.btCansel.TabIndex = 27;
            this.btCansel.Text = "Отмена";
            this.btCansel.UseVisualStyleBackColor = false;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Window;
            this.btSave.Location = new System.Drawing.Point(231, 93);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 23);
            this.btSave.TabIndex = 26;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ответсвенное лицо";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Наименование заявителя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(147, 12);
            this.tbName.Name = "tbName";
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbName.Size = new System.Drawing.Size(274, 20);
            this.tbName.TabIndex = 22;
            // 
            // tbResponsible
            // 
            this.tbResponsible.Location = new System.Drawing.Point(147, 41);
            this.tbResponsible.Name = "tbResponsible";
            this.tbResponsible.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbResponsible.Size = new System.Drawing.Size(274, 20);
            this.tbResponsible.TabIndex = 28;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(147, 67);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPhone.Size = new System.Drawing.Size(274, 20);
            this.tbPhone.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(89, 70);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Телефон";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 125);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResponsible);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerEditForm";
            this.Text = "Редактирование данных о заявителе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCansel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbResponsible;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
    }
}