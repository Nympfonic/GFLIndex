using GFLIndexBackend.Models;
using GFLIndexBackend.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace GFLIndexBackend.Services
{
    public class GFLService : IGFLService
    {
        private readonly GFLContext _context;

        public GFLService(GFLContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DollDTO>> GetDollsAsync()
        {
            return await _context.Dolls
                .Include(d => d.Rarity)
                .Include(d => d.Type)
                .Select(d => DollDTO.DollToDTO(d))
                .ToListAsync();
        }

        public async Task<DollDTO?> GetDollByIdAsync(int id)
        {
            var doll = await _context.Dolls.FindAsync(id);
            if (doll == null)
                return null;

            return DollDTO.DollToDTO(doll);
        }

        public async Task UpdateDollByIdAsync(int id, DollDTO dollDto)
        {
            var doll = await _context.Dolls.FindAsync(id);

            if (doll == null)
                return;

            doll.Name = dollDto.Name ?? doll.Name;
            doll.Image = dollDto.Image ?? doll.Image;
            doll.Rarity = await _context.DollRarities
                .Where(drarity => drarity.Rarity == dollDto.Rarity!.Rarity)
                .FirstOrDefaultAsync() ?? doll.Rarity;
            doll.DollRarityId = dollDto.Rarity!.Id;
            doll.Type = await _context.DollTypes
                .Where(dtype => dtype.Name == dollDto.Type!.Name)
                .FirstOrDefaultAsync() ?? doll.Type;
            doll.DollTypeId = dollDto.Type!.Id;
            doll.Stats = dollDto.Stats as ICollection<DollStats> ?? doll.Stats;
            doll.Tiles = dollDto.Tiles as ICollection<DollTiles> ?? doll.Tiles;
            doll.Skills = dollDto.Skills as ICollection<DollSkill> ?? doll.Skills;
        }

        public async Task CreateDollAsync(DollDTO dollDto)
        {
            var doll = await DTOToDoll(dollDto);
            _context.Dolls.Add(doll);
        }

        public async void DeleteDollAsync(DollDTO dollDto)
        {
            var doll = await DTOToDoll(dollDto);
            _context.Dolls.Remove(doll);
        }

        public async Task SaveDollChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public bool DollExists(int id)
        {
            return (_context.Dolls?.Any(d => d.Id == id)).GetValueOrDefault();
        }

        private async Task<Doll> DTOToDoll(DollDTO dollDto)
        {
            return new Doll
            {
                Id = dollDto.Id,
                Name = dollDto.Name,
                Image = dollDto.Image,
                Rarity = await _context.DollRarities
                    .Where(drarity => drarity.Rarity == dollDto.Rarity!.Rarity)
                    .FirstOrDefaultAsync(),
                DollRarityId = dollDto.Rarity!.Id,
                Type = await _context.DollTypes
                    .Where(dtype => dtype.Name == dollDto.Type!.Name)
                    .FirstOrDefaultAsync(),
                DollTypeId = dollDto.Type!.Id,
                Stats = dollDto.Stats as ICollection<DollStats>,
                Tiles = dollDto.Tiles as ICollection<DollTiles>,
                Skills = dollDto.Skills as ICollection<DollSkill>
            };
        }
    }
}
