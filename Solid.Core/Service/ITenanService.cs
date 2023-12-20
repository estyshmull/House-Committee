using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface ITenanService
    {
        List<Tenant> GetTenantList();
        Tenant GetTenantById(int id);
    }
}
