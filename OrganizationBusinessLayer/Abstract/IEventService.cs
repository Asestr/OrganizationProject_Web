using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationBusinessLayer.Abstract
{
    internal interface IEventService : IGenericService<Event>
    {
        List<Event> GetListEventWithOrganizer();
        List<Event> GetEventListOrganizer(int id);
        List<Event> GetListEventWithCategory();
    }
}
