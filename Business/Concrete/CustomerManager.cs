using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal colorDal)
        {
            _customerDal = colorDal;
        }

        public Result Add(Customer entity)
        {
            _customerDal.Add(entity);
            return new SuccessResult();
        }

        public Result AddRange(List<Customer> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult();
        }

        public Result Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public Result Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult();
        }
    }
}
