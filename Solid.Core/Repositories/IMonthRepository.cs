using newHouseCommittee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IMonthRepository
    {
        List<Month> GetMonthes();
        Month GetMonthById(int id);
        List<Month> GetMonthByIdIsTake(int id, bool isTake);
        Month AddMonth(Month month);
        Month UpdateMonthIfIsTake(int id);
    }
}
