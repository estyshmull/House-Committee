using newHouseCommittee.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solid.Data.Repositories
{
    public class PaymentRepository: IPaymentRepository
    {
        private readonly DataContext dataContext;
        public PaymentRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Payment AddPayment(Payment payment)
        {
            dataContext.PaymentList.Add(payment);
            dataContext.SaveChanges();
            return payment;
        }

        public Payment GetPaymentById(int id)
        {
            return dataContext.PaymentList.Find(id);
        }

        public List<Payment> GetPayments()
        {
            return dataContext.PaymentList.ToList();
        }

        public Payment UpdatePayment(int id,Payment payment)
        {
            var updatePayment = GetPaymentById(id);
            if (updatePayment != null)
            {
                updatePayment.Year = payment.Year;
                updatePayment.Month = payment.Month;
                dataContext.SaveChanges();
            }
            return updatePayment;
        }
    }
}
