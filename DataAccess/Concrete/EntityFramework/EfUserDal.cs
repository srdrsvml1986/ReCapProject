using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarContext>, IUserDal
    {
      
    }
}
