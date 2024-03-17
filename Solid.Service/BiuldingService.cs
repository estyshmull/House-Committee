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

        public Biulding AddBuilding(Biulding biulding)
        {
            return biuldingRepository.AddBuilding(biulding);
        }

        public Biulding GetBuildingById(int id)
        {
            return biuldingRepository.GetBuildingById(id);
        }

        public Biulding GetBuildingByStreet(int id, string street)
        {
            return biuldingRepository.GetBuildingByStreet(id, street);
        }

        public List<Biulding> GetBuildings()
        {
            return biuldingRepository.GetBuildings();
        }

        public Biulding UpdateBuilding(int id, Biulding biulding)
        {
            return biuldingRepository.UpdateBuilding(id, biulding);
        }
    }
}
