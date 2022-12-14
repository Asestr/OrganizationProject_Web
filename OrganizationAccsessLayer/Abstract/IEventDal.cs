using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationAccsessLayer.Abstract
{
    public interface IEventDal:IGenericDal<Event>
    {
        List<Event> GetListWithOrganizer();
        List<Event> GetListWithCategory();
        List<Event> GetListWithCategoryByOrganizer(int id);


    }
}
