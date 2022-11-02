using LograData.Interfaces;
using LograModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Repository
{
    public class InstutitionData : IInstutitionData
    {
        readonly LograDbContext DB;
        public InstutitionData(LograDbContext db)
        {
            DB = db;
        }
        public async Task<IEnumerable<Instutition>> GetInstutition()
        {
            return await DB.Instutitions.ToListAsync();
        }
    }
}
