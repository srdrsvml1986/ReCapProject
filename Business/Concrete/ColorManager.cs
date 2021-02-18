using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Result Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public Result AddRange(List<Color> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }

        public Result Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public DataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ItemsListed);
        }
        public DataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        public Result Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}
