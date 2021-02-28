using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll(Expression<Func<User, bool>> expression=null);
        IDataResult<User> GetById(int id);
        IResult Update(User entity);
        IResult Add(User entity);
        IResult AddRange(List<User> entities);
        IResult Delete(User entity);
    }
}
