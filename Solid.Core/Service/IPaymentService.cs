using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IPaymentService
    {
        List<Payment> GetPaymentes();
        Payment GetPayMentById(int id);
    }
}
