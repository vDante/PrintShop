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
    public partial class LogOn : Form
    {
        public LogOn()
        {
            InitializeComponent();
        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            Employee ee = CheckUser(tbUser.Text, tbPassword.Text);
            if (ee != null)
            {
                tbPassword.Clear();
                if(ee.Role == (uint)PolyRoles.Admin)
                {
                    FormManage ms = new FormManage(ee.Name,"Администратор",ee.Role,ee.Code);
                    ms.Owner = this;
                    ms.Show();
                    Hide();
                }
                if (ee.Role == (uint)PolyRoles.Manager)
                {
                    //FormMaterials ms = new FormMaterials();
                    FormManage ms = new FormManage(ee.Name, "Главный менеджер", ee.Role, ee.Code);
                    ms.Owner = this;
                    ms.Show();
                    Hide();
                }
                if (ee.Role == (uint)PolyRoles.Employee)
                {
                    //FormMaterials ms = new FormMaterials();
                    FormManage ms = new FormManage(ee.Name, "Менеджер", ee.Role, ee.Code);
                    ms.Owner = this;
                    ms.Show();
                    Hide();
                }
                
            }

        }

        private Employee CheckUser(string name, string pass)
        {

            //тут функция запроса к БД и проверки на пароль
            //пароль нужно "солить"
            Employee e = null;
            DBConnector db = new DBConnector();
            e = db.CheckUser(tbUser.Text, tbPassword.Text);
            if(e== null)
            {
                tbUser.Focus();
                tbUser.SelectAll();
            }

            return e;
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
                tbPassword.SelectAll();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogOn.Focus();
                btnLogOn.PerformClick();
            }
        }

        private void LogOn_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                if (!tbUser.Text.Equals(""))
                {
                    tbPassword.Focus();
                }
                else
                {
                    tbUser.Focus();
                }
            }
            
        }

        private void LogOn_Shown(object sender, EventArgs e)
        {
            //tbUser.Focus();
            //tbUser.Text = "6";
            //tbPassword.Text = "124";
            //btnLogOn.PerformClick();
        }    

        
    }
}
