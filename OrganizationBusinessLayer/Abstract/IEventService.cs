
using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationBusinessLayer.Abstract
{
    public interface IEventService
    {
        void EventAdd(Event eventAdd);
        
        void EventUpdate(Event eventUpdate);
        void EventDelete(Event eventDelete);
        List<Event> GetList();
        Event GetEventID(int id);

        List<Event> GetListEventWithOrganizer();
    }
}
