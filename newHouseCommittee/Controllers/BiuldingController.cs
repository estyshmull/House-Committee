using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newHouseCommittee.Entities;
using Solid.Core.DTOs;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Core.Servies;
using Solid.Service;

namespace newHouseCommittee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiuldingController : ControllerBase
    {
        private readonly IBiuldingService biuldingService;
        private readonly IMapper _mapper;
        public BiuldingController(IBiuldingService service,IMapper mapper)
        {
            _mapper = mapper;
            biuldingService = service;
        }

        // GET: api/<PaymentController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list=await biuldingService.GetBuildingsAsync();
            var listDto = _mapper.Map<IEnumerable<BiuldingDTOs>>(list);
            return Ok(listDto);
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id}")]
        public ActionResult<Biulding> Get(int id)
        {
            var biulding = biuldingService.GetBuildingById(id);
            var biuldingDto = _mapper.Map<BiuldingDTOs>(biulding);
            return Ok(biuldingDto);
        }
        // GET api/<PaymentController>/5
        [HttpGet("{id}/street")]
        public ActionResult<Biulding> Get(int id,string street)
        {
            var biulding = biuldingService.GetBuildingById(id);
            var biuldingDto = _mapper.Map<BiuldingDTOs>(biulding);
            return Ok(biuldingDto);
        }

        // POST api/<PaymentController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] BiuldingDTOs biulding)
        {
            var biuldingToAdd = new Biulding { };
            var newBiulding = await biuldingService.AddBuildingAsync(biuldingToAdd);
            return Ok(newBiulding);
        }

        // PUT api/<PaymentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id,BiuldingDTOs biulding)
        {
            var biuldingToAdd = new Biulding { };
            var newBiulding = biuldingService.UpdateBuilding(id,biuldingToAdd);
            return Ok(newBiulding);
        }

    }
}
