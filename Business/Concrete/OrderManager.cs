using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    internal class OrderManager : IOrderService
    {
        public IResult Add(Order product)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Order product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Order product)
        {
            throw new NotImplementedException();
        }
    }
}
