using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint - generic sınırlama. class yazdığımız yer referans tipli olarak sınırlamış olduk.
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    public interface IEntityRepository<T> where T:class //böylece int falan yazamaz
    {
        
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GettAllByCategory(int categoryId);
    }
}
