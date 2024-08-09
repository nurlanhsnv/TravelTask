using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreT.Helpers.Result.Abstract;
using EntitiesT.Concrete;
namespace BusinessT.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(int id);
       IDataResult<List<User>> GetAllUsers();
       IDataResult<User> Get(int id);
    }
}
