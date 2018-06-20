using _1___SRP.v1;
using _1___SRP.v2;
using System;

namespace _1___SRP
{
    class FakeDataContext
    {
        public UserV1[] Users { get; internal set; }
        public UserV2[] UsersV2 { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Remove(UserV1 user)
        {
            throw new NotImplementedException();
        }

        internal void Save(UserV2 user)
        {
            throw new NotImplementedException();
        }

        internal void Remove(UserV2 user)
        {
            throw new NotImplementedException();
        }

        internal void Save(UserV1 user)
        {
            throw new NotImplementedException();
        }
    }
}
