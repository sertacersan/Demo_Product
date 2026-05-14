using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        void Insert(Category p);
        void Delete(Category p);
        void Update(Category p);
        List<Category> GetList();
    }
}
