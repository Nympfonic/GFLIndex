using GFLIndexBackend.Data;
using GFLIndexBackend.Data.Models;
using GFLIndexBackend.Data.Models.DTO;
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
                .Include(d => d.Stats)
                .Include(d => d.Tiles)
                .Include(d => d.Skills)
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
            var statsList = new List<DollStats>();
            foreach (var s in dollDto.Stats!)
            {
                var stats = new DollStats
                {
                    Id = s.Id,
                    Health = s.Health,
                    AmmoConsumption = s.AmmoConsumption,
                    RationConsumption = s.RationConsumption,
                    Damage = s.Damage,
                    Evasion = s.Evasion,
                    Accuracy = s.Accuracy,
                    RateOfFire = s.RateOfFire,
                    MoveSpeed = s.MoveSpeed,
                    Armor = s.Armor,
                    CriticalRate = s.CriticalRate,
                    CriticalDamage = s.CriticalDamage,
                    ArmorPenetration = s.ArmorPenetration
                };
                statsList.Add(stats);
            }
            var tilesList = new List<DollTiles>();
            foreach (var t in dollDto.Tiles!)
            {
                var tiles = new DollTiles
                {
                    Id = t.Id,
                    Description = t.Description,
                    TileImage = t.TileImage
                };
                tilesList.Add(tiles);
            }
            var skillList = new List<DollSkill>();
            foreach (var s in dollDto.Skills!)
            {
                var skills = new DollSkill
                {
                    Id = s.Id,
                    Name = s.Name,
                    InitialCooldown = s.InitialCooldown,
                    Cooldown = s.Cooldown,
                    Description = s.Description
                };
                skillList.Add(skills);
            }
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
                Stats = statsList,
                Tiles = tilesList,
                Skills = skillList
            };
        }
    }
}
