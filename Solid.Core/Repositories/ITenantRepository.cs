using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ITenantRepository
    {
        List<Tenant> GetTenantList();
        Tenant GetTenantById(int id);
        int[] GetMonthIsNotPaid(int id, string name);
        Tenant AddTenant(Tenant tenant);
        Tenant UpdateTenant(int id,Tenant tenant);
        void Delete(int id);

    }
}
