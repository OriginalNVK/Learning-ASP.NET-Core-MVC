using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly NZWalksDbContext _context;
        public SQLWalkRepository(NZWalksDbContext dbContext)
        {
            _context = dbContext;            
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await _context.AddAsync(walk);  
            await _context.SaveChangesAsync();
            return walk;
        }

        public async Task<Walk?> DeleteAsync(Guid id)
        {
            var existWalk = await _context.Walks.FirstOrDefaultAsync(x => x.Id == id);
            if (existWalk == null)
            {
                return null;
            }
            _context.Walks.Remove(existWalk);
            await _context.SaveChangesAsync();
            return existWalk;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await _context.Walks.Include("Difficulty").Include("Region").ToListAsync();
        }

        public async Task<Walk?> GetByIdAsync(Guid id)
        {
            return await _context.Walks.Include("Difficulty").Include("Region").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var existWalk = await _context.Walks.FirstOrDefaultAsync(x => x.Id == id);
            if (existWalk == null)
            {
                return null;
            }
            existWalk.Name = walk.Name;
            existWalk.Description = walk.Description;
            existWalk.RegionId = walk.RegionId;
            existWalk.DifficultyId = walk.DifficultyId;
            existWalk.LengthInKm = walk.LengthInKm;
            existWalk.WalkImageUrl = walk.WalkImageUrl;

            await _context.SaveChangesAsync();
            return existWalk;
        }
    }
}
