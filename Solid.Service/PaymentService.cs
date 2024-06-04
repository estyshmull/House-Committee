using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newHouseCommittee.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Core.Servies;

namespace Solid.Service
{
    public class PaymentService:IPaymentService
    {
        private readonly IPaymentRepository paymentRepository;
        public PaymentService(IPaymentRepository payment)
        {
            this.paymentRepository = payment;
        }

        public async Task<Payment> AddPaymentAsync(Payment payment)
        {
            return await paymentRepository.AddPaymentAsync(payment);
        }

        public Payment GetPaymentById(int id)
        {
            return paymentRepository.GetPaymentById(id);
        }

        public async Task<IEnumerable<Payment>> GetPaymentsAsync()
        {
            return await paymentRepository.GetPaymentsAsync();
        }

        public Payment UpdatePayment(int id, Payment payment)
        {
            return paymentRepository.UpdatePayment(id, payment);
        }
    }
}
