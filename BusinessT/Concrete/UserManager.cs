using BusinessT.Abstract;
using BusinessT.Validation.FluentValidation;
using CoreT.Aspect.autofac.Validation.FluentValidation;
using CoreT.Helpers.Result.Abstract;
using CoreT.Helpers.Result.Concrete;
using DataAccessT.Abstract;
using EntitiesT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessT.Concrete
{
    public class UserManager(IUserDal userDal) : IUserService
    {    private readonly IUserDal _userDal= userDal ;
        [ValidationAspect<User>(typeof(UserValidator))]
        public IResult Add(User user)
        {
             
                _userDal.Add(user);

                return new SuccessResult();
            
            

        }

        public IResult Delete(int id)
        {
            /* User deleteUser = _userDal.GetAll().SingleOrDefault(p=> p.ID==user.ID);
             if (deleteUser != null) {
                 deleteUser.IsDelete = true; }*/
            User deleteUser = null;
            User resultUser = _userDal.Get(p=>p.IsDelete==false && p.ID==id);
            if (resultUser!=null)
            {
                deleteUser = resultUser;
            }
            deleteUser.IsDelete = true;
            _userDal.Delete(deleteUser);
            return new SuccessResult();
        }

        public IDataResult <List<User>> GetAllUsers()
        {
            var users  =    _userDal.GetAll(p => p.IsDelete==false) ;
            if (users.Count >0)
            {
                return new SuccessDataResult<List<User>>(users, "succces");
            }
            else
                return new ErrorDataResult<List<User>>(users, "errror");
        }

        public  IDataResult<User> Get(int id)
        {
            var users = _userDal.Get(p => p.ID == id);
            if (users != null)
                return new SuccessDataResult<User>(users,"suces");
            else return new ErrorDataResult<User>(users, "errrrroe");
        }   

        public IResult Update(User user)
        {
            User updateUser;
           updateUser = _userDal.Get(p=> p.ID== user.ID && p.IsDelete==false );
            if (updateUser != null)
            {
                updateUser.Username = user.Username;
                updateUser.Destination = user.Destination;
               updateUser.Email = user.Email; 
                updateUser.IsDelete = user.IsDelete;
                _userDal.Update(user);
            return new SuccessResult("update olundu");
            }
            return new ErrorResult("not found falan");
        }

    }
}
