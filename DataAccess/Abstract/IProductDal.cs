using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        
        
        
        
        
        //(GEÇMİŞ KOD-DEĞİŞİTRDİK)1-)interface in kendisi default public değil operasyonları yani metotları publictir. 
        //add reference to entities yapmalıyız
        //2-)Manuel yapmak için DataAccess e sağ tıkla add>project reference diyip entities'i seçmeliyiz.
        //Sonra hatalı yere gelip ampüle tıklayıp add "using Entities.Concrete" kullanılmalı.
        /*
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GettAllByCategory(int categoryId);
        */
    }
}
