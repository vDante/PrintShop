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
    public partial class FormEmployees : Form
    {
        bool isEdit;
        Employee empl {get;set;}
        public FormEmployees()
        {
            InitializeComponent();
            isEdit = false;
            this.Size = new Size(535, 462);
        }

        public void EditingMode(Employee ee)
        {
            this.Size = new Size(535, 549);
            btnAddEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = true;
            btnEditEmployee.Enabled = true;
            isEdit = true;
            empl = ee;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if(!tbAddress.Text.Equals("") && !tbAge.Text.Equals("") && !tbAddress.Text.Equals("") && !tbName.Text.Equals("") 
                && !tbPassport.Text.Equals("") && !tbPhone.Text.Equals("") && cbPosition.SelectedItem!=null && (rbMen.Checked || rbWomen.Checked))
            {
                DBConnector db = new DBConnector();
                Employee ee =new Employee();
                ee.Name = tbName.Text;
                ee.Passport = tbPassport.Text;
                ee.Phone = tbPhone.Text;
                ee.Age = uint.Parse(tbAge.Text);
                ee.Passowrd = ee.Phone;
                if (rbWomen.Checked) 
                {
                    ee.Sex = "Ж";
                }
                else 
                {
                    ee.Sex = "М";
                }
                ee.Adress = tbAddress.Text;
                ee.Position = cbPosition.SelectedItem.ToString();
                ee.Role = (uint)cbPosition.SelectedIndex+1;
                try
                {
                    db.EditEmployee(ee, true);
                    MessageBox.Show("Сотрудник добавлен!\n");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 1062:
                            MessageBox.Show("Введенный телефонный номер уже существует!");
                            break;
                        default:
                            MessageBox.Show(ex.Message);
                            break;
                    }                    
                    //throw;
                }
            }else{
                MessageBox.Show("Заполните все поля!");
            }
            
           // db.EditEmployee()
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
               uint.Parse(tbAge.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите целое число больше 0!");
                //throw;
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ulong.Parse(tbPhone.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Вводите только цифры!");
                //throw;
            }
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            cbPosition.Select(0, 1);
        }

        private void FormEmployees_Shown(object sender, EventArgs e)
        {
            if(isEdit)
            {
                tbName.Text = empl.Name;
                tbPassport.Text = empl.Passport;
                tbPhone.Text = empl.Phone;
                tbAge.Text = empl.Age.ToString();
                if (empl.Sex.Equals("М"))
                {
                    rbMen.Checked = true;
                    rbWomen.Checked = false;
                }
                else
                {
                    rbWomen.Checked = true;
                    rbMen.Checked = false;
                }

                tbAddress.Text = empl.Adress;
                if (empl.Role>3)
                {
                    empl.Role = 2;
                }
                cbPosition.SelectedIndex = (int)empl.Role - 1;
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить данные о сотруднике?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();

                    empl.Name = tbName.Text;
                    empl.Passport = tbPassport.Text;
                    empl.Phone = tbPhone.Text;
                    empl.Age = uint.Parse(tbAge.Text);
                    empl.Passowrd = empl.Phone;
                    if (rbWomen.Checked)
                    {
                        empl.Sex = "Ж";
                    }
                    else
                    {
                        empl.Sex = "М";
                    }
                    empl.Adress = tbAddress.Text;
                    empl.Position = cbPosition.SelectedItem.ToString();
                    empl.Role = (uint)cbPosition.SelectedIndex + 1;

                    db.EditEmployee(empl, false);

                    MessageBox.Show("Данные о сотруднике изменены!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить данные о сотруднике?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    db.DeleteEmployee(empl.Code);
                    MessageBox.Show("Данные о сотруднике удалены!");
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
