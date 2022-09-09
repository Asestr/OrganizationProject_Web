using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
                return c.Events
                    .Include(x => x.Organizer)
                    .Include(x => x.Category).ToList();
            }
        }

        public List<Event> GetListWithCategory()
        {
            using (var c = new Context())
            {
                
                return c.Events.Include(x => x.Category).ToList();
               
            }

           
        }

        public List<Event> GetListWithCategoryByOrganizer(int id)
        {
            using (var c = new Context())
            {

                return c.Events
                    .Include(x => x.Category).Where(x=>x.OrganizerID==id)
                    .Include(x=>x.City).Where(x=>x.OrganizerID==id).ToList();

            }
        }
    }
}
