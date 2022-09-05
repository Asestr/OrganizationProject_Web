using OrganizationAccsessLayer.Abstract;
using OrganizationAccsessLayer.Repositories;
using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationAccsessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
    }
}
