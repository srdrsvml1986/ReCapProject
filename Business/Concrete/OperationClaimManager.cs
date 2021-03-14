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
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationClaimDal _userDal;

        public OperationClaimManager(IOperationClaimDal userDal)
        {
            _userDal = userDal;
        }
        //[ValidationAspect(typeof(OperationClaimValidator))]
        public IResult Add(OperationClaim entity)
        {
            var result = BusinessRules.Run(CheckOperationClaimCount());
            if (result!=null)
            {
                return result;
            }
            _userDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }
        //[ValidationAspect(typeof(OperationClaimValidator))]
        public IResult AddRange(List<OperationClaim> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OperationClaim entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<OperationClaim>> GetAll(Expression<Func<OperationClaim, bool>> expression = null)
        {
          return new SuccessDataResult<List<OperationClaim>>(_userDal.GetAll(expression).OrderBy(x=>x.Id).ToList(), Messages.ItemsListed);
        }

        public IDataResult<OperationClaim> GetById(int id)
        {
            return new SuccessDataResult<OperationClaim>(_userDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        //[ValidationAspect(typeof(OperationClaimValidator))]
        public IResult Update(OperationClaim entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
        private IResult CheckOperationClaimCount() 
        {
            return new SuccessDataResult<int>(_userDal.GetAll().Count);
        }
    }
}
