using CsvHelper;
using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newHouseCommittee.Controllers;

namespace UnitTest
{
    public class DataContextFake:IDataContext
    {
        public List<Month> months { get; set; }
        public List<Tenant> tenantList { get; set; }
        public List<Payment> paymentList { get; set; }

        public DataContextFake()
        {
            using (var reader = new StreamReader("MonthTemp.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                months = csv.GetRecords<Month>().ToList();
            }
        }

    }
}
