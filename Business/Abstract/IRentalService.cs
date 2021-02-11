using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        DataResult<List<Rental>> GetAll();
        Result Update(Rental entity);
        Result Add(Rental entity);
        Result AddRange(List<Rental> entities);
        Result Delete(Rental entity);
    }
}
