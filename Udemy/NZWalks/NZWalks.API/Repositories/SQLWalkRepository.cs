using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using System.Linq;

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

        public async Task<List<Walk>> GetAllAsync(string? FilterOn, string? FilterQuery, string? SortBy, bool? isAcending
            , int? pageNumber = 1, int? pageSize = 1000)
        {
            //return await _context.Walks.Include("Difficulty").Include("Region").ToListAsync();
            var walks = _context.Walks.Include("Difficulty").Include("Region").AsQueryable();

            if(!string.IsNullOrWhiteSpace(FilterOn) && !string.IsNullOrWhiteSpace(FilterQuery))
            {
                if(FilterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = walks.Where(x => x.Name.Contains(FilterQuery));
                }
            }

            // Sorting
            if (!string.IsNullOrWhiteSpace(SortBy))
            {
                bool isAscendingOrder = isAcending ?? false;
                if (SortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = isAscendingOrder ? walks.OrderBy(x => x.Name) : walks.OrderByDescending(x => x.Name);
                }
                else if(SortBy.Equals("Length", StringComparison.OrdinalIgnoreCase))
                {
                    walks = isAscendingOrder ? walks.OrderBy(x => x.LengthInKm) : walks.OrderByDescending(x => x.LengthInKm);
                }
            }

            // Pagination
            int currentPage = pageNumber ?? 1;
            int size = pageSize ?? 1000;
            int SkipSize = (currentPage - 1) * size;

            return await walks.Skip(SkipSize).Take(size).ToListAsync();

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
