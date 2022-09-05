using OrganizationAccsessLayer.Abstract;

using OrganizationBusinessLayer.Abstract;
using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationBusinessLayer.Concrete
{
    public class EventManager : IEventService
    {
        IEventDal _eventDal;
       
        
        
            public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }

        

        public void EventAdd(Event eventAdd)
        {
            _eventDal.Insert(eventAdd);
        }

        public void EventDelete(Event eventDelete)
        {
            _eventDal.Delete(eventDelete);
        }

       

        public void EventUpdate(Event eventUpdate)
        {
            _eventDal.Update(eventUpdate);
        }

        public Event GetEventID(int id)
        {
            return _eventDal.GetByID(id);
        }

        public List<Event> GetList()
        {
            return _eventDal.GetAllList();
        }

        public List<Event> GetListEventWithOrganizer()
        {
            return _eventDal.GetListWithOrganizer();
        }
    }
}
