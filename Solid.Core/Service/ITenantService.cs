using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface ITenantService
    {
        Task<IEnumerable<Tenant>> GetTenantsAsync();
        Tenant GetTenantById(int id);
        Task<Tenant> AddTenantAsync(Tenant tenant);
        Tenant UpdateTenant(int id, Tenant tenant);
        Task DeleteTenantAsync(int id);
    }
}
