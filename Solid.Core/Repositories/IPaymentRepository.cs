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
        Task<IEnumerable<Payment>> GetPaymentsAsync();
        Payment GetPaymentById(int id);
        Task<Payment> AddPaymentAsync(Payment payment);
        Payment UpdatePayment(int id,Payment payment);
    }
}
