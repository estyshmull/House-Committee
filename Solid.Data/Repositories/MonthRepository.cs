using newHouseCommittee.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solid.Data.Repositories
{
    public class MonthRepository: IMonthRepository
    {

        private readonly DataContext dataContext;
        public MonthRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        
        public List<Month> GetMonthes()
        {
            return dataContext.months;
        }
        public Month GetMonthById(int id)
        {
            if (dataContext.months[id] == null)
                return dataContext.months.Find(m => m.Id == id);
            return null;
        }
        public List<Month> GetMonthByIdIsTake(int id, bool isTake)
        {
            if (dataContext.months[id] != null)
            {
                var a = dataContext.months.FindAll(x => x.IsTake == isTake).ToList();
                return a;
            }
            return null;
        }
        public Month AddMonth(Month month)
        {
            dataContext.months.Add(month);
            return month;
        }
        public Month UpdateMonthIfIsTake(int id,Month month)
        {
            if (dataContext.months[id] == null)
                return null;
            else
            {
                var update = dataContext.months.Find(u => u.Id == id);
                dataContext.months[id].IsTake = true;
                update.IsTake = month.IsTake;
                return update;
            }
        }
    }
}
