using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        DataResult<List<Brand>> GetAll();
        Result Update(Brand brand);
        Result Add(Brand brand);
        Result AddRange(List<Brand> entities);
        Result Delete(Brand brand);
    }
}
