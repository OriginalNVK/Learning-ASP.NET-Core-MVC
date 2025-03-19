using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkRepository
    {
        public Task<Walk> CreateAsync(Walk walk);

        public Task<List<Walk>> GetAllAsync(string? FilterOn, string? FilterQuery, string? SortBy, bool? isAcending, int? pageNumber = 1, int? pageSize = 1000);

        public Task<Walk?> GetByIdAsync(Guid id);

        public Task<Walk?> UpdateAsync(Guid id, Walk walk);

        public Task<Walk?> DeleteAsync(Guid id);
    }
}
