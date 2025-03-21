using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class SQLRegionRepository : IRegionRepository 
    {
        private readonly NZWalksDbContext _dbContext;

        public SQLRegionRepository(NZWalksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Region> CreateAsync(Region region)
        {
            await _dbContext.Regions.AddAsync(region);
            await _dbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> DeleteAsync(Guid id)
        {
            var existsRegion = await _dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if(existsRegion == null)
            {
                return null;
            }
            _dbContext.Regions.Remove(existsRegion);
            await _dbContext.SaveChangesAsync();
            return existsRegion;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await _dbContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
            var existsRegion = await _dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if( existsRegion == null)
            {
                return null;
            }
            return existsRegion;
        }

        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            var existRegion = await _dbContext.Regions.FirstOrDefaultAsync(x =>  x.Id == id);
            if( existRegion == null)
            {
                return null;
            }

            existRegion.Code = region.Code;
            existRegion.Name = region.Name;
            existRegion.RegionImageUrl = region.RegionImageUrl;

            await _dbContext.SaveChangesAsync();
            return existRegion;
        }
    }
}
