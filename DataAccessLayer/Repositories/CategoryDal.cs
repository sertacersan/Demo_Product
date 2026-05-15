using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class CategoryDal : ICategoryDal
    {
        Context c = new Context();
        public void Delete(Category p)
        {
            c.Categories.Remove(p);
            c.SaveChanges();
        }

        public List<Category> GetList()
        {
            return c.Categories.ToList();
        }

        public void Insert(Category p)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            throw new NotImplementedException();
        }
    }
}
