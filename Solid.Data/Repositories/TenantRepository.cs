using newHouseCommittee.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    internal class TenantRepository : ITenantRepository
    {
        private readonly DataContext dataContext;
        public TenantRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public List<Tenant> GetTenantList()
        {
            return dataContext.tenantList;
        }
        public Tenant GetTenantById(int id)
        {
            if (dataContext.tenantList[id] != null)
                return dataContext.tenantList[id];
            return null;
        }
        public int[] GetMonthIsNotPaid(int id, string name)
        {
            if (dataContext.tenantList[id] == null)
                return null;
            int[] arr = new int[12], a2;
            int k = 0;
            for (int i = 0; i < dataContext.tenantList[id].IsPaid.Count; i++)
            {
                if (!dataContext.tenantList[id].IsPaid[i])
                    arr[k++] = i + 1;
            }
            a2 = new int[k];
            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = arr[i];
            }
            return a2;
        }
        public Tenant AddTenant(Tenant tenant)
        {
            dataContext.tenantList.Add(tenant);
            return tenant;
        }
        public Tenant UpdateTenant(int id, Tenant tenant)
        {
            if (dataContext.tenantList[id] == null)
                return null;
            else
            {
                var update = dataContext.tenantList.Find(u => u.Id == id);

                update.IsPaid = tenant.IsPaid;
                return update;
            }

        }
        public void Delete(int id)
        {
            if (dataContext.tenantList[id] != null)
            {
                dataContext.tenantList.Remove(dataContext.tenantList[id]);
            }
        }
    }
}
