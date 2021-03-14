using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User entity)
        {
            var result = BusinessRules.Run(CheckUserCount());
            if (result!=null)
            {
                return result;
            }
            _userDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult AddRange(List<User> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll(Expression<Func<User, bool>> expression = null)
        {
          return new SuccessDataResult<List<User>>(_userDal.GetAll(expression).OrderBy(x=>x.Id).ToList(), Messages.ItemsListed);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
        private IResult CheckUserCount() 
        {
            return new SuccessDataResult<int>(_userDal.GetAll().Count);
        }
    }
}
