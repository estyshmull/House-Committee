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
    public class BiuldingRepository:IBiuldingRepository
    {
        private readonly DataContext dataContext;
        public BiuldingRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task <IEnumerable<Biulding>> GetBuildingsAsync()
        {
            return await dataContext.BiuldingList.ToListAsync();
        }
        public Biulding GetBuildingById(int id)
        {
            return dataContext.BiuldingList.Find(id);
        }

        public async Task<Biulding> AddBuildingAsync(Biulding biulding)
        {
            dataContext.BiuldingList.Add(biulding);
            await dataContext.SaveChangesAsync();
            return biulding;
        }

        public Biulding UpdateBuilding(int id, Biulding biulding)
        {
            var updateBiulding=GetBuildingById(id);
            if (updateBiulding != null)
            {
                updateBiulding.Street = biulding.Street;
                updateBiulding.NumberStreet = biulding.NumberStreet;
                updateBiulding.City = biulding.City;
                dataContext.SaveChanges();
            }
            return updateBiulding;
        }

        public Biulding GetBuildingByStreet(int id, string street)
        {
            return GetBuildingById(id);
        }
    }
}
