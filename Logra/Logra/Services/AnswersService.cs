using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logra.Services
{
    public class AnswersService
    {
        public static async Task<bool> PostAnswes(List<Answer> answers)
        {
            return await GetPost.Post<bool>(Url.url + "api/Answers/Post", answers);
        }
    }
}
