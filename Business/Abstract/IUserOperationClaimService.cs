using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IDataResult<List<UserOperationClaim>> GetAll(Expression<Func<UserOperationClaim, bool>> expression=null);
        IDataResult<UserOperationClaim> GetById(int id);
        IResult Update(UserOperationClaim entity);
        IResult Add(UserOperationClaim entity);
        IResult AddRange(List<UserOperationClaim> entities);
        IResult Delete(UserOperationClaim entity);
    }
}
