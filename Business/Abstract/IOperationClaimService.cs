using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        IDataResult<List<OperationClaim>> GetAll(Expression<Func<OperationClaim, bool>> expression=null);
        IDataResult<OperationClaim> GetById(int id);
        IResult Update(OperationClaim entity);
        IResult Add(OperationClaim entity);
        IResult AddRange(List<OperationClaim> entities);
        IResult Delete(OperationClaim entity);
    }
}
