using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polygraphy.Forms;

namespace Polygraphy
{
    public partial class FormOrders : Form
    {
        bool isEdit;
        Order or { get; set; }
        List<Service> services;
        List<Customer> customers;
        List<string> sl;
        List<string> cl;
        int EmployeeID;
        public FormOrders(int employeeID)
        {
            InitializeComponent();
            EmployeeID = employeeID;
            isEdit = false;
            this.Size = new Size(561, 445);
        }

        public void EditingMode(Order oo)
        {
            this.Size = new Size(561, 603);
            btnAddOrder.Enabled = false;
            btnDeleteOrder.Enabled = true;
            btnEditOrder.Enabled = true;
            cbIsEnd.Enabled = true;
            cbIsPay.Enabled = true;
            cbSale2.Enabled = false;
            isEdit = true;
            or = oo;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!tbCount.Text.Equals("") && cboxCustomers.SelectedItem != null && cboxServices.SelectedItem != null)
            {
                DBConnector db = new DBConnector();
                Order ss = new Order();
                ss.ServiceCode = (int)services[cboxServices.SelectedIndex].Code;
                ss.CustomerCode = (int)customers[cboxCustomers.SelectedIndex].Code;
                ss.EmployeeCode = EmployeeID;
                try
                {
                    ss.Count= int.Parse(tbCount.Text);
                    ss.StartDate = dtpStart.Value;
                    ss.EndDate = dtpEnd.Value;
                    ss.Price = float.Parse(lblPrice.Text);
                    db.EditOrder(ss, true);
                    MessageBox.Show("Заказ добавлен!\n");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

            // db.EditOrder()
        }

        private void FormOrders_Shown(object sender, EventArgs e)
        {
            tbSale2.Text = "0";
            try
            {
                DBConnector db = new DBConnector();

                services = new List<Service>();
                customers = new List<Customer>();

                services = db.SearchServicesTypes();
                customers = db.SearchCustomersTypes();

                sl = new List<string>();
                foreach (var s in services)
                {
                    sl.Add(s.Name);
                }

                cl = new List<string>();
                foreach (var c in customers)
                {
                    cl.Add(c.Name);
                }

                cboxServices.DataSource = sl;
                cboxServices.SelectedIndex = 0;

                cboxCustomers.DataSource = cl;
                cboxCustomers.SelectedIndex = 0;
                lblSale.Text = customers[cboxCustomers.SelectedIndex].Sale.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            if (isEdit)
            {
                cboxServices.SelectedIndex = services.FindIndex(x => x.Code == (uint)or.ServiceCode);
                cboxCustomers.SelectedIndex = customers.FindIndex(x => x.Code == (uint)or.CustomerCode);
                lblPrice.Text = or.Price.ToString();
                dtpEnd.Value = or.EndDate;
                dtpStart.Value = or.StartDate;
                tbCount.Text = or.Count.ToString();
                cbIsEnd.Checked = or.IsEnd;
                cbIsPay.Checked = or.IsPay;
                
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить данные о заказе?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    bool isPayed = false;
                    if (cbIsPay.Checked && !or.IsPay)
                    {
                        isPayed = true;
                    }

                    DBConnector db = new DBConnector();

                    or.ServiceCode = (int)services[cboxServices.SelectedIndex].Code;
                    or.CustomerCode = (int)customers[cboxCustomers.SelectedIndex].Code;
                    or.EmployeeCode = EmployeeID;
                    or.Count = int.Parse(tbCount.Text);
                    or.StartDate = dtpStart.Value;
                    or.EndDate = dtpEnd.Value;
                    or.Price = float.Parse(lblPrice.Text);
                    or.IsEnd = cbIsEnd.Checked;
                    or.IsPay = cbIsPay.Checked;

                    db.EditOrder(or, false);
                    if(isPayed)
                    {
                        db.IncSaleCustomer(1, or.CustomerCode);
                    }
                    MessageBox.Show("Данные о заказе изменены!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить данные о заказе?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    db.DeleteOrder(or.Code);
                    MessageBox.Show("Данные об заказе удалены!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void cbSale2_CheckedChanged(object sender, EventArgs e)
        {
            tbSale2.Enabled = cbSale2.Checked;
        }

        private void CalculatePrice()
        {
            if (!tbCount.Text.Equals("") && cboxCustomers.SelectedIndex != -1 && cboxServices.SelectedIndex != -1)
            {
                try 
	            {	        
		            int sale = 0;
                    sale = customers[cboxCustomers.SelectedIndex].Sale;
                    //lblSale.Text = sale.ToString();
                    if (cbSale2.Checked)
                    {
                        sale += int.Parse(tbSale2.Text);
                    }

                    float prePrice=0,salePrice = 0, price=0;
                    int count=0;
                    count = int.Parse(tbCount.Text);
                    prePrice = services[cboxServices.SelectedIndex].Price * count;
                    salePrice = prePrice * ((float)sale / 100);
                    price= prePrice - salePrice;

                    lblPrePrice.Text = prePrice.ToString();
                    lblPreSale.Text = salePrice.ToString();
                    lblPrice.Text = price.ToString();

	            }
	            catch (Exception)
	            {
		
		            throw;
	            }
                
            }
            
        }

        private void cboxServices_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void cboxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSale.Text = customers[cboxCustomers.SelectedIndex].Sale.ToString();
            try
            {
                int i = int.Parse(tbSale2.Text);
                if (i + customers[cboxCustomers.SelectedIndex].Sale > 100)
                {
                    i = 100 - customers[cboxCustomers.SelectedIndex].Sale;
                    tbSale2.Text = i.ToString();
                }
            }
            catch (Exception)
            {
                tbSale2.Text = "0";
                //throw;
            }
            CalculatePrice();
        }

        private void tbCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbCount.Text);
            }
            catch (Exception)
            {
                tbCount.Text="1";
                //throw;
            }
            CalculatePrice();
        }

        private void tbSale2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(tbSale2.Text);
                if (i+customers[cboxCustomers.SelectedIndex].Sale>100)
                {
                    i=100-customers[cboxCustomers.SelectedIndex].Sale;
                    tbSale2.Text = i.ToString();
                }
            }
            catch (Exception)
            {
                tbSale2.Text="0";
                //throw;
            }
            CalculatePrice();
        }
    }
}
