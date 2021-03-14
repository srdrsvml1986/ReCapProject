using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Autofac.Validation;
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
    public class UserClaimManager : IUserClaimService
    {
        IUserClaimDal _userDal;

        public UserClaimManager(IUserClaimDal userDal)
        {
            _userDal = userDal;
        }
        //[ValidationAspect(typeof(UserClaimValidator))]
        public IResult Add(UserClaim entity)
        {
            var result = BusinessRules.Run(CheckUserClaimCount());
            if (result!=null)
            {
                return result;
            }
            _userDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }
        //[ValidationAspect(typeof(UserClaimValidator))]
        public IResult AddRange(List<UserClaim> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(UserClaim entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<UserClaim>> GetAll(Expression<Func<UserClaim, bool>> expression = null)
        {
          return new SuccessDataResult<List<UserClaim>>(_userDal.GetAll(expression).OrderBy(x=>x.Id).ToList(), Messages.ItemsListed);
        }

        public IDataResult<UserClaim> GetById(int id)
        {
            return new SuccessDataResult<UserClaim>(_userDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        //[ValidationAspect(typeof(UserClaimValidator))]
        public IResult Update(UserClaim entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
        private IResult CheckUserClaimCount() 
        {
            return new SuccessDataResult<int>(_userDal.GetAll().Count);
        }
    }
}
