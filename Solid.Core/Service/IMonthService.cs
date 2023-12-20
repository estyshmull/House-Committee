using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servies
{
    public interface IMonthService
    {
        List<Month> GetMonthes();
        Month GetMonthById(int id);
    }
}
