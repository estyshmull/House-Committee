using newHouseCommittee.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class PaymentRepository:IPaymentRepository
    {
        private readonly DataContext dataContext;
        public PaymentRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public List<Payment> GetPaymentes()
        {
            return dataContext.paymentList;
        }
        public Payment GetPayMentById(int id)
        {
            if (dataContext.paymentList[id] == null)
                return null;
            return dataContext.paymentList[id];
        }
        public List<Payment> Get(Epurpose epurpose)
        {
            if (epurpose == Epurpose.electrical || epurpose == Epurpose.cleaner || epurpose == Epurpose.water)
            {
                var a = dataContext.paymentList.FindAll(x => x.epurpose == epurpose).ToList();
                return a;
            }
            return null;
        }
        Payment Post(Payment payment)
        {
            dataContext.paymentList.Add(payment);
            return payment;
        }
        public Payment Put(int id, Payment payment)
        {
            if (dataContext.paymentList[id] == null)
                return null;
            else
            {
                var update = dataContext.paymentList.Find(u => u.Id == id);
                update.IsPayd = payment.IsPayd;
                return update;
            }
        }
    }
}
