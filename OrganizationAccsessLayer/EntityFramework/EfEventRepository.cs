using Microsoft.EntityFrameworkCore;
using OrganizationAccsessLayer.Abstract;
using OrganizationAccsessLayer.Concrete;
using OrganizationAccsessLayer.Repositories;
using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationAccsessLayer.EntityFramework
{
    public class EfEventRepository : GenericRepository<Event>, IEventDal
    {
        public List<Event> GetListWithOrganizer()
        {
            using (var c = new Context())
            {
                return c.Events.Include(x=>x.OrganEvents).ToList();
            }
        }
    }
}
