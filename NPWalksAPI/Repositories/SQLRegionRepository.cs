using HidaaiAPI.Data;
using HidaaiAPI.Models.Domain;
using HidaaiAPI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace HidaaiAPI.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly HidaaiDbContext dbContext;

        public SQLRegionRepository(HidaaiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Region>> GetAllAsync()
        {
           return await dbContext.Regions.ToListAsync();
        }
       
        public async Task<Region?> GetByIdAsync(Guid id)
        {
            return await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Region> CreateAsync(Region region)
        {
            await dbContext.Regions.AddAsync(region);
             await dbContext.SaveChangesAsync();
            return region;
        }

        public Task<Region> Delete(Guid id)
        {
            throw new NotImplementedException();
        }


        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            var existingRegion = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if (existingRegion == null)
            {
                return null;
            }
            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.RegionImageUrl = region.RegionImageUrl;

            return region;

        }
    }
}
