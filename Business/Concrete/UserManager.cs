using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal colorDal)
        {
            _userDal = colorDal;
        }

        public Result Add(User entity)
        {
            _userDal.Add(entity);
            return new SuccessResult();
        }

        public Result AddRange(List<User> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult();
        }

        public Result Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public Result Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult();
        }
    }
}
