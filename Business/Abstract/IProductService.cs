using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        //Business'a project referansı ekliyoruz. DataAccess ve Entities olarak. 
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);

    }
}
