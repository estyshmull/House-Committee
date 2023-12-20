using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newHouseCommittee.Entities;
using Solid.Core.Repositories;
using Solid.Core.Servies;

namespace Solid.Service
{
    public class MonthService:IMonthService
    {
        private readonly IMonthRepository monthRepository;
        public MonthService(IMonthRepository monthRepository)
        {
            this.monthRepository = monthRepository;
        }
        public List<Month> GetMonthes()
        {
            return monthRepository.GetMonthes();
        }
        public Month GetMonthById(int id)
        {
            return monthRepository.GetMonthById(id);
        }
    }
}
