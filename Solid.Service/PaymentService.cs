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

        public Payment AddPayment(Payment payment)
        {
            return paymentRepository.AddPayment(payment);
        }

        public Payment GetPaymentById(int id)
        {
            return paymentRepository.GetPaymentById(id);
        }

        public List<Payment> GetPayments()
        {
            return paymentRepository.GetPayments();
        }

        public Payment UpdatePayment(int id, Payment payment)
        {
            return paymentRepository.UpdatePayment(id, payment);
        }
    }
}
