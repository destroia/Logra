using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Interfaces
{
    public interface IQuestionData
    {
        Task<IEnumerable<Question>> GetQuestions(Guid user);
        Task<bool> PostUpdateQuestion(Question question);
        Task<bool> PostQuestion(Question question);
        Task<bool> PostDeleteQuestion(Question question);
    }
}
