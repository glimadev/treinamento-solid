using System.Collections.Generic;
using System.Linq;

namespace _1___SRP.v2
{
    //De preferência em um projeto a parte, fazemos as implementações das interfaces.Nesse caso, estamos usando Entity Framework:
    public class UserV2Repository : IUserV2Repository
    {
        //ORM - Entity Framework
        FakeDataContext _db = new FakeDataContext();

        public void Insert(UserV2 user)
        {
            _db.Save(user);

            _db.SaveChanges();
        }

        public List<UserV2> GetAll()
        {
            return _db.UsersV2.ToList();
        }

        public void Delete(UserV2 user)
        {
            _db.Remove(user);

            _db.SaveChanges();
        }
    }
}
