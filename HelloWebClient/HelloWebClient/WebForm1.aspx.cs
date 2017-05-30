using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetEmp(object sender, EventArgs e)
        {
            
            Service.ServiceClient client = new Service.ServiceClient();
            Service.DataItem data = client.GetEmployee(Convert.ToInt32(ID_TextBox.Text));
           

            if (data.Type == Service.DataItem.DataType.FullTimeDataItem)
            {
                AnnualSalary_TextBox.Text = ((Service.FullTimeDataItem)data).AnnualSalary.ToString();
                trAnnualSalary.Visible = true;
                trHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
                Name_TextBox.Text = data.name;
                Gender_TextBox.Text = data.gender;
                DateOfBirth_TextBox.Text = data.dateOfBirth.ToString();
                int annualSalary = ((Service.FullTimeDataItem)data).AnnualSalary;
                AnnualSalary_TextBox.Text = annualSalary.ToString();
                DropDownList1.SelectedIndex = 1;
            } else
            {
                HourlyPay_TextBox.Text = ((Service.PartTimeDataItem)data).HoursPay.ToString();
                HoursWorked_TextBox.Text = ((Service.PartTimeDataItem)data).HoursWorked.ToString();
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = true;
                trHoursWorked.Visible = true;
                Name_TextBox.Text = data.name;
                Gender_TextBox.Text = data.gender;
                DateOfBirth_TextBox.Text = data.dateOfBirth.ToString();
                int HourlyPay = ((Service.PartTimeDataItem)data).HoursPay;
                int HoursWorked = ((Service.PartTimeDataItem)data).HoursWorked;
                HourlyPay_TextBox.Text = HourlyPay.ToString();
                HoursWorked_TextBox.Text = HoursWorked.ToString();
                DropDownList1.SelectedIndex = 2;
            }             
      } 
            
       

               protected void InsEmp(object sender, EventArgs e)
        {
            Service.ServiceClient client = new Service.ServiceClient();
            if (DropDownList1.SelectedIndex == 1)
            {
                Service.FullTimeDataItem data = new Service.FullTimeDataItem()
                {
                    id = ID_TextBox.Text,
                    name = Name_TextBox.Text,
                    gender = Gender_TextBox.Text,
                    dateOfBirth = DateTime.Parse(DateOfBirth_TextBox.Text),
                    Type = Service.DataItem.DataType.FullTimeDataItem,
                    AnnualSalary = Convert.ToInt32(AnnualSalary_TextBox.Text)
                };
                client.SetEmployee(data);
            } else if (DropDownList1.SelectedIndex == 2)
            {
                Service.PartTimeDataItem data = new Service.PartTimeDataItem()
                {
                    id = ID_TextBox.Text,
                    name = Name_TextBox.Text,
                    gender = Gender_TextBox.Text,
                    dateOfBirth = DateTime.Parse(DateOfBirth_TextBox.Text),
                    Type = Service.DataItem.DataType.FullTimeDataItem,
                    HoursPay = Convert.ToInt32(HourlyPay_TextBox.Text),
                    HoursWorked = Convert.ToInt32(HoursWorked_TextBox.Text)
                };
                client.SetEmployee(data);
                StatusCheck_Label.Text = "запись внесена!";
            }   else
            {
                StatusCheck_Label.Text = "выберите DataType!";
            }           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            } else if (DropDownList1.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            } else
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = true;
                trHoursWorked.Visible = true;
            }
        }
    }
}