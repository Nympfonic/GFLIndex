using GFLIndexBackend.Data.Models.DTO;

namespace GFLIndexBackend.Services
{
    public interface IGFLService
    {
        public Task<IEnumerable<DollDTO>> GetDollsAsync();
        public Task<DollDTO?> GetDollByIdAsync(int id);
        public Task UpdateDollByIdAsync(int id, DollDTO dollDto);
        public Task CreateDollAsync(DollDTO dollDto);
        public void DeleteDollAsync(DollDTO dollDto);
        public Task SaveDollChangesAsync();
        public bool DollExists(int id);
    }
}
