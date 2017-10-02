namespace Polygraphy
{
    partial class FormMaterials
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPackageCol = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.tbPackage = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnEditMaterial = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbDescription.Location = new System.Drawing.Point(154, 119);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(12);
            this.tbDescription.MaxLength = 100;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(376, 29);
            this.tbDescription.TabIndex = 38;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDescription.Location = new System.Drawing.Point(51, 119);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 24);
            this.lblDescription.TabIndex = 37;
            this.lblDescription.Text = "Описание:";
            // 
            // lblPackageCol
            // 
            this.lblPackageCol.AutoSize = true;
            this.lblPackageCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPackageCol.Location = new System.Drawing.Point(58, 66);
            this.lblPackageCol.Name = "lblPackageCol";
            this.lblPackageCol.Size = new System.Drawing.Size(98, 24);
            this.lblPackageCol.TabIndex = 35;
            this.lblPackageCol.Text = "Упаковка:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblName.Location = new System.Drawing.Point(7, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 24);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Наименование:";
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddMaterial.Location = new System.Drawing.Point(14, 216);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(519, 31);
            this.btnAddMaterial.TabIndex = 31;
            this.btnAddMaterial.Text = "Добавить";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // tbPackage
            // 
            this.tbPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPackage.Location = new System.Drawing.Point(154, 66);
            this.tbPackage.Margin = new System.Windows.Forms.Padding(12);
            this.tbPackage.MaxLength = 6;
            this.tbPackage.Name = "tbPackage";
            this.tbPackage.Size = new System.Drawing.Size(376, 29);
            this.tbPackage.TabIndex = 39;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbName.Location = new System.Drawing.Point(154, 13);
            this.tbName.Margin = new System.Windows.Forms.Padding(12);
            this.tbName.MaxLength = 45;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(376, 29);
            this.tbName.TabIndex = 40;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPrice.Location = new System.Drawing.Point(154, 172);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(12);
            this.tbPrice.MaxLength = 10;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(376, 29);
            this.tbPrice.TabIndex = 42;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPrice.Location = new System.Drawing.Point(97, 172);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 24);
            this.lblPrice.TabIndex = 41;
            this.lblPrice.Text = "Цена:";
            // 
            // btnEditMaterial
            // 
            this.btnEditMaterial.Enabled = false;
            this.btnEditMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditMaterial.Location = new System.Drawing.Point(14, 253);
            this.btnEditMaterial.Name = "btnEditMaterial";
            this.btnEditMaterial.Size = new System.Drawing.Size(519, 31);
            this.btnEditMaterial.TabIndex = 43;
            this.btnEditMaterial.Text = "Изменить";
            this.btnEditMaterial.UseVisualStyleBackColor = true;
            this.btnEditMaterial.Click += new System.EventHandler(this.btnEditMaterial_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Enabled = false;
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteMaterial.Location = new System.Drawing.Point(14, 290);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(519, 31);
            this.btnDeleteMaterial.TabIndex = 44;
            this.btnDeleteMaterial.Text = "Удалить";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // FormMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 332);
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.btnEditMaterial);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPackage);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPackageCol);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Материалы";
            this.Shown += new System.EventHandler(this.FormMaterials_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPackageCol;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.TextBox tbPackage;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnEditMaterial;
        private System.Windows.Forms.Button btnDeleteMaterial;


    }
}