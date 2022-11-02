using LograModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LograData.Interfaces
{
    public interface ILoginData
    {
        User LoginUser(Login login);
        Admin LoginAdmin(Login login);
    }
}
