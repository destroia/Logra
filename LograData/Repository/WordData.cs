using LograData.Interfaces;
using LograModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Repository
{
    public class WordData : IWordData
    {
        readonly LograDbContext DB;
        public WordData(LograDbContext db)
        {
            DB = db;
        }
        public async Task<IEnumerable<Word>> GetWords()
        {
            try
            {
                return await DB.Words.ToListAsync();
            }
            catch (Exception ex )
            {

                return null; ;
            }
           
        }
    }
}
