using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Interfaces
{
    public interface IAnswerData
    {
        Task<IEnumerable<Answer>> GetAsnwers(Guid idUser);
        Task<bool> PostAnswers(List<Answer> answers);
    }
}
