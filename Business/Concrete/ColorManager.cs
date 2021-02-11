﻿using Business.Abstract;
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
            return new SuccessResult();
        }

        public Result AddRange(List<Color> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult();
        }

        public Result Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public Result Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult();
        }
    }
}
