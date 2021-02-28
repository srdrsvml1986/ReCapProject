using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> expression = null);
        IDataResult<Customer> GetById(int id);
        IResult Update(Customer entity);
        IResult Add(Customer entity);
        IResult AddRange(List<Customer> entities);
        IResult Delete(Customer entity);
    }
}
