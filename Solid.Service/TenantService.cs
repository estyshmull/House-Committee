using newHouseCommittee.Entities;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    internal class TenantService:ITenanService
    {
        private readonly ITenanService tenanService;
        public TenantService(ITenanService tenanService)
        {
            this.tenanService = tenanService;
        }
        public List<Tenant> GetTenantList()
        {
            return tenanService.GetTenantList();
        }
        public Tenant GetTenantById(int id)
        {
            return tenanService.GetTenantById(id);
        }
    }
}
