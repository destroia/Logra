using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Interfaces
{
    public interface IMoodData
    {
        Task<bool> PostMood(Mood mood);
       Task<IEnumerable<Mood>> GetMoods(Guid idUsers,string tiempo);

    }
}
