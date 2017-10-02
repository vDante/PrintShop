namespace Polygraphy
{
    partial class FormServices
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
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnEditService = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.cboxMaterialID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Enabled = false;
            this.btnDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteService.Location = new System.Drawing.Point(16, 312);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(487, 31);
            this.btnDeleteService.TabIndex = 92;
            this.btnDeleteService.Text = "Удалить";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnEditService
            // 
            this.btnEditService.Enabled = false;
            this.btnEditService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditService.Location = new System.Drawing.Point(16, 266);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(487, 31);
            this.btnEditService.TabIndex = 91;
            this.btnEditService.Text = "Изменить";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPrice.Location = new System.Drawing.Point(149, 118);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(12);
            this.tbPrice.MaxLength = 12;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(354, 29);
            this.tbPrice.TabIndex = 90;
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassport.Location = new System.Drawing.Point(48, 171);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(104, 24);
            this.lblPassport.TabIndex = 88;
            this.lblPassport.Text = "Материал:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPhone.Location = new System.Drawing.Point(92, 118);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 24);
            this.lblPhone.TabIndex = 87;
            this.lblPhone.Text = "Цена:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbDescription.Location = new System.Drawing.Point(149, 65);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(12);
            this.tbDescription.MaxLength = 100;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(354, 29);
            this.tbDescription.TabIndex = 86;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddress.Location = new System.Drawing.Point(45, 65);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(105, 24);
            this.lblAddress.TabIndex = 85;
            this.lblAddress.Text = "Описание:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbName.Location = new System.Drawing.Point(149, 12);
            this.tbName.Margin = new System.Windows.Forms.Padding(12);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(354, 29);
            this.tbName.TabIndex = 84;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblName.Location = new System.Drawing.Point(3, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 24);
            this.lblName.TabIndex = 83;
            this.lblName.Text = "Наименование:";
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddService.Location = new System.Drawing.Point(16, 219);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(487, 31);
            this.btnAddService.TabIndex = 82;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // cboxMaterialID
            // 
            this.cboxMaterialID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboxMaterialID.FormattingEnabled = true;
            this.cboxMaterialID.Location = new System.Drawing.Point(149, 172);
            this.cboxMaterialID.Name = "cboxMaterialID";
            this.cboxMaterialID.Size = new System.Drawing.Size(354, 28);
            this.cboxMaterialID.TabIndex = 95;
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 353);
            this.Controls.Add(this.cboxMaterialID);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnEditService);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Услуги";
            this.Shown += new System.EventHandler(this.FormServices_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ComboBox cboxMaterialID;

    }
}