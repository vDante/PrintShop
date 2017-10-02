namespace Polygraphy
{
    partial class FormOrders
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
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.cboxServices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCustomers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrePrice = new System.Windows.Forms.Label();
            this.cbSale2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSale2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblPreSale = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbIsPay = new System.Windows.Forms.CheckBox();
            this.cbIsEnd = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddOrder.Location = new System.Drawing.Point(11, 372);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(519, 31);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Добавить";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // cboxServices
            // 
            this.cboxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboxServices.FormattingEnabled = true;
            this.cboxServices.Location = new System.Drawing.Point(134, 13);
            this.cboxServices.Margin = new System.Windows.Forms.Padding(6);
            this.cboxServices.Name = "cboxServices";
            this.cboxServices.Size = new System.Drawing.Size(396, 32);
            this.cboxServices.TabIndex = 13;
            this.cboxServices.TextChanged += new System.EventHandler(this.cboxServices_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Услуга:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Заказчик:";
            // 
            // cboxCustomers
            // 
            this.cboxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboxCustomers.FormattingEnabled = true;
            this.cboxCustomers.Location = new System.Drawing.Point(134, 57);
            this.cboxCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.cboxCustomers.Name = "cboxCustomers";
            this.cboxCustomers.Size = new System.Drawing.Size(396, 32);
            this.cboxCustomers.TabIndex = 15;
            this.cboxCustomers.SelectedIndexChanged += new System.EventHandler(this.cboxCustomers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(518, 2);
            this.label3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Количество:";
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbCount.Location = new System.Drawing.Point(134, 101);
            this.tbCount.Margin = new System.Windows.Forms.Padding(12);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(396, 29);
            this.tbCount.TabIndex = 20;
            this.tbCount.TextChanged += new System.EventHandler(this.tbCount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Стоимость:";
            // 
            // lblPrePrice
            // 
            this.lblPrePrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrePrice.AutoSize = true;
            this.lblPrePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPrePrice.ForeColor = System.Drawing.Color.Blue;
            this.lblPrePrice.Location = new System.Drawing.Point(128, 258);
            this.lblPrePrice.Name = "lblPrePrice";
            this.lblPrePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrePrice.Size = new System.Drawing.Size(29, 31);
            this.lblPrePrice.TabIndex = 22;
            this.lblPrePrice.Text = "0";
            this.lblPrePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSale2
            // 
            this.cbSale2.AutoSize = true;
            this.cbSale2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbSale2.Location = new System.Drawing.Point(35, 203);
            this.cbSale2.Name = "cbSale2";
            this.cbSale2.Size = new System.Drawing.Size(98, 28);
            this.cbSale2.TabIndex = 23;
            this.cbSale2.Text = "Скидка:";
            this.cbSale2.UseVisualStyleBackColor = true;
            this.cbSale2.CheckedChanged += new System.EventHandler(this.cbSale2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(13, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(518, 2);
            this.label7.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(13, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(518, 2);
            this.label8.TabIndex = 30;
            // 
            // tbSale2
            // 
            this.tbSale2.Enabled = false;
            this.tbSale2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbSale2.Location = new System.Drawing.Point(134, 201);
            this.tbSale2.Margin = new System.Windows.Forms.Padding(12);
            this.tbSale2.Name = "tbSale2";
            this.tbSale2.Size = new System.Drawing.Size(66, 29);
            this.tbSale2.TabIndex = 31;
            this.tbSale2.TextChanged += new System.EventHandler(this.tbSale2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(51, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Скидка:";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSale.Location = new System.Drawing.Point(130, 161);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(20, 24);
            this.lblSale.TabIndex = 33;
            this.lblSale.Text = "0";
            // 
            // lblPreSale
            // 
            this.lblPreSale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPreSale.AutoSize = true;
            this.lblPreSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPreSale.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblPreSale.Location = new System.Drawing.Point(128, 288);
            this.lblPreSale.Name = "lblPreSale";
            this.lblPreSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPreSale.Size = new System.Drawing.Size(29, 31);
            this.lblPreSale.TabIndex = 35;
            this.lblPreSale.Text = "0";
            this.lblPreSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(49, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Скидка:";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(125, 328);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(35, 37);
            this.lblPrice.TabIndex = 38;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label13.Location = new System.Drawing.Point(37, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 26);
            this.label13.TabIndex = 37;
            this.label13.Text = "ИТОГО:";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditOrder.Location = new System.Drawing.Point(11, 489);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(519, 31);
            this.btnEditOrder.TabIndex = 39;
            this.btnEditOrder.Text = "Изменить";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteOrder.Location = new System.Drawing.Point(11, 526);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(519, 31);
            this.btnDeleteOrder.TabIndex = 40;
            this.btnDeleteOrder.Text = "Удалить";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(13, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(518, 2);
            this.label11.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(13, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(518, 2);
            this.label12.TabIndex = 42;
            // 
            // cbIsPay
            // 
            this.cbIsPay.AutoSize = true;
            this.cbIsPay.Enabled = false;
            this.cbIsPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbIsPay.Location = new System.Drawing.Point(13, 431);
            this.cbIsPay.Name = "cbIsPay";
            this.cbIsPay.Size = new System.Drawing.Size(118, 28);
            this.cbIsPay.TabIndex = 43;
            this.cbIsPay.Text = "Оплачено";
            this.cbIsPay.UseVisualStyleBackColor = true;
            // 
            // cbIsEnd
            // 
            this.cbIsEnd.AutoSize = true;
            this.cbIsEnd.Enabled = false;
            this.cbIsEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbIsEnd.Location = new System.Drawing.Point(292, 431);
            this.cbIsEnd.Name = "cbIsEnd";
            this.cbIsEnd.Size = new System.Drawing.Size(239, 28);
            this.cbIsEnd.TabIndex = 44;
            this.cbIsEnd.Text = "Отметка о завершении";
            this.cbIsEnd.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpStart.Location = new System.Drawing.Point(330, 158);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 29);
            this.dtpStart.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.Location = new System.Drawing.Point(245, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 24);
            this.label14.TabIndex = 46;
            this.label14.Text = "Начало:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label15.Location = new System.Drawing.Point(245, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 24);
            this.label15.TabIndex = 48;
            this.label15.Text = "Конец:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpEnd.Location = new System.Drawing.Point(330, 200);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 29);
            this.dtpEnd.TabIndex = 47;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 569);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cbIsEnd);
            this.Controls.Add(this.cbIsPay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPreSale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSale2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSale2);
            this.Controls.Add(this.lblPrePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxServices);
            this.Controls.Add(this.btnAddOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказ";
            this.Shown += new System.EventHandler(this.FormOrders_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ComboBox cboxServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrePrice;
        private System.Windows.Forms.CheckBox cbSale2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSale2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblPreSale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbIsPay;
        private System.Windows.Forms.CheckBox cbIsEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpEnd;
    }
}