using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace EmployeeService
{

   [KnownType(typeof(FullTimeDataItem))]
   [KnownType(typeof(PartTimeDataItem))]
    [DataContract]
    public class DataItem
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
        [DataMember]
        public string gender;
        [DataMember]
        public DateTime dateOfBirth;
        [DataMember]
        public DataType Type;


        public enum DataType
        {
            FullTimeDataItem = 1,
            PartTimeDataItem = 2
        };

       
    }
}
