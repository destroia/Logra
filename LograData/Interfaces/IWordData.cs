using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Interfaces
{
    public interface IWordData
    {
        Task<IEnumerable<Word>> GetWords();
    }
}
