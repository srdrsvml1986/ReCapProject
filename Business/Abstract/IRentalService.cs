using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll(Expression<Func<Rental, bool>> expression = null);
        IDataResult<Rental> GetById(int id);
        IResult Update(Rental entity);
        IResult Add(Rental entity);
        IResult AddRange(List<Rental> entities);
        IResult Delete(Rental entity);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
