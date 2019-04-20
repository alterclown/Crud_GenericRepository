using GenericRepo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepo.DAL
{
    public class AllRepository<T> : IAllRepository<T> where T : class
    {
        private GenericsEntities _context;
        private IDbSet<T> _dbSet;

        public AllRepository()
        {
            this._context = new GenericsEntities();
            this._dbSet = _context.Set<T>();
        }

        public void deleteModel()
        {

            //T Model = _dbSet.Find(modelId);
            // _dbSet.Delete();
          
        }

        public void deleteModel(int modelId)
        {
            throw new NotImplementedException();
        }

        public void insertModel()
        {
            throw new NotImplementedException();
        }

        public void Remove(int modelId)
        {
            T model = _dbSet.Find(modelId);
            _dbSet.Remove(model);
        }

        public void updateModel()
        {
            throw new NotImplementedException();
        }

        void IAllRepository<T>.deleteModel()
        {

        }

        IEnumerable<T> IAllRepository<T>.getModel()
        {
            return _dbSet.ToList();
        }

         T IAllRepository<T>.getModelById(int modelId)
        {
           return  _dbSet.Find(modelId);
        }

        void IAllRepository<T>.insertModel(T model)
        {
            _dbSet.Add(model);
        }

        void IAllRepository<T>.save()
        {
            this._context.SaveChanges();
        }

        void IAllRepository<T>.updateModel(T model)
        {
            this._context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }
    }
}