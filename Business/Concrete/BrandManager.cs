using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            return _brandDal.Get(filter);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
