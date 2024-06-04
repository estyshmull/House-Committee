using Microsoft.EntityFrameworkCore;
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

        public async Task<Tenant> AddTenantAsync(Tenant tenant)
        {
            dataContext.TenantList.Add(tenant);
           await dataContext.SaveChangesAsync();
            return tenant;
        }

        public async Task DeleteTenantAsync(int id)
        {
            var user = GetTenantById(id);
            dataContext.TenantList.Remove(user);
            await dataContext.SaveChangesAsync();
        }

        public Tenant GetTenantById(int id)
        {
            return dataContext.TenantList.Find(id);
        }

        public async Task <IEnumerable<Tenant>> GetTenantsAsync()
        {
            return await dataContext.TenantList.ToListAsync();
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
