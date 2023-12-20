using newHouseCommittee.Entities;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    internal class PaymentService:IPaymentService
    {
        private readonly IPaymentService paymentService;
        public PaymentService(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
        public List<Payment> GetPaymentes()
        {
            return paymentService.GetPaymentes();
        }
        public Payment GetPayMentById(int id)
        {
            return paymentService.GetPayMentById((int)id);
        }
    }
}
