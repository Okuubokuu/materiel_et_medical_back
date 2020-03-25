﻿using materiel_et_medical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    public class CrudSQLRepository<T> : CrudRepository<T> where T : Model
    {
        private MaterielEtMedicalContext context = null;
        private DbSet<T> table = null;

        public CrudSQLRepository(MaterielEtMedicalContext context)
        {
            this.context = context;
            this.table = context.Set<T>();
        }

        public IQueryable<T> Filter(T model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            return this.table;
        }

        public T FindByID(int id)
        {
            return this.table.Where(model => model.Id == id).First();
        }

        public void Remove(int id)
        {
            this.context.Remove(this.FindByID(id));
            this.context.SaveChanges();
        }

        public T Save(T model)
        {
            this.context.Add(model);
            this.context.SaveChanges();
            return model;
        }

        public T Update(T model)
        {
            this.context.Add(model);
            this.context.SaveChanges();
            return model;
        }
    }
}
