using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servies
{
    public interface IBiuldingService
    {
        List<Biulding> GetBuildings();
        Biulding GetBuildingById(int id);
        Biulding GetBuildingByStreet(int id, string street);
        Biulding AddBuilding(Biulding biulding);
        Biulding UpdateBuilding(int id, Biulding biulding);
    }
}
