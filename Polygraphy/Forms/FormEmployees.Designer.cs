namespace Polygraphy
{
    partial class FormEmployees
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.rbMen = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWomen = new System.Windows.Forms.RadioButton();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbAddress.Location = new System.Drawing.Point(127, 176);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(12);
            this.tbAddress.MaxLength = 100;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(376, 29);
            this.tbAddress.TabIndex = 51;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddress.Location = new System.Drawing.Point(57, 176);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 24);
            this.lblAddress.TabIndex = 50;
            this.lblAddress.Text = "Адрес:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbName.Location = new System.Drawing.Point(127, 17);
            this.tbName.Margin = new System.Windows.Forms.Padding(12);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(376, 29);
            this.tbName.TabIndex = 49;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbAge.Location = new System.Drawing.Point(127, 70);
            this.tbAge.Margin = new System.Windows.Forms.Padding(12);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(69, 29);
            this.tbAge.TabIndex = 48;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsex.Location = new System.Drawing.Point(80, 123);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(49, 24);
            this.lblsex.TabIndex = 46;
            this.lblsex.Text = "Пол:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAge.Location = new System.Drawing.Point(40, 70);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(89, 24);
            this.lblAge.TabIndex = 45;
            this.lblAge.Text = "Возраст:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblName.Location = new System.Drawing.Point(70, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 24);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "ФИО:";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddEmployee.Location = new System.Drawing.Point(16, 379);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(487, 31);
            this.btnAddEmployee.TabIndex = 43;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPhone.Location = new System.Drawing.Point(149, 229);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(12);
            this.tbPhone.MaxLength = 12;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(173, 29);
            this.tbPhone.TabIndex = 57;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // tbPassport
            // 
            this.tbPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPassport.Location = new System.Drawing.Point(127, 282);
            this.tbPassport.Margin = new System.Windows.Forms.Padding(12);
            this.tbPassport.MaxLength = 9;
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(195, 29);
            this.tbPassport.TabIndex = 56;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPosition.Location = new System.Drawing.Point(12, 335);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(117, 24);
            this.lblPosition.TabIndex = 54;
            this.lblPosition.Text = "Должность:";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassport.Location = new System.Drawing.Point(37, 282);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(91, 24);
            this.lblPassport.TabIndex = 53;
            this.lblPassport.Text = "Паспорт:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPhone.Location = new System.Drawing.Point(34, 229);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(116, 24);
            this.lblPhone.TabIndex = 52;
            this.lblPhone.Text = "Телефон:  +";
            // 
            // rbMen
            // 
            this.rbMen.AutoSize = true;
            this.rbMen.Checked = true;
            this.rbMen.Location = new System.Drawing.Point(7, 13);
            this.rbMen.Name = "rbMen";
            this.rbMen.Size = new System.Drawing.Size(34, 17);
            this.rbMen.TabIndex = 58;
            this.rbMen.TabStop = true;
            this.rbMen.Text = "М";
            this.rbMen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rbWomen);
            this.groupBox1.Controls.Add(this.rbMen);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(127, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 38);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // rbWomen
            // 
            this.rbWomen.AutoSize = true;
            this.rbWomen.Location = new System.Drawing.Point(47, 13);
            this.rbWomen.Name = "rbWomen";
            this.rbWomen.Size = new System.Drawing.Size(36, 17);
            this.rbWomen.TabIndex = 60;
            this.rbWomen.TabStop = true;
            this.rbWomen.Text = "Ж";
            this.rbWomen.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            this.cbPosition.AutoCompleteCustomSource.AddRange(new string[] {
            "Главный менеджер",
            "Менеджер"});
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.ItemHeight = 13;
            this.cbPosition.Items.AddRange(new object[] {
            "Администратор",
            "Главный менеджер",
            "Менеджер"});
            this.cbPosition.Location = new System.Drawing.Point(127, 340);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(376, 21);
            this.cbPosition.TabIndex = 60;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Enabled = false;
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditEmployee.Location = new System.Drawing.Point(16, 426);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(487, 31);
            this.btnEditEmployee.TabIndex = 61;
            this.btnEditEmployee.Text = "Изменить";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Enabled = false;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteEmployee.Location = new System.Drawing.Point(16, 472);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(487, 31);
            this.btnDeleteEmployee.TabIndex = 62;
            this.btnDeleteEmployee.Text = "Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 515);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.FormEmployees_Load);
            this.Shown += new System.EventHandler(this.FormEmployees_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.RadioButton rbMen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWomen;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;

    }
}