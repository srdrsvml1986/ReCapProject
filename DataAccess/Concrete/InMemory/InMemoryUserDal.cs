using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryUserDal : IUserDal
    {
        List<User> _user;
        public InMemoryUserDal()
        {
            _user = new List<User>
            {
                new User{ FirstName = "x1",LastName="y1",Password="1234",Email="x@y.com"},
                new User{ FirstName = "x2",LastName="y2",Password="1234",Email="x@y.com"},
            };
        }
        public void Add(User entity)
        {
            _user.Add(entity);
        }

        public void Delete(User entity)
        {
            User colorToDelete = _user.SingleOrDefault(c => c.Id == entity.Id);
            _user.Remove(colorToDelete);
        }

        public User Get(int id)
        {
            return _user.SingleOrDefault(c=> c.Id == id);
        }

        public User Get(Expression<Func<User, bool>> filter = null)
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

        public void Update(User entity)
        {
            User colorToUpdate = _user.SingleOrDefault(c => c.Id == entity.Id);
            colorToUpdate.Id = entity.Id;
            colorToUpdate.FirstName = entity.FirstName;
            colorToUpdate.LastName = entity.LastName;
            colorToUpdate.Email = entity.Email;
            colorToUpdate.Password = entity.Password;
        }
    }
}
