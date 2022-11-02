using LograData.Interfaces;
using LograModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Repository
{
    public class GardenData : IGardenData
    {
        readonly LograDbContext DB;
        public GardenData(LograDbContext db)
        {
            DB = db;
        }
        public async Task<IEnumerable<Garden>> GetGardens(Guid instutition)
        {
            return await DB.Gardens.ToListAsync();
        }
    }
}
