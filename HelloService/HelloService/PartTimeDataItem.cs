using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EmployeeService
{
    
    public class PartTimeDataItem : DataItem
    {
       
        public int HoursPay { get; set; }
       
        public int HoursWorked { get; set; }
    }
}
