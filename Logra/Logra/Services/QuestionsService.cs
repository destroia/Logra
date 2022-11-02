using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logra.Services
{
    public class QuestionsService
    {
        public static async Task<List<Question>> GetQuestions(Guid idUser)
        {
            return await GetPost.Get<List<Question>>(Url.url + "api/Questions/Get/" + idUser);
        }
    }
}
