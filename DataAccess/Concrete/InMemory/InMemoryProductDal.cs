using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;//global ifadeler altçizgiyle belirtilir.
        public InMemoryProductDal()//ctor (tab-tab) yapıcıyı kendi oluşturur.
        {
            _products = new List<Product> { 
                new Product{ProductId = 1, CategoryId= 1, ProductName = "gözlük", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductId = 2, CategoryId= 1, ProductName = "lens", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId= 2, ProductName = "bez", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ProductId = 4, CategoryId= 2, ProductName = "klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ProductId = 5, CategoryId= 2, ProductName = "fare", UnitPrice = 85, UnitsInStock = 1}
            };
        }
        public void Add(Product product)
        {
            
        }

        public void Delete(Product product)
        {
            //1-) _products.Remove(product); yazarsak çalışmaz asllaaa silmez çünkü referans numarasıyla çalışıyoruz.

            /*2-) Bu işlemi döngü olarak yapmak yerine LINQ ile yaptık.
            Product productToDelete = null;
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }
            */

            //3-) LINQ - Language Integrated Query
            //Lambda işareti =>
            Product productToDelete;
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //3.1-)her p için ProductId'si benim gönderdiğim product'ın ProductId'sine eşit mi sorgusu yapıyor.

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GettAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
