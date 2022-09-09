﻿using OrganizationEntityLayer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationBusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);

        void TUpdate(T t);
        void TDelete(T t);
        List<T> GetList();
        T GetByID(int id);

       


    }
}