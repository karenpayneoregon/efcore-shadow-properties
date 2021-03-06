﻿namespace DemoShadowProperties
{
    partial class ContactForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNewContactButton = new System.Windows.Forms.Button();
            this.LastNameAddTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameAddTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateCurrentContactButton = new System.Windows.Forms.Button();
            this.LastNameEditTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameEditTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentContactButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdentifierColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.LastUpdatedColumn,
            this.LastUserColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(592, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdentifierColumn
            // 
            this.IdentifierColumn.DataPropertyName = "ContactId";
            this.IdentifierColumn.HeaderText = "Id";
            this.IdentifierColumn.Name = "IdentifierColumn";
            this.IdentifierColumn.ReadOnly = true;
            this.IdentifierColumn.Width = 50;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "FirstName";
            this.FirstNameColumn.HeaderText = "First";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.DataPropertyName = "LastName";
            this.LastNameColumn.HeaderText = "Last";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            // 
            // LastUpdatedColumn
            // 
            this.LastUpdatedColumn.DataPropertyName = "LastUpdated";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.LastUpdatedColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.LastUpdatedColumn.HeaderText = "Updated";
            this.LastUpdatedColumn.Name = "LastUpdatedColumn";
            this.LastUpdatedColumn.ReadOnly = true;
            this.LastUpdatedColumn.Width = 150;
            // 
            // LastUserColumn
            // 
            this.LastUserColumn.DataPropertyName = "Lastuser";
            this.LastUserColumn.HeaderText = "User";
            this.LastUserColumn.Name = "LastUserColumn";
            this.LastUserColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNewContactButton);
            this.groupBox1.Controls.Add(this.LastNameAddTextBox);
            this.groupBox1.Controls.Add(this.FirstNameAddTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add contact";
            // 
            // AddNewContactButton
            // 
            this.AddNewContactButton.Location = new System.Drawing.Point(85, 81);
            this.AddNewContactButton.Name = "AddNewContactButton";
            this.AddNewContactButton.Size = new System.Drawing.Size(173, 23);
            this.AddNewContactButton.TabIndex = 4;
            this.AddNewContactButton.Text = "Add new contact";
            this.AddNewContactButton.UseVisualStyleBackColor = true;
            this.AddNewContactButton.Click += new System.EventHandler(this.AddNewContactButton_Click);
            // 
            // LastNameAddTextBox
            // 
            this.LastNameAddTextBox.Location = new System.Drawing.Point(85, 55);
            this.LastNameAddTextBox.Name = "LastNameAddTextBox";
            this.LastNameAddTextBox.Size = new System.Drawing.Size(173, 20);
            this.LastNameAddTextBox.TabIndex = 3;
            // 
            // FirstNameAddTextBox
            // 
            this.FirstNameAddTextBox.Location = new System.Drawing.Point(85, 29);
            this.FirstNameAddTextBox.Name = "FirstNameAddTextBox";
            this.FirstNameAddTextBox.Size = new System.Drawing.Size(173, 20);
            this.FirstNameAddTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateCurrentContactButton);
            this.groupBox2.Controls.Add(this.LastNameEditTextBox);
            this.groupBox2.Controls.Add(this.FirstNameEditTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(312, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit current contact";
            // 
            // UpdateCurrentContactButton
            // 
            this.UpdateCurrentContactButton.Enabled = false;
            this.UpdateCurrentContactButton.Location = new System.Drawing.Point(85, 81);
            this.UpdateCurrentContactButton.Name = "UpdateCurrentContactButton";
            this.UpdateCurrentContactButton.Size = new System.Drawing.Size(173, 23);
            this.UpdateCurrentContactButton.TabIndex = 4;
            this.UpdateCurrentContactButton.Text = "Update current contact";
            this.UpdateCurrentContactButton.UseVisualStyleBackColor = true;
            this.UpdateCurrentContactButton.Click += new System.EventHandler(this.UpdateCurrentContactButton_Click);
            // 
            // LastNameEditTextBox
            // 
            this.LastNameEditTextBox.Location = new System.Drawing.Point(85, 55);
            this.LastNameEditTextBox.Name = "LastNameEditTextBox";
            this.LastNameEditTextBox.Size = new System.Drawing.Size(173, 20);
            this.LastNameEditTextBox.TabIndex = 3;
            // 
            // FirstNameEditTextBox
            // 
            this.FirstNameEditTextBox.Location = new System.Drawing.Point(85, 29);
            this.FirstNameEditTextBox.Name = "FirstNameEditTextBox";
            this.FirstNameEditTextBox.Size = new System.Drawing.Size(173, 20);
            this.FirstNameEditTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // CurrentContactButton
            // 
            this.CurrentContactButton.Enabled = false;
            this.CurrentContactButton.Location = new System.Drawing.Point(397, 272);
            this.CurrentContactButton.Name = "CurrentContactButton";
            this.CurrentContactButton.Size = new System.Drawing.Size(173, 23);
            this.CurrentContactButton.TabIndex = 6;
            this.CurrentContactButton.Text = "Current contact";
            this.CurrentContactButton.UseVisualStyleBackColor = true;
            this.CurrentContactButton.Click += new System.EventHandler(this.CurrentContactButton_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 326);
            this.Controls.Add(this.CurrentContactButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shadow properties";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddNewContactButton;
        private System.Windows.Forms.TextBox LastNameAddTextBox;
        private System.Windows.Forms.TextBox FirstNameAddTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUserColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UpdateCurrentContactButton;
        private System.Windows.Forms.TextBox LastNameEditTextBox;
        private System.Windows.Forms.TextBox FirstNameEditTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CurrentContactButton;
    }
}

