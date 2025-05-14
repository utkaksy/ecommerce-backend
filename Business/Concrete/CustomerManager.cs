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
    public class CustomerManager : ICustomerService
    {
        public IResult Add(Customer product)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Customer product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer product)
        {
            throw new NotImplementedException();
        }
    }
}
