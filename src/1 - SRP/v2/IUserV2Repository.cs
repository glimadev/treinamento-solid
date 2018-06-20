using System.Collections.Generic;

namespace _1___SRP.v2
{
    //Desacoplar com o uso de interfaces nas rotinas de persistência. Uma sugestão para tal seria usar o Repository Pattern.
    public interface IUserV2Repository
    {
        void Insert(UserV2 user);
        List<UserV2> GetAll();
        void Delete(UserV2 user);
    }
}
