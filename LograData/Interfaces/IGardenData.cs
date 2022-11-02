using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Interfaces
{
    public interface IGardenData
    {
        Task<IEnumerable<Garden>> GetGardens(Guid instutition);
    }
}
