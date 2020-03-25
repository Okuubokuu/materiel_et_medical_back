﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    interface CrudRepository<T>
    {
        public IQueryable<T> Filter(T model);
        public IQueryable<T> FindAll();
        public IEnumerable<T> FindByID();
        public IQueryable<T> Remove(int id);
        public T Update(T model);
        public T Save(T model);
    }
}
