using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models.LuoKiPetModels;

namespace LuoKiPetDAL
{
    public class BaseDal<T> where T : class, new()
    {
        private DbContext db;
        public BaseDal(LuoKiPetContext dbContext)
        {
            db = dbContext;
        }
        public IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where<T>(whereLambda);
        }
        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount, System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            var temp = db.Set<T>().Where<T>(whereLambda);
            totalCount = temp.Count();
            if (isAsc)
            {
                temp = temp.OrderBy<T, s>(orderbyLambda).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            else
            {
                temp = temp.OrderByDescending<T, s>(orderbyLambda).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            return temp;
        }
        public IQueryable<T> LoadEntitiesField(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, Expression<Func<T, T>> scalar)
        {
            if (whereLambda == null)
            {
                return db.Set<T>().Select(scalar);
            }
            else
            {
                return db.Set<T>().Where(whereLambda).ToList().AsQueryable().Select(scalar);
            }
        }
        public bool DeleteEntity(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Deleted;
            //return db.SaveChanges() > 0;
            return true;
        }
        public bool EditEntity(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            //return db.SaveChanges() > 0;
            return true;
        }
        public T AddEntity(T entity)
        {
            db.Set<T>().Add(entity);
            //db.SaveChanges();
            return entity;
        }
        public List<T> Pagination<TKey>(int PageIndex, int PageSize, out int TotalCount, Expression<Func<T, TKey>> OrderBy, Expression<Func<T, bool>> WhereLambda = null, bool IsOrder = true)
        {
            //分页的时候一定要注意 Order一定在Skip 之前
            IQueryable<T> QueryList = IsOrder == true ? db.Set<T>().OrderBy(OrderBy) : db.Set<T>().OrderByDescending(OrderBy);
            if (WhereLambda != null)
            {
                QueryList = QueryList.Where(WhereLambda);
            }
            TotalCount = QueryList.Count();
            return QueryList.Skip(PageSize * (PageIndex - 1)).Take(PageSize).ToList() ?? null;
        }

        public bool SaveChanges()
        {
            return db.SaveChanges() > 0;
        }
    }
}
