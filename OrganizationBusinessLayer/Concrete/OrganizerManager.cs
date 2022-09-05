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
    public class OrganizerManager : IOrganizerService

    {
        IOrganizerDal _organizerDal;

        public OrganizerManager(IOrganizerDal organizerDal)
        {
            _organizerDal = organizerDal;
        }

        public void OrganizerAdd(Organizer organizer)
        {

            _organizerDal.Insert(organizer);
        }
    }
}
