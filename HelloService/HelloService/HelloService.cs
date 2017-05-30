using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EmployeeService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service : IService
    {
        public DataItem GetEmployee(int id)
        {
            DataItem data = null;        
            MySqlConnection connection;
            string mySQLconnectionString = "server = localhost; User Id = admin; password = manowar; database = test;";
            connection = new MySqlConnection(mySQLconnectionString);           
            MySqlCommand cmd = new MySqlCommand("GetEmployee", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("id", id));
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                if ((DataItem.DataType)dr["DataType"] == DataItem.DataType.FullTimeDataItem)               
                {
                    data = new FullTimeDataItem()
                    {
                      id = dr["id"].ToString(),
                      name = dr["Name"].ToString(),
                      gender = dr["Gender"].ToString(),
                      dateOfBirth = (DateTime)dr["DateOfBirth"],
                      Type = DataItem.DataType.FullTimeDataItem,
                      AnnualSalary = Convert.ToInt32(dr["AnnualSalary"].ToString())};                    
                }
                if ((DataItem.DataType)dr["DataType"] == DataItem.DataType.PartTimeDataItem)
                {
                    data = new PartTimeDataItem()
                    {
                       id = dr["id"].ToString(),
                       name = dr["Name"].ToString(),
                        gender = dr["Gender"].ToString(),
                       dateOfBirth = (DateTime)dr["DateOfBirth"],
                       Type = DataItem.DataType.PartTimeDataItem,
                       HoursPay = Convert.ToInt32(dr["Hourspay"].ToString()),
                        HoursWorked = Convert.ToInt32(dr["HoursWorked"].ToString())};                                       
                }
            }
            return data;
        }         
        
        public void SetEmployee(DataItem item)
        {          
            MySqlConnection connection;
            string mySQLconnectionString = "server = localhost; User Id = admin; password = manowar; database = test;";
            connection = new MySqlConnection(mySQLconnectionString);
            MySqlCommand cmd = new MySqlCommand("setEmployee", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("id", item.id));
            cmd.Parameters.Add(new MySqlParameter("Name", item.name));
            cmd.Parameters.Add(new MySqlParameter("Gender", item.gender));
            cmd.Parameters.Add(new MySqlParameter("DateOfBirth", item.dateOfBirth));
            cmd.Parameters.Add(new MySqlParameter("DataType", item.Type));
            if (item.GetType() == typeof(FullTimeDataItem))
            {
                int value = ((FullTimeDataItem)item).AnnualSalary;
                cmd.Parameters.Add(new MySqlParameter("AnnualSalary", value));
                cmd.Parameters.Add(new MySqlParameter("Hourspay", null));
                cmd.Parameters.Add(new MySqlParameter("HoursWorked", null));
            } else
            {
                int val1 = ((PartTimeDataItem)item).HoursPay;
                int val2 = ((PartTimeDataItem)item).HoursWorked;
                cmd.Parameters.Add(new MySqlParameter("AnnualSalary", null));
                cmd.Parameters.Add(new MySqlParameter("Hourspay", val1));
                cmd.Parameters.Add(new MySqlParameter("HoursWorked", val2));
            }

            
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }    
        
    }
}
