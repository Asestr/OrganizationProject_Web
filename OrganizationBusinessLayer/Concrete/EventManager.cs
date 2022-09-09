using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
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

        public Event GetByID(int id)
        {
            return _eventDal.GetByID(id);
        }

        public List<Event> GetEventListOrganizer(int id)
        {
            return _eventDal.GetListAll(x => x.OrganizerID == id);
        }
        public List<Event> GetEventListCategoryByOrganizer(int id)
        {
            return _eventDal.GetListWithCategoryByOrganizer(id);
        }
        public List<Event> GetList()
        {
            return _eventDal.GetListAll();
        }

        public List<Event> GetListEventWithOrganizer()
        {
            return _eventDal.GetListWithOrganizer();
        }

        public List<Event> GetListEventWithCategory()
        {
            return _eventDal.GetListWithCategory();
        }

        public void TAdd(Event t)
        {
            _eventDal.Insert(t);
        }

        public void TDelete(Event t)
        {
            _eventDal.Delete(t);
        }

        public void TUpdate(Event t)
        {
            _eventDal.Update(t);
        }

       
    }
}
