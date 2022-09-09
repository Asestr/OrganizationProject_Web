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
    public class OrganizerManager : IGenericService<Organizer>

    {
        IOrganizerDal _organizerDal;

        public OrganizerManager(IOrganizerDal organizerDal)
        {
            _organizerDal = organizerDal;
        }

        public Organizer GetByID(int id)
        {
            throw new NotImplementedException();
        }

       

        public List<Organizer> GetList()
        {
            throw new NotImplementedException();
        }

        

        public void TAdd(Organizer t)
        {
            _organizerDal.Insert(t);
        }

        public void TDelete(Organizer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Organizer t)
        {
            throw new NotImplementedException();
        }
    }
}
