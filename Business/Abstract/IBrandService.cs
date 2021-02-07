﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        void Update(Brand brand);
        void Add(Brand brand);
        void Delete(Brand brand);
    }
}
