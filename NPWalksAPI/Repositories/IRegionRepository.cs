using HidaaiAPI.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace HidaaiAPI.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();
        Task<Region?> GetById(Guid id);
        Task<Region?> Create();
        Task<Region?> Update(Guid id);
        Task<Region?> Delete(Guid id);

       
    }
}
