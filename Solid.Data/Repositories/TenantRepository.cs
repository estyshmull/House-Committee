using newHouseCommittee.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly DataContext dataContext;
        public TenantRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Tenant AddTenant(Tenant tenant)
        {
            dataContext.TenantList.Add(tenant);
            dataContext.SaveChanges();
            return tenant;
        }

        public void DeleteTenant(int id)
        {
            var user = GetTenantById(id);
            dataContext.TenantList.Remove(user);
            dataContext.SaveChanges();
        }

        public Tenant GetTenantById(int id)
        {
            return dataContext.TenantList.Find(id);
        }

        public List<Tenant> GetTenants()
        {
            return dataContext.TenantList.ToList();
        }

        public Tenant UpdateTenant(int id, Tenant tenant)
        {
            var updateTenant = GetTenantById(id);
            if (updateTenant != null)
            {
                updateTenant.Name=tenant.Name;
                updateTenant.Phone=tenant.Phone;    
                dataContext.SaveChanges();
            }
            return updateTenant;
        }
    }
}
