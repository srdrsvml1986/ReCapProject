using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        DataResult<List<User>> GetAll();
        Result Update(User entity);
        Result Add(User entity);
        Result AddRange(List<User> entities);
        Result Delete(User entity);
    }
}
