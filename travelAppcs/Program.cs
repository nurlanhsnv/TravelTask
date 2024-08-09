using BusinessT.Concrete;
using DataAccessT.Concrete;
using EntitiesT.Concrete;
UserManager userManager = new(new UserDal());

User user = new() { ID=1 ,Username="nurufalan", Destination="baku", Email="njjnjdn.gmail.com", IsDelete=false};
userManager.Add(user);

