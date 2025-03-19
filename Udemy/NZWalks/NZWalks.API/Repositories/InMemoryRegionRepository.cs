using System.Collections.Generic;

using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class InMemoryRegionRepository : IRegionRepository
    {
        public Task<Region> CreateAsync(Region region)
        {
            throw new NotImplementedException();
        }

        public Task<Region?> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Region>> GetAllAsync()
        {
            return Task.FromResult(new List<Region>
            {
                new Region()
                {
                    Id = Guid.NewGuid(),
                    Code = "New region",
                    Name = "SaiGon"
                }
            });
        }

        public Task<Region?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Region?> UpdateAsync(Guid id, Region region)
        {
            throw new NotImplementedException();
        }
    }
}
