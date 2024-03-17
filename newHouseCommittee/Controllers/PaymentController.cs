using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newHouseCommittee.Entities;
using newHouseCommittee.Models;
using Solid.Core.DTOs;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Core.Servies;
using Solid.Service;
using System;

namespace newHouseCommittee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;
        private readonly IMapper _mapper;
        public PaymentController(IPaymentService service,IMapper mapper)
        {
            _mapper = mapper;
            paymentService = service;
        }
        // GET: api/<MonthController>
        [HttpGet]
        public ActionResult<Payment> Get()
        {
            var list = paymentService.GetPayments();
            var listDto = _mapper.Map<IEnumerable<PaymentDTOs>>(list);
            return Ok(listDto);
        }

        // GET api/<MonthController>/5
        [HttpGet("{id}")]
        public ActionResult<Payment> Get(int id)
        {
            var payment = paymentService.GetPaymentById(id);
            var paypentDto = _mapper.Map<PaymentDTOs>(payment);
            return Ok(paypentDto);
        }

        // POST api/<MonthController>
        [HttpPost]
        public ActionResult Post([FromBody] PaymentModel payment)
        {
            var paymentToAdd=new Payment{ Month=payment.Month,Year=payment.Year};
            var newPayment = paymentService.AddPayment(paymentToAdd);
            return Ok(newPayment);
        }

        // PUT api/<MonthController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id,[FromBody] PaymentDTOs payment)
        {
            var paymentToAdd = new Payment { Month = payment.Month, Year = payment.Year };
            var newPayment = paymentService.UpdatePayment(id,paymentToAdd);
            return Ok(newPayment);
        }

    }
}
