using Business.Abstract;
using Business.Contants;
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
            return new SuccessResult(Messages.Added);
        }

        public Result AddRange(List<User> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }

        public Result Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public DataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.ItemsListed);
        }
        public DataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        public Result Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}
