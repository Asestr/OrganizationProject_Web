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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public City GetByID(int id)
        {
            return _cityDal.GetByID(id);
        }

        public List<City> GetList()
        {
            return _cityDal.GetListAll();
        }

        public void TAdd(City t)
        {
            _cityDal.Insert(t);
        }

        public void TDelete(City t)
        {
            _cityDal.Delete(t);
        }

        public void TUpdate(City t)
        {
            _cityDal.Update(t);
        }
    }
}
