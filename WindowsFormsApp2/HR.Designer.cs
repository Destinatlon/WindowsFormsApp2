
namespace WindowsFormsApp2
{
    partial class HR
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Legal = new System.Windows.Forms.Button();
            this.Private = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.legalCSV = new System.Windows.Forms.Button();
            this.privateCSV = new System.Windows.Forms.Button();
            this.employeeCSV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // Legal
            // 
            this.Legal.Location = new System.Drawing.Point(11, 79);
            this.Legal.Name = "Legal";
            this.Legal.Size = new System.Drawing.Size(224, 33);
            this.Legal.TabIndex = 1;
            this.Legal.Text = "Юридические лица";
            this.Legal.UseVisualStyleBackColor = true;
            this.Legal.Click += new System.EventHandler(this.Legal_Click);
            // 
            // Private
            // 
            this.Private.Location = new System.Drawing.Point(11, 108);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(224, 33);
            this.Private.TabIndex = 2;
            this.Private.Text = "Физические лица";
            this.Private.UseVisualStyleBackColor = true;
            this.Private.Click += new System.EventHandler(this.Private_Click);
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(11, 137);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(224, 33);
            this.Employee.TabIndex = 3;
            this.Employee.Text = "Работники";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Просмотр информации";
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(578, 79);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(424, 91);
            this.Updatebtn.TabIndex = 5;
            this.Updatebtn.Text = "Изменение данных";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // legalCSV
            // 
            this.legalCSV.Location = new System.Drawing.Point(265, 79);
            this.legalCSV.Name = "legalCSV";
            this.legalCSV.Size = new System.Drawing.Size(201, 33);
            this.legalCSV.TabIndex = 6;
            this.legalCSV.Text = "Юридические лица";
            this.legalCSV.UseVisualStyleBackColor = true;
            this.legalCSV.Click += new System.EventHandler(this.legalCSV_Click);
            // 
            // privateCSV
            // 
            this.privateCSV.Location = new System.Drawing.Point(265, 113);
            this.privateCSV.Name = "privateCSV";
            this.privateCSV.Size = new System.Drawing.Size(201, 28);
            this.privateCSV.TabIndex = 7;
            this.privateCSV.Text = "Физические лица";
            this.privateCSV.UseVisualStyleBackColor = true;
            this.privateCSV.Click += new System.EventHandler(this.privateCSV_Click);
            // 
            // employeeCSV
            // 
            this.employeeCSV.Location = new System.Drawing.Point(265, 142);
            this.employeeCSV.Name = "employeeCSV";
            this.employeeCSV.Size = new System.Drawing.Size(201, 28);
            this.employeeCSV.TabIndex = 8;
            this.employeeCSV.Text = "Работники";
            this.employeeCSV.UseVisualStyleBackColor = true;
            this.employeeCSV.Click += new System.EventHandler(this.employeeCSV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Генерировать таблицу в csv";
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeCSV);
            this.Controls.Add(this.privateCSV);
            this.Controls.Add(this.legalCSV);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Private);
            this.Controls.Add(this.Legal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HR";
            this.Text = "HR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HR_FormClosed);
            this.Load += new System.EventHandler(this.HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Legal;
        private System.Windows.Forms.Button Private;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button legalCSV;
        private System.Windows.Forms.Button privateCSV;
        private System.Windows.Forms.Button employeeCSV;
        private System.Windows.Forms.Label label2;
    }
}