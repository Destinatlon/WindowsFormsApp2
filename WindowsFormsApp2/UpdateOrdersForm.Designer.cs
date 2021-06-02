
namespace WindowsFormsApp2
{
    partial class UpdateOrdersForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.etcBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.providerBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.type_streetBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // etcBox
            // 
            this.etcBox.Location = new System.Drawing.Point(162, 283);
            this.etcBox.Multiline = true;
            this.etcBox.Name = "etcBox";
            this.etcBox.Size = new System.Drawing.Size(421, 206);
            this.etcBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип сервиса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Клиент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Поставщик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Цена";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(9, 443);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 22);
            this.priceBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Примечание";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(462, 11);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(140, 70);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Добавить заказ";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(12, 94);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 24);
            this.typeBox.TabIndex = 19;
            // 
            // clientBox
            // 
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(9, 337);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(121, 24);
            this.clientBox.TabIndex = 20;
            // 
            // providerBox
            // 
            this.providerBox.FormattingEnabled = true;
            this.providerBox.Location = new System.Drawing.Point(9, 395);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(121, 24);
            this.providerBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Работник";
            // 
            // employeeBox
            // 
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(9, 285);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(121, 24);
            this.employeeBox.TabIndex = 24;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(462, 114);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(140, 61);
            this.UpdateButton.TabIndex = 25;
            this.UpdateButton.Text = "Изменить заказ";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(237, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 21);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Текущая дата";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // type_streetBox
            // 
            this.type_streetBox.FormattingEnabled = true;
            this.type_streetBox.Items.AddRange(new object[] {
            "улица",
            "бульвар",
            "проспект",
            "переулок",
            "площадь",
            "спуск",
            "тракт",
            "проезд"});
            this.type_streetBox.Location = new System.Drawing.Point(13, 148);
            this.type_streetBox.Name = "type_streetBox";
            this.type_streetBox.Size = new System.Drawing.Size(121, 24);
            this.type_streetBox.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 29;
            // 
            // UpdateOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 503);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.type_streetBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.providerBox);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etcBox);
            this.Controls.Add(this.textBox1);
            this.Name = "UpdateOrdersForm";
            this.Text = "UpdateOrdersForm";
            this.Load += new System.EventHandler(this.UpdateOrdersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox etcBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.ComboBox providerBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox employeeBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox type_streetBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}