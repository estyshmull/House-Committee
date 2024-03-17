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

        public Tenant AddTenant(Tenant tenant)
        {
            return tenantRepository.AddTenant(tenant);
        }

        public void DeleteTenant(int id)
        {
           tenantRepository.DeleteTenant(id);
        }

        public Tenant GetTenantById(int id)
        {
            return tenantRepository.GetTenantById(id);
        }

        public List<Tenant> GetTenants()
        {
            return tenantRepository.GetTenants();
        }

        public Tenant UpdateTenant(int id, Tenant tenant)
        {
            return tenantRepository.UpdateTenant(id, tenant);
        }
    }
}
