using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage, bool>> expression = null);
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
        IResult Update(IFormFile file, CarImage entity);
        IResult Add(IFormFile file,CarImage entity);
        IResult Delete(CarImage entity);
    }
}
