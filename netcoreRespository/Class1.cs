using netcoreCommon;
using System;

namespace netcoreRespository
{
    public class Class1
    {
        public string Get()
        {
            return GetUser.GetU<IUser>().GetUser();
        }
    }
}
