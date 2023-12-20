using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IPaymentRepository
    {
        List<Payment> GetPaymentes();
        Payment GetPayMentById(int id);
        List<Payment> Get(Epurpose epurpose);
        void Post(EMethods eMethods_Of, Epurpose epurpose, int sum);
        void Put(int id);
    }
}
