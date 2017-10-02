using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace Polygraphy
{
    class DBConnector
    {
        string connectionString;
        public DBConnector()
        {
            connectionString = "Server=127.0.0.1;Uid=root;Pwd=root;Database=polli;Charset=cp1251;";
        }
        public DBConnector(string _connectionString)
        {
            connectionString = _connectionString;
        }

        /*===================================================*/
        /* ================ СВЯЗЬ С БД ======================*/
        /*===================================================*/
        public int Connect(string ConnectPath, string UserName, string Password, string Params)
        {

            return 0;
        }       // связь с БД
        public Employee CheckUser(string UserName, string UserPassword)
        {
            Employee e = null;
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT position,name,id FROM employee WHERE phone='" + UserName + "' AND password='" + UserPassword + "';";
                MySqlDataReader reader = msCom.ExecuteReader();
                if (reader.Read())
                {
                    e = new Employee();
                    e.Role = (uint)reader.GetInt32("position");
                    e.Name = reader["name"].ToString();
                    e.Code = (uint)reader.GetInt32("id");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return e;
        }
        /*===================================================*/
        /*===================================================*/
        /*===================================================*/


        /*===================================================*/
        /* ========= ДОБАВЛЕНИЕ|ИЗМЕНЕНИЕ ===================*/
        /*===================================================*/
        public int EditMaterial(Material m, bool IsAdd)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string packageCol = m.PackageQuantity.ToString().Replace(",", ".");
            string price = m.Price.ToString().Replace(",", ".");
            try
            {
                if (IsAdd)
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "INSERT INTO `polli`.`materials` (`name`,`packageCol`,`description`,`price`) VALUES "
                            + "('" + m.Name + "'"
                            + ",'" + packageCol + "'"
                            + ",'" + m.Description + "'"
                            + ",'" + price + "');";
                    msCom.ExecuteNonQuery();
                }
                else
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "UPDATE `polli`.`materials` SET "
                            + "`name`='" + m.Name + "'"
                            + ",`packageCol`='" + packageCol + "'"
                            + ",`description`='" + m.Description + "'"
                            + ",`price`='" + price + "'"
                            + " WHERE id=" + m.Code + ";";
                    msCom.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
        }
        public int EditService(Service s, bool IsAdd)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string price = s.Price.ToString().Replace(",", ".");

            try
            {
                if (IsAdd)
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "INSERT INTO `polli`.`services` (`name`,`description`,`price`, `material_id`) VALUES "
                            + "('" + s.Name + "'"
                            + ",'" + s.Description + "'"
                            + ",'" + price + "'"
                            + ",'" + s.MaterialID.ToString() + "');";
                    msCom.ExecuteNonQuery();
                }
                else
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "UPDATE `polli`.`services` SET "
                            + "`name`='" + s.Name + "'"
                            + ",`description`='" + s.Description + "'"
                            + ",`price`='" + price + "'"
                            + ",`material_id`='" + s.MaterialID.ToString() + "'"
                            + " WHERE id=" + s.Code + ";";
                    msCom.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return 0;
        }
        public int EditOrder(Order o, bool IsAdd)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string price = o.Price.ToString().Replace(",", ".");

            try
            {
                if (IsAdd)
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "INSERT INTO `polli`.`orders` (`date_start`,`date_end`,`customer_id`,`service_id`," +
                        "`price`,`is_pay`,`employee_id`,`status`,`orderscol`) VALUES "
                            + "('" + o.StartDate.ToString("yyyyMMdd") +"'"
                            + ",'" + o.EndDate.ToString("yyyyMMdd") + "'"
                            + ",'" + o.CustomerCode.ToString() + "'"
                            + ",'" + o.ServiceCode.ToString() + "'"
                            + ",'" + price + "'"
                            + "," + o.IsPay.ToString() + ""
                            + ",'" + o.EmployeeCode.ToString() + "'"
                            + "," + o.IsEnd.ToString() + ""
                            + ",'" + o.Count.ToString() + "');";
                    msCom.ExecuteNonQuery();
                }
                else
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "UPDATE `polli`.`orders` SET "
                            + "`date_start`='" + o.StartDate.ToString("yyyyMMdd") + "'"
                            + ",`date_end`='" + o.EndDate.ToString("yyyyMMdd") + "'"
                            + ",`customer_id`='" + o.CustomerCode.ToString() + "'"
                            + ",`service_id`='" + o.ServiceCode.ToString() + "'"
                            + ",`price`='" + price + "'"
                            + ",`is_pay`=" + o.IsPay.ToString() + ""
                            + ",`employee_id`='" + o.EmployeeCode.ToString() + "'"
                            + ",`status`=" + o.IsEnd.ToString() + ""
                            + ",`orderscol`='" + o.Count.ToString() + "'"
                            + " WHERE id=" + o.Code.ToString() + ";";
                    msCom.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return 0;
        }
        public int EditCustomer(Customer c, bool IsAdd)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {
                if (IsAdd)
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "INSERT INTO `polli`.`customers` (`name`,`address`,`phone`,`passport`,`sale`) VALUES "
                            + "('" + c.Name + "'"
                            + ",'" + c.Adress + "'"
                            + ",'" + c.Phone + "'"
                            + ",'" + c.Passport + "'"
                            + ",'" + c.Sale + "');";
                    msCom.ExecuteNonQuery();
                }
                else
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "UPDATE `polli`.`customers` SET "
                            + "`name`='" + c.Name + "'"
                            + ",`address`='" + c.Adress + "'"
                            + ",`phone`='" + c.Phone + "'"
                            + ",`passport`='" + c.Passport + "'"
                            + ",`sale`='" + c.Sale + "'"
                            + " WHERE id=" + c.Code + ";";
                    msCom.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
        }
        public int EditEmployee(Employee e, bool IsAdd)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {
                if(IsAdd)
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "INSERT INTO `polli`.`employee` (`name`,`age`,`sex`,`address`,`phone`,`passport`,`position`,`password`) VALUES "
                            + "('" + e.Name + "'"
                            + ",'" + e.Age + "'"
                            + ",'" + e.Sex + "'"
                            + ",'" + e.Adress + "'"
                            + ",'" + e.Phone + "'"
                            + ",'" + e.Passport + "'"
                            + ",'" + e.Role + "'"
                            + ",'" + e.Passowrd + "');";
                    msCom.ExecuteNonQuery();
                }
                else
                {
                    msCon.Open();
                    msCom.Connection = msCon;
                    msCom.CommandText = "UPDATE `polli`.`employee` SET "
                            + "`name`='" + e.Name + "'"
                            + ",`age`='" + e.Age + "'"
                            + ",`sex`='" + e.Sex + "'"
                            + ",`address`='" + e.Adress + "'"
                            + ",`phone`='" + e.Phone + "'"
                            + ",`passport`='" + e.Passport + "'"
                            + ",`position`='" + e.Role + "'"
                            + " WHERE id="+ e.Code +";";
                    msCom.ExecuteNonQuery();
                }
                
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
               throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
        }


        public int IncSaleCustomer(int incSale, int cid)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {
                int sale=0;
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT sale FROM `customers` WHERE id= " + cid.ToString() + ";";
                MySqlDataReader reader = msCom.ExecuteReader();
                if(reader.Read())
                {
                    sale = reader.GetInt32("sale");
                    sale +=incSale;
                    msCon.Close();

                    msCon.Open();
                    msCom.CommandText = "UPDATE `polli`.`customers` SET "
                        + "`sale`=" + sale + ""
                        + " WHERE id=" + cid + ";";
                    msCom.ExecuteNonQuery();
                }                

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
        }

        public int ChangePassword(int ee, string pass)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {

                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "UPDATE `employee` SET "
                    + "`password`=" + pass + ""
                    + " WHERE id=" + ee.ToString() + ";";
                msCom.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
        }

        /* ================== УДАЛЕНИЕ ======================*/
        public int DeleteMaterial(uint MaterialCode)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "DELETE FROM `polli`.`materials` WHERE id=" + MaterialCode + ";";
                msCom.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
        }
        public int DeleteService(uint ServiceCode)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "DELETE FROM `polli`.`services` WHERE id=" + ServiceCode + ";";
                msCom.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return 0;
        }
        public int DeleteOrder(uint OrderCode)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "DELETE FROM `polli`.`orders` WHERE id=" + OrderCode + ";";
                msCom.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
            return 0;
        }
        public int DeleteCustomer(uint CustomerCode)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "DELETE FROM `polli`.`customers` WHERE id=" + CustomerCode + ";";
                msCom.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
        }
        public int DeleteEmployee(uint EmployeeCode)
        {
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();

            try
            {                
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "DELETE FROM `polli`.`employee` WHERE id=" + EmployeeCode + ";";
                msCom.ExecuteNonQuery();            

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }

            return 0;
        }

        /*===================================================*/
        /*===================================================*/
        /*===================================================*/


        /*===================================================*/
        /* ===================== Поиск ======================*/
        /*===================================================*/
        public List<Material> SearchMaterial(string Field, string SearchText, bool ExtendetSearch)      // поиск по материалам
        {
            List<Material> materials = new List<Material>();
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string addQue=";";

            if (!ExtendetSearch)
            {
                if (!SearchText.Equals(""))
                {
                    if (Field.Equals("id"))
                    {
                        addQue = "WHERE " + Field + " ='" + SearchText + "';";
                    }
                    else
                    {
                        addQue = "WHERE " + Field + " LIKE '%" + SearchText + "%';";
                    }
                }
                else
                {
                    addQue = ";";
                }
            }
            else
            {
                addQue = SearchText;
            }            

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT * FROM materials " + addQue;
                MySqlDataReader reader = msCom.ExecuteReader();
                while(reader.Read())
                {
                    Material m = new Material();
                    m.Name = reader["name"].ToString();
                    m.Description = reader["description"].ToString();
                    m.PackageQuantity = reader.GetInt32("packageCol");
                    m.Price = (float)reader.GetFloat("price");
                    m.Code = (uint)reader.GetInt32("id");
                    materials.Add(m);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return materials;
        }
        public List<Service> SearchService(string Field, string SearchText, bool ExtendetSearch)        // поиск по услугам
        {
            List<Service> services = new List<Service>();
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string addQue = ";";

            if (!ExtendetSearch)
            {
                if (!SearchText.Equals(""))
                {
                    if (Field.Equals("s.id"))
                    {
                        addQue = "WHERE " + Field + " ='" + SearchText + "';";
                    }
                    else
                    {
                        addQue = "WHERE " + Field + " LIKE '%" + SearchText + "%';";
                    }
                }
                else
                {
                    addQue = ";";
                }
            }
            else
            {
                addQue = SearchText;
            }

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT s.id, s.name, s.description, s.price, s.material_id, m.name as materialName FROM services s "
                    + " inner join materials m on s.material_id = m.id " + addQue;
                MySqlDataReader reader = msCom.ExecuteReader();
                while (reader.Read())
                {
                    Service s = new Service();
                    s.Code = (uint)reader.GetInt32("id");
                    s.Name = reader["name"].ToString();
                    s.Description = reader["description"].ToString();
                    s.Price = reader.GetFloat("price");
                    s.MaterialID = reader.GetInt32("material_id");
                    s.MaterialName = reader["materialName"].ToString();
                    services.Add(s);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return services;
        }
        public List<Order> SearchOrder(string Field, string SearchText, bool ExtendetSearch)            // поиск по заказам
        {
            List<Order> orders = new List<Order>();
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string addQue = ";";

            if (!ExtendetSearch)
            {
                if (!SearchText.Equals(""))
                {
                    if (Field.Equals("id"))
                    {
                        addQue = "WHERE " + Field + " ='" + SearchText + "';";
                    }
                    else
                    {
                        addQue = "WHERE " + Field + " LIKE '%" + SearchText + "%';";
                    }
                }
                else
                {
                    addQue = ";";
                }
            }
            else
            {
                addQue = SearchText;
            }

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "select o.id, o.date_start, o.date_end, o.customer_id, o.service_id, o.price, o.is_pay, o.employee_id, o.status, o.orderscol,"
	                +" e.name ename, s.name sname, c.name cname from orders o "
                    + " inner join employee e on e.id=o.employee_id "
                    + " inner join services s on s.id=o.service_id "
                    + " inner join customers c on c.id=o.customer_id " + addQue;
                MySqlDataReader reader = msCom.ExecuteReader();
                while (reader.Read())
                {
                    Order o = new Order();
                    o.Code = (uint)reader.GetInt32("id");
                    o.Count = reader.GetInt32("orderscol");
                    o.CustomerCode = reader.GetInt32("customer_id");
                    o.EmployeeCode = reader.GetInt32("employee_id");
                    o.ServiceCode = reader.GetInt32("service_id");
                    o.CustomerName = reader["cname"].ToString();
                    o.EmployeeName = reader["ename"].ToString();
                    o.ServiceName = reader["sname"].ToString();
                    o.IsEnd = reader.GetBoolean("status");
                    o.IsPay = reader.GetBoolean("is_pay");
                    o.Price = reader.GetFloat("price");
                    o.StartDate = DateTime.Parse(reader.GetMySqlDateTime("date_start").ToString());
                    o.EndDate = DateTime.Parse(reader.GetMySqlDateTime("date_end").ToString());
                    o.Count = reader.GetInt32("orderscol");
                    orders.Add(o);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return orders;
        }
        public List<Customer> SearchCustomer(string Field, string SearchText, bool ExtendetSearch)      // поиск по заказчикам
        {
            List<Customer> customers = new List<Customer>();
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string addQue = ";";

            if (!ExtendetSearch)
            {
                if (!SearchText.Equals(""))
                {
                    if (Field.Equals("id"))
                    {
                        addQue = "WHERE " + Field + " ='" + SearchText + "';";
                    }
                    else
                    {
                        addQue = "WHERE " + Field + " LIKE '%" + SearchText + "%';";
                    }
                }
                else
                {
                    addQue = ";";
                }
            }
            else
            {
                addQue = SearchText;
            }


            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT * FROM customers " + addQue;
                MySqlDataReader reader = msCom.ExecuteReader();
                while (reader.Read())
                {
                    Customer c = new Customer();
                    c.Code = (uint)reader.GetInt32("id");
                    c.Name = reader["name"].ToString();
                    c.Passport = reader["passport"].ToString();
                    c.Phone = reader["phone"].ToString();
                    c.Adress = reader["address"].ToString();
                    c.Sale = reader.GetInt32("sale");
                    customers.Add(c);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return customers;
        }
        public List<Employee> SearchEmployee(string Field, string SearchText, bool ExtendetSearch)      // поиск по сотрудникам
        {
            List<Employee> employees = new List<Employee>();
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string addQue=";";

            if (!ExtendetSearch)
            {
                if (!SearchText.Equals(""))
                {
                    if (Field.Equals("id"))
                    {
                        addQue = "WHERE " + Field + " ='" + SearchText + "';";
                    }
                    else
                    {
                        addQue = "WHERE " + Field + " LIKE '%" + SearchText + "%';";
                    }
                }
                else
                {
                    addQue = ";";
                }
            }
            else
            {
                addQue = SearchText;
            }
            

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT * FROM employee " + addQue;
                MySqlDataReader reader = msCom.ExecuteReader();
                while(reader.Read())
                {
                    Employee e = new Employee();
                    e.Name = reader["name"].ToString();
                    e.Passport = reader["passport"].ToString();
                    e.Phone = reader["phone"].ToString();
                    e.Role = (uint)reader.GetInt32("position");
                    e.Sex = reader["sex"].ToString();
                    e.Adress = reader["address"].ToString();
                    e.Age = (uint)reader.GetInt32("age");
                    e.Code = (uint)reader.GetInt32("id");
                    switch (e.Role)
                    {
                        case (uint)PolyRoles.Admin:
                            e.Position = "Администратор";
                            break;
                        case (uint)PolyRoles.Employee:
                            e.Position = "Менеджер";
                            break;
                        case (uint)PolyRoles.Manager:
                            e.Position = "Главный менеджер";
                            break;
                    }
                    employees.Add(e);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return employees;
        }


        public List<Material> SearchMaterialTypes()                                                     // список типов материалов
        {
            List<Material> materials = new List<Material>();
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string addQue = ";";

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT id,name FROM materials " + addQue;
                MySqlDataReader reader = msCom.ExecuteReader();
                while (reader.Read())
                {
                    Material m = new Material();
                    m.Name = reader["name"].ToString();
                    m.Code = (uint)reader.GetInt32("id");
                    materials.Add(m);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return materials;
        }
        public List<Customer> SearchCustomersTypes()                                                    // список типов материалов
        {
            List<Customer> customer = new List<Customer>();
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string addQue = ";";

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT id,name,sale FROM customers " + addQue;
                MySqlDataReader reader = msCom.ExecuteReader();
                while (reader.Read())
                {
                    Customer c = new Customer();
                    c.Name = reader["name"].ToString();
                    c.Code = (uint)reader.GetInt32("id");
                    c.Sale = reader.GetInt32("sale");
                    customer.Add(c);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return customer;
        }
        public List<Service> SearchServicesTypes()                                                     // список типов материалов
        {
            List<Service> services = new List<Service>();
            MySqlConnection msCon = new MySqlConnection(connectionString);
            MySqlCommand msCom = new MySqlCommand();
            string addQue = ";";

            try
            {
                msCon.Open();
                msCom.Connection = msCon;
                msCom.CommandText = "SELECT id,name, price FROM services " + addQue;
                MySqlDataReader reader = msCom.ExecuteReader();
                while (reader.Read())
                {
                    Service m = new Service();
                    m.Name = reader["name"].ToString();
                    m.Code = (uint)reader.GetInt32("id");
                    m.Price = reader.GetFloat("price");
                    services.Add(m);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                msCon.Close();
            }
            return services;
        }  
        /*===================================================*/
        /*===================================================*/
        /*===================================================*/

    }
}
