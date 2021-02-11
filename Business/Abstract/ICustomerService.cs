using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        DataResult<List<Customer>> GetAll();
        Result Update(Customer entity);
        Result Add(Customer entity);
        Result AddRange(List<Customer> entities);
        Result Delete(Customer entity);
    }
}
