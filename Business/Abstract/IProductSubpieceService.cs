﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductSubpieceService
    {
        IDataResult<List<ProductSubpiece>> GetAll();
        IDataResult<List<ProductSubpiece>> GetByProductId(int productId);
        IResult Add(int[] subpieceId);
    }
}
