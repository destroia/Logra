using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Interfaces
{
    public interface IUsersData
    {
        Task<IEnumerable<User>> GetUsers(Guid garden);
        Task<IEnumerable<User>> GetUsers(Guid garden,string emociones);
        Task<bool> PostUser(User user);
        Task<bool> PostUpdateUser(User user);
        Task<bool> PostDeleteUser(User user);
        Task<User> PostUpdateRegistroUser(User user);
        Task<User> PostInicioSesion(User user);

    }
}
