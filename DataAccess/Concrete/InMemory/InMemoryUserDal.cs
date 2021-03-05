using Core.DataAccess;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryUserDal : IUserDal
    {
        List<User> _user;
        public InMemoryUserDal()
        {
            _user = new List<User>
            {
                //new User{ FirstName = "x1",LastName="y1",Password="1234",Email="x@y.com"},
                //new User{ FirstName = "x2",LastName="y2",Password="1234",Email="x@y.com"},
            };
        }
        public void Add(User entity)
        {
            _user.Add(entity);
        }

        public OperationClaim Add(OperationClaim entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            User colorToDelete = _user.SingleOrDefault(c => c.Id == entity.Id);
            _user.Remove(colorToDelete);
        }

        public void Delete(OperationClaim entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Execute(FormattableString interpolatedQueryString)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            return _user.SingleOrDefault(c=> c.Id == id);
        }

        public User Get(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public OperationClaim Get(Expression<Func<OperationClaim, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _user;
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _user.ToList();
        }

        public List<OperationClaim> GetAll(Expression<Func<OperationClaim, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OperationClaim>> GetAllAsync(Expression<Func<OperationClaim, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<OperationClaim> GetAsync(Expression<Func<OperationClaim, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<OperationClaim, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public int GetCountAsync(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAsync(Expression<Func<OperationClaim, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetListAsync(Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public DbSet<User> GetTest()
        {
            throw new NotImplementedException();
        }

        public User GetTest(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TResult InTransaction<TResult>(Func<TResult> action, Action successAction = null, Action<Exception> exceptionAction = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> Query()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            User colorToUpdate = _user.SingleOrDefault(c => c.Id == entity.Id);
            colorToUpdate.Id = entity.Id;
            colorToUpdate.FirstName = entity.FirstName;
            colorToUpdate.LastName = entity.LastName;
            colorToUpdate.Email = entity.Email;
            //colorToUpdate.Password = entity.Password;
        }

        public OperationClaim Update(OperationClaim entity)
        {
            throw new NotImplementedException();
        }

        User IEntityRepository<User>.Add(User entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IEntityRepository<User>.GetCountAsync(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<User> IEntityRepository<User>.Query()
        {
            throw new NotImplementedException();
        }

        User IEntityRepository<User>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
