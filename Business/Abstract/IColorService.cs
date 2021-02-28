using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> expression = null);
        IDataResult<Color> GetById(int id);
        IResult Update(Color entity);
        IResult Add(Color entity);
        IResult AddRange(List<Color> entities);
        IResult Delete(Color entity);
    }
}
