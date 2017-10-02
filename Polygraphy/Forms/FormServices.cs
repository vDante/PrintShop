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
    public partial class FormServices : Form
    {
        bool isEdit;
        Service sc { get; set; }
        List<Material> ml;
        List<string> sl;
        public FormServices()
        {
            InitializeComponent();
            isEdit = false;
            this.Size = new Size(535, 296);
        }

        public void EditingMode(Service ss)
        {
            this.Size = new Size(535, 387);
            btnAddService.Enabled = false;
            btnDeleteService.Enabled = true;
            btnEditService.Enabled = true;
            isEdit = true;
            sc = ss;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (!tbName.Text.Equals("") && !tbDescription.Text.Equals("") && !tbPrice.Text.Equals("") && cboxMaterialID.SelectedItem!=null)
            {
                DBConnector db = new DBConnector();
                Service ss = new Service();
                ss.Name = tbName.Text;
                ss.Description = tbDescription.Text;                
                ss.MaterialID = (int)ml[cboxMaterialID.SelectedIndex].Code;
                try
                {
                    ss.Price = float.Parse(tbPrice.Text);
                    db.EditService(ss, true);
                    MessageBox.Show("Услуга добавлена!\n");
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

            // db.EditService()
        }

        private void FormServices_Shown(object sender, EventArgs e)
        {
            try
            {
                DBConnector db = new DBConnector();

                ml = new List<Material>();
                ml = db.SearchMaterialTypes();

                sl = new List<string>();
                foreach (var m in ml)
                {
                    sl.Add(m.Name);
                }
                cboxMaterialID.DataSource = sl;
                cboxMaterialID.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            if (isEdit)
            {
                tbName.Text = sc.Name;
                tbDescription.Text = sc.Description;
                tbPrice.Text = sc.Price.ToString();
                cboxMaterialID.SelectedIndex = ml.FindIndex(x=> x.Code==(uint)sc.MaterialID);
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить данные о услуге?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();

                    sc.Name = tbName.Text;
                    sc.Description = tbDescription.Text;
                    sc.Price = float.Parse(tbPrice.Text);
                    sc.MaterialID = (int)ml[cboxMaterialID.SelectedIndex].Code;

                    db.EditService(sc, false);

                    MessageBox.Show("Данные об услуге изменены!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить данные о заказчике?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    db.DeleteService(sc.Code);
                    MessageBox.Show("Данные об услуге удалены!");
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
