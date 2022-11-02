using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logra.Services
{
    public class MoodService
    {
        public static async Task<bool> PostMood(Mood mood)
        {
            return await GetPost.Post<bool>(Url.url + "api/Moods/Post", mood);
        }
    }
}
