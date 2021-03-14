using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserClaimService
    {
        IDataResult<List<UserClaim>> GetAll(Expression<Func<UserClaim, bool>> expression=null);
        IDataResult<UserClaim> GetById(int id);
        IResult Update(UserClaim entity);
        IResult Add(UserClaim entity);
        IResult AddRange(List<UserClaim> entities);
        IResult Delete(UserClaim entity);
    }
}
