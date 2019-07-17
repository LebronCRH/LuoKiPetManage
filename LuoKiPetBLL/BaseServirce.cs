using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public abstract class BaseServirce<T> where T : class, new()
    {
        private LuoKiPetIDAL.IBaseDal<T> CurrentDal;
        public BaseServirce(IBaseDal<T> currentDal)
        {
            CurrentDal = currentDal;
        }
        public IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.LoadEntities(whereLambda);
        }
        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount, System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            return CurrentDal.LoadPageEntities<s>(pageIndex, pageSize, out totalCount, whereLambda, orderbyLambda, isAsc);
        }
        public IQueryable<T> LoadEntitiesField(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, Expression<Func<T, T>> scalar)
        {
            return CurrentDal.LoadEntitiesField(whereLambda, scalar);
        }
        public bool DeleteEntity(T entity)
        {
            CurrentDal.DeleteEntity(entity);
            return SaveChanges();
        }
        public bool EditEntity(T entity)
        {
            CurrentDal.EditEntity(entity);
            return SaveChanges();
        }
        public T AddEntity(T entity)
        {
            CurrentDal.AddEntity(entity);
            SaveChanges();
            return entity;
        }
        public bool SaveChanges()
        {
            return CurrentDal.SaveChanges();
        }
    }
}
