using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iikoTestServer.Models.Task3
{
    [XmlRoot("salaries")]
    public class SalariesWrapper
    {
        [XmlElement("salary")]
        public List<EmployeesSalaryModel> Salaries { get; set; }
    }
}
