using System.Globalization;
using System.Formats.Asn1;
using CsvHelper;
using Microsoft.Extensions.Logging;

namespace newHouseCommittee.Entities
{
    public class DataContext:IDataContext
    {
        public List<Month> months { get; set; }
        public List<Tenant> tenantList { get; set; }
        public List<Payment> paymentList { get; set; }

        public DataContext()
        {
            using (var reader = new StreamReader("Month.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                months = csv.GetRecords<Month>().ToList();

            }
            using (var reader = new StreamReader("Tenant.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                tenantList = csv.GetRecords<Tenant>().ToList();


            }
            using (var reader = new StreamReader("Payment.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                paymentList = csv.GetRecords<Payment>().ToList();

            }
        }
    }
}

