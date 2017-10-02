using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygraphy
{
    public class Material
    {
        [System.ComponentModel.DisplayName("Номер")]
        public uint Code { get; set; }

        [System.ComponentModel.DisplayName("Наименование")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Упаковка")]
        public int PackageQuantity { get; set; }

        [System.ComponentModel.DisplayName("Описание")]
        public string Description { get; set; }

        [System.ComponentModel.DisplayName("Цена")]
        public float Price { get; set; }

        public Material()
        {
            Code = 0;
            Name = "";
            PackageQuantity = 0;
            Description = "";
            Price = 0;
        }
        public Material(uint code, string name, int packageQuantity, string description, float price)
        {
            Code = code;
            Name = name;
            PackageQuantity = packageQuantity;
            Description = description;
            Price = price;
        }

    }

    public class Service
    {
        [System.ComponentModel.DisplayName("Номер")]
        public uint Code { get; set; }

        [System.ComponentModel.DisplayName("Наименование")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Описание")]
        public string Description { get; set; }

        [System.ComponentModel.DisplayName("Цена")]
        public float Price { get; set; }

        public int MaterialID { get; set; }

        [System.ComponentModel.DisplayName("Материал")]
        public string MaterialName { get; set; }
        

        public Service()
        {
            Code = 0;
            Name = "";
            Description = "";
            Price = 0;
            MaterialID = 0;
            MaterialName = "";
        }
        public Service(uint code, string name, string description, float price, int materialID, string materialName)
        {
            Code = code;
            Name = name;
            Description = description;
            Price = price;
            MaterialID = materialID;
            MaterialName = materialName;
        }
    }

    public class Employee
    {
        [System.ComponentModel.Bindable(false)]
        public uint Role { get; set; }              //для разграничения прав доступа

        [System.ComponentModel.DisplayName("Номер")]
        public uint Code { get; set; }

        [System.ComponentModel.DisplayName("ФИО")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Возраст")]
        public uint Age { get; set; }

        [System.ComponentModel.DisplayName("Пол")]
        public string Sex { get; set; }

        [System.ComponentModel.DisplayName("Адрес")]
        public string Adress { get; set; }

        [System.ComponentModel.DisplayName("Телефон")]
        public string Phone { get; set; }

        [System.ComponentModel.DisplayName("Паспорт")]
        public string Passport { get; set; }

        [System.ComponentModel.DisplayName("Должность")]
        public string Position { get; set; }

        public string Passowrd { get; set; }    

        public Employee()
        {
            Role = 0;
            Code = 0;
            Name = "";
            Age = 0;
            Sex = "";
            Adress = "";
            Phone = "";
            Passport = "";
            Passowrd = "";
           
        }
        public Employee(uint role, uint code, string name, uint age, string sex, string adress, string phone, string passport, string position)
        {
            Role = role;
            Code = code;
            Name = name;
            Age = age;
            Sex = sex;
            Adress = adress;
            Phone = phone;
            Passport = passport;
            Position = position;
            Passowrd = "";
        }
    }

    public class Customer
    {
        [System.ComponentModel.DisplayName("Номер")]
        public uint Code { get; set; }

        [System.ComponentModel.DisplayName("ФИО")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Адрес")]
        public string Adress { get; set; }

        [System.ComponentModel.DisplayName("Телефон")]
        public string Phone { get; set; }

        [System.ComponentModel.DisplayName("Пасспорт")]
        public string Passport { get; set; }

        [System.ComponentModel.DisplayName("Скидка")]
        public int Sale { get; set; }

        public Customer()
        {
            Code = 0;
            Name = "";
            Adress = "";
            Phone = "";
            Passport = "";
            Sale = 0;
        }
        public Customer(uint code, string name, string adress, string phone, string passport, int sale)
        {
            Code = code;
            Name = name;
            Adress = adress;
            Phone = phone;
            Passport = passport;
            Sale = sale;
        }
    }

    public class Order
    {
        [System.ComponentModel.DisplayName("Номер")]
        public uint Code { get; set; }

        [System.ComponentModel.DisplayName("Начало")]
        public DateTime StartDate { get; set; }

        [System.ComponentModel.DisplayName("Окончание")]
        public DateTime EndDate { get; set; }

        [System.ComponentModel.DisplayName("Заказчик")]
        public string CustomerName { get; set; }

        public int CustomerCode { get; set; }

        [System.ComponentModel.DisplayName("Услуга")]
        public string ServiceName { get; set; }

        public int ServiceCode { get; set; }

        [System.ComponentModel.DisplayName("Сотрудник")]
        public string EmployeeName { get; set; }
        public int EmployeeCode { get; set; }

        [System.ComponentModel.DisplayName("Количество")]
        public int Count { get; set; }

        [System.ComponentModel.DisplayName("Сумма")]
        public float Price { get; set; }

        [System.ComponentModel.DisplayName("Оплата")]
        public bool IsPay { get; set; }

        [System.ComponentModel.DisplayName("Статус")]
        public bool IsEnd { get; set; }

        public Order()
        {
            Code = 0;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            CustomerCode = 0;
            CustomerName = "";
            ServiceName = "";
            ServiceCode = 0;
            EmployeeName = "";
            EmployeeCode = 0;
            Count = 0;
            Price = 0;
            IsPay = false;
            IsEnd = false;
        }
        public Order(uint code, DateTime startDate, DateTime endDate,
            string customerName, int customerCode, string serviceName, int serviceCode, string employeeName, int employeeCode, int count,
            float price, bool isPay, bool isEnd)
        {
            Code = 0;
            StartDate = startDate;
            EndDate = endDate;
            CustomerCode = customerCode;
            CustomerName = customerName;
            ServiceName = serviceName;
            ServiceCode = serviceCode;
            EmployeeName = employeeName;
            EmployeeCode = employeeCode;
            Count = count;
            Price = price;
            IsPay = isPay;
            IsEnd = IsEnd;
        }
    }

    public enum PolyTabs { Orders, Services, Customers, Materials, Employees}
    public enum PolyRoles { Admin=1, Manager, Employee}
}
