using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(EmployeeService.Service)))
            {
                host.Open();
                Console.WriteLine("service host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
