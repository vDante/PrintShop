using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygraphy.Forms
{
    public partial class Settings : Form
    {
        int Empl;
        public Settings(int eid)
        {
            Empl = eid;
            InitializeComponent();
        }

        private void Settings_Shown(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Equals(tbPassword2.Text))
            {
                if(MessageBox.Show("Вы хотите изменить пароль?", "Подтверждение действия", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DBConnector db = new DBConnector();
                    try
                    {
                        db.ChangePassword(Empl, tbPassword.Text);
                        MessageBox.Show("Пароль успешно изменён!");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли отличаются!");
            }
        }


    }
}
