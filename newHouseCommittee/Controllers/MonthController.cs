using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newHouseCommittee.Entities;
using System;

namespace newHouseCommittee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MonthController : ControllerBase
    {
        private DataContext dataContext;

        public MonthController(DataContext context)
        {
            dataContext = context;
        }
        // GET: api/<MonthController>
        [HttpGet]
        public List<Month> Get()
        {
            return dataContext.months;
        }

        // GET api/<MonthController>/5
        [HttpGet("{id}")]
        public ActionResult<Month> Get(int id)
        {
            if (dataContext.months[id] == null)
                return NotFound();
            return dataContext.months[id];
        }
        [HttpGet("{id},{IsTake}")]
        public ActionResult<List<Month>> Get(int id, bool isTake)
        {
            if (dataContext.months[id] == null)
                return NotFound();
            var a = dataContext.months.FindAll(x => x.IsTake == isTake).ToList();
            return a;
        }

        // POST api/<MonthController>
        [HttpPost]
        public void Post(EmonthName name1)
        {
            dataContext.months.Add(new Month() { Name = name1 });
        }

        // PUT api/<MonthController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {

            if (dataContext.months[id] == null)
                NotFound();
            else
                dataContext.months[id].IsTake = true;
        }

    }
}
