using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
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
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _userDal;

        public UserOperationClaimManager(IUserOperationClaimDal userDal)
        {
            _userDal = userDal;
        }
        //[ValidationAspect(typeof(UserOperationClaimValidator))]
        public IResult Add(UserOperationClaim entity)
        {
            var result = BusinessRules.Run(CheckUserOperationClaimCount());
            if (result!=null)
            {
                return result;
            }
            _userDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }
        //[ValidationAspect(typeof(UserOperationClaimValidator))]
        public IResult AddRange(List<UserOperationClaim> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(UserOperationClaim entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<UserOperationClaim>> GetAll(Expression<Func<UserOperationClaim, bool>> expression = null)
        {
          return new SuccessDataResult<List<UserOperationClaim>>(_userDal.GetAll(expression).OrderBy(x=>x.Id).ToList(), Messages.ItemsListed);
        }

        public IDataResult<UserOperationClaim> GetById(int id)
        {
            return new SuccessDataResult<UserOperationClaim>(_userDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        //[ValidationAspect(typeof(UserOperationClaimValidator))]
        public IResult Update(UserOperationClaim entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
        private IResult CheckUserOperationClaimCount() 
        {
            return new SuccessDataResult<int>(_userDal.GetAll().Count);
        }
    }
}
