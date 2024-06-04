using newHouseCommittee.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Core.Servies;

namespace Solid.Service
{
    public class TenantService :ITenantService
    {
        private readonly ITenantRepository tenantRepository;
        public TenantService(ITenantRepository repository)
        {
            tenantRepository = repository;
        }

        public async Task<Tenant> AddTenant(Tenant tenant)
        {
            return await tenantRepository.AddTenantAsync(tenant);
        }

        public Task<Tenant> AddTenantAsync(Tenant tenant)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTenantAsync(int id)
        {
             await tenantRepository.DeleteTenantAsync(id);
        }

        public Tenant GetTenantById(int id)
        {
            return tenantRepository.GetTenantById(id);
        }

        public async Task<IEnumerable<Tenant>> GetTenantsAsync()
        {
            return await tenantRepository.GetTenantsAsync();
        }

        public Tenant UpdateTenant(int id, Tenant tenant)
        {
            return tenantRepository.UpdateTenant(id, tenant);
        }
    }
}
