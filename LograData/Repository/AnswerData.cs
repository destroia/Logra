using LograData.Interfaces;
using LograModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Repository
{
    public class AnswerData : IAnswerData
    {
        readonly LograDbContext DB;
        public AnswerData(LograDbContext db)
        {
            DB = db;
        }
        public async Task<IEnumerable<Answer>> GetAsnwers(Guid idUser)
        {
            return await DB.Answers.Where(x => x.IdUser == idUser)
                .OrderByDescending(x => x.Fecha).ToListAsync();
        }

        public async Task<bool> PostAnswers(List<Answer> answers)
        {
            try
            {
                answers.ForEach(x => x.Fecha = DateTime.Now);
                await DB.Answers.AddRangeAsync(answers);
                await DB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
