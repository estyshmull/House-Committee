using newHouseCommittee.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Core.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class BiuldingService:IBiuldingService
    {
        private readonly IBiuldingRepository biuldingRepository;
        public BiuldingService(IBiuldingRepository repository)
        {
           this.biuldingRepository = repository;
        }

        public async Task<Biulding> AddBuildingAsync(Biulding biulding)
        {
            return await biuldingRepository.AddBuildingAsync(biulding);
        }

        public Biulding GetBuildingById(int id)
        {
            return biuldingRepository.GetBuildingById(id);
        }

        public Biulding GetBuildingByStreet(int id, string street)
        {
            return biuldingRepository.GetBuildingByStreet(id, street);
        }

        public async Task<IEnumerable<Biulding>> GetBuildingsAsync()
        {
            return await biuldingRepository.GetBuildingsAsync();
        }

        public Biulding UpdateBuilding(int id, Biulding biulding)
        {
            return biuldingRepository.UpdateBuilding(id, biulding);
        }
    }
}
