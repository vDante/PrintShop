using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polygraphy;

namespace Polygraphy.Forms
{
    public partial class FormManage : Form
    {
        string UserName, UserRole;
        uint Role;
        int EmployeeID;

        #region THISFORM FUNCTION
        public FormManage(string userName, string userRole, uint role, uint emplId)
        {
            UserName = userName;
            UserRole = userRole;
            Role = role;
            EmployeeID = (int)emplId;
            InitializeComponent();            
        }
        private void FormManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            mnStatusLblName.Text = "Имя";
            mnStatusLblRole.Text = "Должность";
            Owner.Show();
        }
        private void FormManage_Load(object sender, EventArgs e)
        {
            /*if(Role==2)
            {
                tabManage.
            }*/
            if (Role == (uint)PolyRoles.Employee)
            {
                tabManageEmployees.Parent = null;
            }
            mnStatusLblName.Text = UserName;
            mnStatusLblRole.Text = UserRole;
        }
        #endregion

        #region ToolStrip Functions

        private void tsBtnUpdate_Click(object sender, EventArgs e)
        {
            switch (MainTab.SelectedIndex)
            {
                case (int)PolyTabs.Employees:
                    UpdateEmployeeList("",false);
                    break;
                case (int)PolyTabs.Materials:
                    UpdateMaterialsList("", false);
                    break;
                case (int)PolyTabs.Customers:
                    UpdateCustomersList("", false);
                    break;
                case (int)PolyTabs.Services:
                    UpdateServiceList("", false);
                    break;
                case (int)PolyTabs.Orders:
                    UpdateOrderList("", false);
                    break;
            }
        }  

        private void tsBtnFastSearch_Click(object sender, EventArgs e)
        {
            switch (MainTab.SelectedIndex)
            {
                case (int)PolyTabs.Employees:
                    UpdateEmployeeList(tsTextFind.Text,false);
                    break;
                case (int)PolyTabs.Materials:
                    UpdateMaterialsList(tsTextFind.Text, false);
                    break;
                case (int)PolyTabs.Customers:
                    UpdateCustomersList(tsTextFind.Text, false);
                    break;
                case (int)PolyTabs.Services:
                    UpdateServiceList(tsTextFind.Text, false);
                    break;
                case (int)PolyTabs.Orders:
                    UpdateOrderList(tsTextFind.Text, false);
                    break;
            }
        }

