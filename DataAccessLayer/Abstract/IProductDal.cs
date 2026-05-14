using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal
    {
        void Insert(Product p);
        void Delete(Product p);
        void Update(Product p);
        List<Product> GetList();
    }
}
