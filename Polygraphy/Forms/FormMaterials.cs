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
    public partial class FormMaterials : Form
    {
        bool isEdit;
        Material mat { get; set; }
        public FormMaterials()
        {
            InitializeComponent();
            isEdit = false;
            this.Size = new Size(561, 288);
        }

        public void EditingMode(Material m)
        {
            this.Size = new Size(561, 366);
            btnAddMaterial.Enabled = false;
            btnDeleteMaterial.Enabled = true;
            btnEditMaterial.Enabled = true;
            isEdit = true;
            mat = m;
        }
        
        private void FormMaterials_Shown(object sender, EventArgs e)
        {
            if (isEdit)
            {
                tbName.Text = mat.Name;
                tbPackage.Text = mat.PackageQuantity.ToString();
                tbDescription.Text = mat.Description;
                tbPrice.Text = mat.Price.ToString();
            }
        }
        
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (!tbName.Text.Equals("") && !tbDescription.Text.Equals("") && !tbPackage.Text.Equals("") && !tbPrice.Text.Equals(""))
            {
                DBConnector db = new DBConnector();
                Material m = new Material();
                m.Name = tbName.Text;
                m.Description = tbDescription.Text;                
                try
                {
                    m.PackageQuantity = int.Parse(tbPackage.Text);
                    m.Price = float.Parse(tbPrice.Text);
                    db.EditMaterial(m, true);
                    MessageBox.Show("Материал добавлен!\n");
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
        }
        private void btnEditMaterial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить данные о материале?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();

                    mat.Name = tbName.Text;
                    mat.PackageQuantity = int.Parse(tbPackage.Text);
                    mat.Description = tbDescription.Text;
                    mat.Price = float.Parse(tbPrice.Text);
                    db.EditMaterial(mat, false);

                    MessageBox.Show("Данные о материале изменены!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }
        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить данные о материале?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    db.DeleteMaterial(mat.Code);
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
