namespace Polygraphy
{
    partial class FormCustomers
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
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tbSale = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteCustomer.Location = new System.Drawing.Point(18, 363);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(487, 31);
            this.btnDeleteCustomer.TabIndex = 79;
            this.btnDeleteCustomer.Text = "Удалить";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Enabled = false;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditCustomer.Location = new System.Drawing.Point(18, 317);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(487, 31);
            this.btnEditCustomer.TabIndex = 78;
            this.btnEditCustomer.Text = "Изменить";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPhone.Location = new System.Drawing.Point(151, 120);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(12);
            this.tbPhone.MaxLength = 12;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(173, 29);
            this.tbPhone.TabIndex = 75;
            // 
            // tbPassport
            // 
            this.tbPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPassport.Location = new System.Drawing.Point(129, 173);
            this.tbPassport.Margin = new System.Windows.Forms.Padding(12);
            this.tbPassport.MaxLength = 9;
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(195, 29);
            this.tbPassport.TabIndex = 74;
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassport.Location = new System.Drawing.Point(39, 173);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(91, 24);
            this.lblPassport.TabIndex = 72;
            this.lblPassport.Text = "Паспорт:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPhone.Location = new System.Drawing.Point(36, 120);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(116, 24);
            this.lblPhone.TabIndex = 71;
            this.lblPhone.Text = "Телефон:  +";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbAddress.Location = new System.Drawing.Point(129, 67);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(12);
            this.tbAddress.MaxLength = 100;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(376, 29);
            this.tbAddress.TabIndex = 70;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddress.Location = new System.Drawing.Point(59, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 24);
            this.lblAddress.TabIndex = 69;
            this.lblAddress.Text = "Адрес:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbName.Location = new System.Drawing.Point(129, 14);
            this.tbName.Margin = new System.Windows.Forms.Padding(12);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(376, 29);
            this.tbName.TabIndex = 68;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblName.Location = new System.Drawing.Point(72, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 24);
            this.lblName.TabIndex = 64;
            this.lblName.Text = "ФИО:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 270);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(487, 31);
            this.btnAddCustomer.TabIndex = 63;
            this.btnAddCustomer.Text = "Добавить";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // tbSale
            // 
            this.tbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbSale.Location = new System.Drawing.Point(129, 226);
            this.tbSale.Margin = new System.Windows.Forms.Padding(12);
            this.tbSale.MaxLength = 9;
            this.tbSale.Name = "tbSale";
            this.tbSale.Size = new System.Drawing.Size(195, 29);
            this.tbSale.TabIndex = 81;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSale.Location = new System.Drawing.Point(39, 226);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(79, 24);
            this.lblSale.TabIndex = 80;
            this.lblSale.Text = "Скидка:";
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 405);
            this.Controls.Add(this.tbSale);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказчики";
            this.Shown += new System.EventHandler(this.FormCustomers_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox tbSale;
        private System.Windows.Forms.Label lblSale;

    }
}