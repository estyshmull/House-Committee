using Microsoft.EntityFrameworkCore;
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

        public async Task<Payment> AddPaymentAsync(Payment payment)
        {
            dataContext.PaymentList.Add(payment);
            await dataContext.SaveChangesAsync();
            return payment;
        }
         
        public Payment GetPaymentById(int id)
        {
            return dataContext.PaymentList.Find(id);
        }

        public async Task<IEnumerable<Payment>> GetPaymentsAsync()
        {
            return await dataContext.PaymentList.ToListAsync();
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
