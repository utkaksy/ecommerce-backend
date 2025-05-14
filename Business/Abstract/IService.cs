using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IService<T> where T : class, IEntity,new ()
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int productId);
        IResult Add(T product);
        IResult Update(T product);
        IResult Delete(T product);
    }
}
