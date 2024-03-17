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
        List<Tenant> GetTenants();
        Tenant GetTenantById(int id);
        Tenant AddTenant(Tenant tenant);
        Tenant UpdateTenant(int id, Tenant tenant);
        void DeleteTenant(int id);
    }
}
