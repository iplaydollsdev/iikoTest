using System;
using System.Xml.Serialization;

namespace iikoTestServer.Models.Task3
{
    public class EmployeesSalaryModel
    {
        [XmlElement("employeeId")]
        public string EmployeeId { get; set; }

        [XmlElement("dateFrom")]
        public DateTime DateFrom { get; set; }

        [XmlElement("dateTo")]
        public DateTime DateTo { get; set; }

        [XmlElement("payment")]
        public decimal Payment { get; set; }
    }
}