        private void tsTextFind_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tsBtnFastSearch.PerformClick();
            }
        }

        #endregion

            

        #region MATERIALS FUNCTIONS
        //======================================================================//
        //=======================  MATERIALS ===================================//
        //======================================================================//
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            FormMaterials f = new FormMaterials();
            f.ShowDialog();
        }
        private void btnSearchMaterials_Click(object sender, EventArgs e)
        {
            panelMaterials.Enabled = !panelMaterials.Enabled;
            panelMaterials.Visible = !panelMaterials.Visible;
            cboxSMParam.SelectedIndex = 0;
            cboxSMPackage.SelectedIndex = 0;
            cboxSMPrice.SelectedIndex = 0;
        }
        private void dgMaterials_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMaterials.SelectedRows.Count != 0)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    Material m = db.SearchMaterial("id", dgMaterials.SelectedRows[0].Cells[0].Value.ToString(), false)[0];
                    FormMaterials f = new FormMaterials();
                    f.EditingMode(m);
                    f.ShowDialog();
                    //UpdateEmployeeList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }
        private void UpdateMaterialsList(string SearchText, bool extendetSearch)
        {
            try
            {
                DBConnector db = new DBConnector();
                dgMaterials.DataSource = db.SearchMaterial("name", SearchText, extendetSearch);
                dgMaterials.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void btnSearchMaterial_Click(object sender, EventArgs e)
        {
            string search = " WHERE 1=1 ";
            if (cbSMName.Checked)//название
            {
                search += "AND name LIKE '%" + tbSMName.Text + "%' ";
            }
            if (cbSMPackage.Checked)//упаковка
            {
                search += "AND packageCol" + cboxSMPackage.SelectedItem + "'" + tbSMPackage.Text + "' ";
            }
            if (cbSMDescription.Checked)//описание
            {
                search += "AND description LIKE '%" + tbSMDescription.Text + "%' ";
            }
            if (cbSMPrice.Checked)//цена
            {
                search += "AND price" + cboxSMPrice.SelectedItem + "'" + tbSMPrice.Text + "' ";
            }

            if (cbSMSort.Checked)//сортировка
            {
                string s = "";
                switch (cboxSMParam.SelectedIndex)
                {
                    case 0:
                        s = "id";
                        break;
                    case 1:
                        s = "name";
                        break;
                    case 2:
                        s = "packageCol";
                        break;
                    case 3:
                        s = "description";
                        break;
                    case 4:
                        s = "price";
                        break;
                }
                s += rbSMDesc.Checked ? " DESC " : "";
                search += " ORDER BY " + s;
            }
            search += ";";
            UpdateMaterialsList(search, true);
        }

        private void cbSMName_CheckedChanged(object sender, EventArgs e)
        {
            tbSMName.Enabled = !tbSMName.Enabled;
        }

        private void cbSMPackage_CheckedChanged(object sender, EventArgs e)
        {
            tbSMPackage.Enabled = !tbSMPackage.Enabled;
            cboxSMPackage.Enabled = !cboxSMPackage.Enabled;
        }

        private void cbSMDescription_CheckedChanged(object sender, EventArgs e)
        {
            tbSMDescription.Enabled = !tbSMDescription.Enabled;
        }

        private void cbSMPrice_CheckedChanged(object sender, EventArgs e)
        {
            tbSMPrice.Enabled = !tbSMPrice.Enabled;
            cboxSMPrice.Enabled = !cboxSMPrice.Enabled;
        }

        private void cbSMSort_CheckedChanged(object sender, EventArgs e)
        {
            cboxSMParam.Enabled = !cboxSMParam.Enabled;
            gbSMSort.Enabled = !gbSMSort.Enabled;
        }
        //======================================================================//
        //======================================================================//
        //======================================================================//
        #endregion

        #region EMPLOYEES FUNCTIONS
        //======================================================================//
        //=======================  EMPLOYEES ===================================//
        //======================================================================//
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            FormEmployees f = new FormEmployees();
            f.ShowDialog();
            UpdateEmployeeList("", false);
        }

        private void dgEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmployees.SelectedRows.Count != 0)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    Employee es = db.SearchEmployee("id", dgEmployees.SelectedRows[0].Cells[1].Value.ToString(), false)[0];
                    FormEmployees f = new FormEmployees();
                    f.EditingMode(es);
                    f.ShowDialog();
                    //UpdateEmployeeList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void UpdateEmployeeList(string SearchText, bool extendetSearch)
        {
            try
            {
                DBConnector db = new DBConnector();
                dgEmployees.DataSource = db.SearchEmployee("name", SearchText, extendetSearch);
                dgOrders.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btvSearchEmployee_Click(object sender, EventArgs e)
        {
            panelEmployee.Visible = !panelEmployee.Visible;
            panelEmployee.Enabled = !panelEmployee.Enabled;
            cbSEAgeParam.SelectedIndex = 0;
            cboxSEPosition.SelectedIndex = 0;
            cbSrtParam.SelectedIndex = 0;
        }

        private void cbSEName_CheckedChanged(object sender, EventArgs e)
        {
            tbSEName.Enabled = cbSEName.Checked;
        }

        private void cbSEAge_CheckedChanged(object sender, EventArgs e)
        {
            tbSEAge.Enabled = cbSEAge.Checked;
            cbSEAgeParam.Enabled = cbSEAge.Checked;
        }

        private void cbSESex_CheckedChanged(object sender, EventArgs e)
        {
            gbSESex.Enabled = cbSESex.Checked;
        }

        private void cbSEAddress_CheckedChanged(object sender, EventArgs e)
        {
            tbSEAddress.Enabled = cbSEAddress.Checked;
        }

        private void cbSEPhone_CheckedChanged(object sender, EventArgs e)
        {
            tbSEPhone.Enabled = cbSEPhone.Checked;
        }

        private void cbSEPassport_CheckedChanged(object sender, EventArgs e)
        {
            tbSEPassport.Enabled = cbSEPassport.Checked;
        }

        private void cbSEPosition_CheckedChanged(object sender, EventArgs e)
        {
            cboxSEPosition.Enabled = cbSEPosition.Checked;
        }

        private void cbSrEEnable_CheckedChanged(object sender, EventArgs e)
        {
            cbSrtParam.Enabled = cbSrEEnable.Checked;
            gbSrtE.Enabled = cbSrEEnable.Checked;
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
           string search = " WHERE 1=1 ";
           if (cbSEName.Checked)//фио
            {
                search += "AND name LIKE '%" + tbSEName.Text + "%' ";
            }
            if (cbSEAge.Checked)//возраст
            {
                search += "AND age"+cbSEAgeParam.SelectedItem+"'" + tbSEAge.Text + "' ";
            }
            if (cbSESex.Checked)//пол
            {
                string s = rbSEMen.Checked ? rbSEMen.Text : rbSEWomen.Text;
                search += "AND sex='" + s + "' ";
            }
            if (cbSEAddress.Checked)//адрес
            {
                search += "AND address LIKE '%" + tbSEAddress.Text + "%' ";
            }
            if (cbSEPhone.Checked)//телефон
            {
                search += "AND phone LIKE '%" + tbSEPhone.Text + "%' ";
            }  
            if (cbSEPassport.Checked)//паспорт
            {
                search += "AND passport LIKE '%" + tbSEPassport.Text + "%' ";
            }
            if (cbSEPosition.Checked)//должность
            {
                int num = cboxSEPosition.SelectedIndex + 1;
                search += "AND position=" + num.ToString() + " ";
            }

            //search += "AND 1=1";

            if (cbSrEEnable.Checked)//сортировка
            {
                string s="";
                switch (cbSrtParam.SelectedIndex)
	            {
                    case 0:
                        s = "id";
                        break;
                    case 1:
                        s="name";
                        break;
                    case 2:
                        s="age";
                        break;
                    case 3:
                        s="sex";
                        break;
                    case 4:
                        s="address";
                        break;
                    case 5:
                        s="phone";
                        break;
                    case 6:
                        s="passport";
                        break;
                    case 7:
                        s="position";
                        break;
	            }
                s+=rbStEDec.Checked?" DESC ":"";
                search += " ORDER BY " + s;               
            }
            search += ";";     
            UpdateEmployeeList(search, true);    
        }

        private void dgEmployees_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            string s=dgEmployees.Columns[e.Column.Index].HeaderText;
            if (s.Equals("Role") || s.Equals("Passowrd"))
            {
                dgEmployees.Columns[e.Column.Index].Visible = false;
            }
            //
        }

        //======================================================================//
        //======================================================================//
        //======================================================================//
        #endregion

        #region CUSTOMERS FUNCTIONS
        //======================================================================//
        //=======================  CUSTOMERS ===================================//
        //======================================================================//
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormCustomers f = new FormCustomers();
            f.ShowDialog();
            UpdateCustomersList("", false);
        }

        private void dgCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCustomers.SelectedRows.Count != 0)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    Customer cc = db.SearchCustomer("id", dgCustomers.SelectedRows[0].Cells[0].Value.ToString(), false)[0];
                    FormCustomers f = new FormCustomers();
                    f.EditingMode(cc);
                    f.ShowDialog();
                    //UpdateCustomerList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void UpdateCustomersList(string SearchText, bool extendetSearch)
        {
            try
            {
                DBConnector db = new DBConnector();
                dgCustomers.DataSource = db.SearchCustomer("name", SearchText, extendetSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            panelCustomers.Visible = !panelCustomers.Visible;
            panelCustomers.Enabled = !panelCustomers.Enabled;
            cboxSCParam.SelectedIndex = 0;
        }

        private void cbSCName_CheckedChanged(object sender, EventArgs e)
        {
            tbSCName.Enabled = cbSCName.Checked;
        }
        
        private void cbSCAddress_CheckedChanged(object sender, EventArgs e)
        {
            tbSCAddress.Enabled = cbSCAddress.Checked;
        }

        private void cbSCPhone_CheckedChanged(object sender, EventArgs e)
        {
            tbSCPhone.Enabled = cbSCPhone.Checked;
        }

        private void cbSCPassport_CheckedChanged(object sender, EventArgs e)
        {
            tbSCPassport.Enabled = cbSCPassport.Checked;
        }

        private void cbSCSort_CheckedChanged(object sender, EventArgs e)
        {
            cboxSCParam.Enabled = cbSCSort.Checked;
            gbSCSort.Enabled = cbSCSort.Checked;
        }

        private void btnSCSearch_Click(object sender, EventArgs e)
        {
            string search = " WHERE 1=1 ";
            if (cbSCName.Checked)//фио
            {
                search += "AND name LIKE '%" + tbSCName.Text + "%' ";
            }
            if (cbSCAddress.Checked)//адрес
            {
                search += "AND address LIKE '%" + tbSCAddress.Text + "%' ";
            }
            if (cbSCPhone.Checked)//телефон
            {
                search += "AND phone LIKE '%" + tbSCPhone.Text + "%' ";
            }
            if (cbSCPassport.Checked)//паспорт
            {
                search += "AND passport LIKE '%" + tbSCPassport.Text + "%' ";
            }

            if (cbSCSort.Checked)//сортировка
            {
                string s = "";
                switch (cboxSCParam.SelectedIndex)
                {
                    case 0:
                        s = "id";
                        break;
                    case 1:
                        s = "name";
                        break;
                    case 2:
                        s = "address";
                        break;
                    case 3:
                        s = "phone";
                        break;
                    case 4:
                        s = "passport";
                        break;
                }
                s += rbSCSortDesc.Checked ? " DESC " : "";
                search += " ORDER BY " + s;
            }
            search += ";";
            UpdateCustomersList(search, true);
        }

        //======================================================================//
        //======================================================================//
        //======================================================================//
        #endregion

        #region SERVICES FUNCTIONS
        //======================================================================//
        //=======================  SERVICES ===================================//
        //======================================================================//
        private void btnAddService_Click(object sender, EventArgs e)
        {
            FormServices f = new FormServices();
            f.ShowDialog();
            UpdateServiceList("", false);
        }

        private void dgServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgServices.SelectedRows.Count != 0)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    Service es = db.SearchService("s.id", dgServices.SelectedRows[0].Cells[0].Value.ToString(), false)[0];
                    FormServices f = new FormServices();
                    f.EditingMode(es);
                    f.ShowDialog();
                    //UpdateServiceList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void UpdateServiceList(string SearchText, bool extendetSearch)
        {
            try
            {
                DBConnector db = new DBConnector();
                dgServices.DataSource = db.SearchService("s.name", SearchText, extendetSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnSearchService_Click(object sender, EventArgs e)
        {
            panelSS.Visible = !panelSS.Visible;
            panelSS.Enabled = !panelSS.Enabled;
            cboxSSPrice.SelectedIndex = 0;
            cboxSSSort.SelectedIndex = 0;
        }

        private void cbSSName_CheckedChanged(object sender, EventArgs e)
        {
            tbSSName.Enabled = cbSSName.Checked;
        }

        private void cbSSPrice_CheckedChanged(object sender, EventArgs e)
        {
            tbSSPrice.Enabled = cbSSPrice.Checked;
            cboxSSPrice.Enabled = cbSSPrice.Checked;
        }

        private void cbSSDescr_CheckedChanged(object sender, EventArgs e)
        {
            tbSSDescr.Enabled = cbSSDescr.Checked;
        }

        private void cbSSMaterial_CheckedChanged(object sender, EventArgs e)
        {
            tbSSMAterial.Enabled = cbSSMaterial.Checked;
        }

        private void cbSSSort_CheckedChanged(object sender, EventArgs e)
        {
            cboxSSSort.Enabled = cbSSSort.Checked;
            gbSS.Enabled = cbSSSort.Checked;
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            string search = " WHERE 1=1 ";
            if (cbSSName.Checked)//фио
            {
                search += "AND s.name LIKE '%" + tbSSName.Text + "%' ";
            }
            if (cbSSPrice.Checked)//возраст
            {
                search += "AND s.price" + cboxSSPrice.SelectedItem + "'" + tbSSPrice.Text + "' ";
            }
            if (cbSSDescr.Checked)//адрес
            {
                search += "AND s.description LIKE '%" + tbSSDescr.Text + "%' ";
            }
            if (cbSSMaterial.Checked)//телефон
            {
                search += "AND m.name LIKE '%" + tbSSMAterial.Text + "%' ";
            }
            
            if (cbSSSort.Checked)//сортировка
            {
                string s = "";
                switch (cboxSSSort.SelectedIndex)
                {
                    case 0:
                        s = "s.id";
                        break;
                    case 1:
                        s = "s.name";
                        break;
                    case 2:
                        s = "s.description";
                        break;
                    case 3:
                        s = "s.price";
                        break;
                    case 4:
                        s = "m.name";
                        break;
                }
                s += rbSSDEsc.Checked ? " DESC " : "";
                search += " ORDER BY " + s;
            }
            search += ";";
            UpdateServiceList(search, true);
        }

        private void dgServices_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            string s = dgServices.Columns[e.Column.Index].HeaderText;
            if (s.Equals("MaterialID"))
            {
                dgServices.Columns[e.Column.Index].Visible = false;
            }
        }

        //======================================================================//
        //======================================================================//
        //======================================================================//
        #endregion

        #region ORDERS FUNCTIONS        
        //======================================================================//
        //=======================  ORDERS ======================================//
        //======================================================================//
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FormOrders fo = new FormOrders(EmployeeID);
            fo.ShowDialog();
            UpdateOrderList("", false);
        }
        private void dgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgOrders.SelectedRows.Count != 0)
            {
                try
                {
                    DBConnector db = new DBConnector();
                    Order es = db.SearchOrder("o.id", dgOrders.SelectedRows[0].Cells[0].Value.ToString(), false)[0];
                    FormOrders f = new FormOrders(EmployeeID);
                    f.EditingMode(es);
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void UpdateOrderList(string SearchText, bool extendetSearch)
        {
            try
            {
                DBConnector db = new DBConnector();
                dgOrders.DataSource = db.SearchOrder("c.name", SearchText, extendetSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            panelSO.Visible = !panelSO.Visible;
            panelSO.Enabled = !panelSO.Enabled;
            cboxSOPrice.SelectedIndex = 0;
            cboxSOSort.SelectedIndex = 0;
            cboxSOEnd.SelectedIndex = 0;
            cboxSOStart.SelectedIndex = 0;
        }

        private void cbSOSort_CheckedChanged(object sender, EventArgs e)
        {
            cboxSOSort.Enabled = cbSOSort.Checked;
            gbSOSort.Enabled = cbSOSort.Checked;
        }
        private void cbSOService_CheckedChanged(object sender, EventArgs e)
        {
            tbSOService.Enabled = cbSOService.Checked;
        }

        private void cbSOCustomer_CheckedChanged(object sender, EventArgs e)
        {
            tbSOCustomer.Enabled = cbSOCustomer.Checked;
        }

        private void cbSOPrice_CheckedChanged(object sender, EventArgs e)
        {
            tbSOPrice.Enabled = cbSOPrice.Checked;
            cboxSOPrice.Enabled = cbSOPrice.Checked;
        }

        private void cbSOStartDAte_CheckedChanged(object sender, EventArgs e)
        {
            dtpSOStart.Enabled = cbSOStartDAte.Checked;
            cboxSOStart.Enabled = cbSOStartDAte.Checked;
        }

        private void cbSOEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpSOEnd.Enabled = cbSOEndDate.Checked;
            cboxSOEnd.Enabled = cbSOEndDate.Checked;
        }

        private void cbSOIsPay_CheckedChanged(object sender, EventArgs e)
        {
            gbSOIsPay.Enabled = cbSOIsPay.Checked;
        }

        private void cbSOIsEnd_CheckedChanged(object sender, EventArgs e)
        {
            gbSOIsEnd.Enabled = cbSOIsEnd.Checked;
        }

        private void cbSOEmpl_CheckedChanged(object sender, EventArgs e)
        {
            tbSOEmpl.Enabled = cbSOEmpl.Checked;
        }

        private void cbSOSort_CheckedChanged_1(object sender, EventArgs e)
        {
            cboxSOSort.Enabled = cbSOSort.Checked;
            gbSOSort.Enabled = cbSOSort.Checked;
        }

        private void btnSO_Click(object sender, EventArgs e)
        {
            string search = " WHERE 1=1 ";
            if (cbSOService.Checked)//Услуга
            {
                search += "AND s.name LIKE '%" + tbSOService.Text + "%' ";
            }
            if (cbSOCustomer.Checked)//Заказчик
            {
                search += "AND c.name LIKE '%" + tbSOCustomer.Text + "%' ";
            }
            if (cbSOEmpl.Checked)//Сотрудник
            {
                search += "AND e.name LIKE '%" + tbSOEmpl.Text + "%' ";
            }
            if (cbSOPrice.Checked)//Сумма
            {
                search += "AND o.price" + cboxSOPrice.SelectedItem + "'" + tbSOPrice.Text + "' ";
            }
            if (cbSOIsEnd.Checked)//Завершено?
            {
                string s = rbSOIsEnd.Checked ? "true" : "false";
                search += "AND o.status=" + s + " ";
            }
            if (cbSOIsPay.Checked)//Оплачено?
            {
                string s = rbSOIsPay.Checked ? "true" : "false";
                search += "AND o.is_pay=" + s + " ";
            }
            if (cbSOStartDAte.Checked)//Начало
            {
                search += "AND o.date_start" + cboxSOStart.SelectedItem + "'" + dtpSOStart.Value.ToString("yyyyMMdd") + "' ";
            }
            if (cbSOEndDate.Checked)//Начало
            {
                search += "AND o.date_end" + cboxSOEnd.SelectedItem + "'" + dtpSOEnd.Value.ToString("yyyyMMdd")+ "' ";
            }

            if (cbSOSort.Checked)//сортировка
            {
                string s = "";
                switch (cboxSOSort.SelectedIndex)
                {
                    case 0:
                        s = "o.id";
                        break;
                    case 1:
                        s = "s.name";
                        break;
                    case 2:
                        s = "c.name";
                        break;
                    case 3:
                        s = "e.name";
                        break;
                    case 4:
                        s = "o.price";
                        break;
                    case 5:
                        s = "o.date_start";
                        break;
                    case 6:
                        s = "o.date_end";
                        break;
                    case 7:
                        s = "o.is_pay";
                        break;
                    case 8:
                        s = "o.status";
                        break;
                }
                s += rbSOSortDesc.Checked ? " DESC " : "";
                search += " ORDER BY " + s;
            }
            search += ";";
            UpdateOrderList(search, true);
        }

        private void dgOrders_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            string s = dgOrders.Columns[e.Column.Index].HeaderText;
            if (s.Equals("CustomerCode") || s.Equals("ServiceCode") || s.Equals("EmployeeCode") )
            {
                dgOrders.Columns[e.Column.Index].Visible = false;
            }
        }

        private void tsBtnSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings(EmployeeID);
            s.ShowDialog();
        }

        
        //======================================================================//
        //======================================================================//
        //======================================================================//
        #endregion


    }
}
