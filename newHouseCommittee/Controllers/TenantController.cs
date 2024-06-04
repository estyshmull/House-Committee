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
    public class TenantController : ControllerBase
    {
        private readonly ITenantService tenantService;
        private readonly IMapper _mapper;
        public TenantController(ITenantService service,IMapper mapper)
        {
            _mapper = mapper;   
            tenantService = service;
        }
        // GET: api/<TenantController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await tenantService.GetTenantsAsync());
        }

        // GET api/<TenantController>/5
        [HttpGet("{id}")]
        public ActionResult<Tenant> Get(int id)
        {
            var tenant=tenantService.GetTenantById(id);
            var tenantDto=_mapper.Map<TenantDTOs>(tenant);
            return Ok(tenantDto);
        }

        // POST api/<TenantController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TenantModel tenant)
        {
            var tenantToAdd = new Tenant {Name=tenant.Name,Phone=tenant.Phone };
            var newTenant = tenantService.AddTenantAsync(tenantToAdd);
            return Ok(newTenant);
        }

        // PUT api/<TenantController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Tenant tenant)
        {
            var tenantToAdd = new Tenant { Name = tenant.Name, Phone = tenant.Phone };
            var newTenant = tenantService.UpdateTenant(id,tenantToAdd);
            return Ok(newTenant);
        }
        // DELETE api/< TenantController >/ 5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await tenantService.DeleteTenantAsync(id);
            return NoContent();
        }
    }
}
