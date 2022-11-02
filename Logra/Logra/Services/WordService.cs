using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logra.Services
{
    public class WordService
    {
        public static async Task<List<Word>> GetWord()
        {
            return await GetPost.Get<List<Word>>(Url.url + "api/Words/Get");
        }
    }
}
