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
    public partial class FormCustomers : Form
    {
        bool isEdit;
        Customer cm { get; set; }
        public FormCustomers()
        {
            InitializeComponent();
            isEdit = false;
            this.Size = new Size(535, 343);
        }

        public void EditingMode(Customer cc)
        {
            this.Size = new Size(535, 439);
            btnAddCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = true;
            btnEditCustomer.Enabled = true;
            isEdit = true;
            cm = cc;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!tbAddress.Text.Equals("") && !tbAddress.Text.Equals("") && !tbName.Text.Equals("")
                && !tbPassport.Text.Equals("") && !tbPhone.Text.Equals(""))
            {
                DBConnector db = new DBConnector();
                Customer cc = new Customer();
                cc.Name = tbName.Text;
                cc.Adress = tbAddress.Text;
                cc.Passport = tbPassport.Text;
                cc.Phone = tbPhone.Text;                
                try
                {
                    cc.Sale = int.Parse(tbSale.Text);
                    db.EditCustomer(cc, true);
                    MessageBox.Show("Заказчик добавлен!\n");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

            // db.EditCustomer()
        }

        private void FormCustomers_Shown(object sender, EventArgs e)
        {
            if (isEdit)
            {
                tbName.Text = cm.Name;
                tbAddress.Text = cm.Adress;
                tbPassport.Text = cm.Passport;
                tbPhone.Text = cm.Phone;
                tbSale.Text = cm.Sale.ToString();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить данные о заказчике?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();

                    cm.Name = tbName.Text;
                    cm.Adress = tbAddress.Text;
                    cm.Passport = tbPassport.Text;
                    cm.Phone = tbPhone.Text;
                    cm.Sale = int.Parse(tbSale.Text);

                    db.EditCustomer(cm, false);

                    MessageBox.Show("Данные о заказчике изменены!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить данные о заказчике?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    db.DeleteCustomer(cm.Code);
                    MessageBox.Show("Данные о заказчике удалены!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

    }
}
