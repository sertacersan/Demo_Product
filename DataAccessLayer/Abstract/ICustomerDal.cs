using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal
    {
        void Insert(Customer p);
        void Delete(Customer p);
        void Update(Customer p);
        List<Customer> GetList();
    }
}
