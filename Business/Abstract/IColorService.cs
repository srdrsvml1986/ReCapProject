using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        DataResult<List<Color>> GetAll();
        Result Update(Color entity);
        Result Add(Color entity);
        Result AddRange(List<Color> entities);
        Result Delete(Color entity);
    }
}
