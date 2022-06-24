namespace GFLIndexBackend.Models.DTO
{
    public class DollDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public virtual DollRarityDTO? Rarity { get; set; }
        public virtual DollTypeDTO? Type { get; set; }
        public virtual ICollection<DollStatsDTO>? Stats { get; set; }
        public virtual ICollection<DollTilesDTO>? Tiles { get; set; }
        public virtual ICollection<DollSkillDTO>? Skills { get; set; }
        public virtual ICollection<DollMod>? Mods { get; set; }

        public static DollDTO DollToDTO(Doll doll)
        {
            var statsListDto = new List<DollStatsDTO>();
            foreach (var s in doll.Stats!)
            {
                var statsDto = new DollStatsDTO
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
                statsListDto.Add(statsDto);
            }
            var tilesListDto = new List<DollTilesDTO>();
            foreach (var t in doll.Tiles!)
            {
                var tilesDto = new DollTilesDTO
                {
                    Id = t.Id,
                    Description = t.Description,
                    TileImage = t.TileImage
                };
                tilesListDto.Add(tilesDto);
            }
            var skillListDto = new List<DollSkillDTO>();
            foreach (var s in doll.Skills!)
            {
                var skillsDto = new DollSkillDTO
                {
                    Id = s.Id,
                    Name = s.Name,
                    InitialCooldown = s.InitialCooldown,
                    Cooldown = s.Cooldown,
                    Description = s.Description
                };
                skillListDto.Add(skillsDto);
            }
            return new()
            {
                Id = doll.Id,
                Name = doll.Name,
                Image = doll.Image,
                Rarity = doll.Rarity == null ? null : new DollRarityDTO { Id = doll.Rarity.Id, Rarity = doll.Rarity.Rarity },
                Type = doll.Type == null ? null : new DollTypeDTO { Id = doll.Type.Id, Name = doll.Type.Name },
                Stats = statsListDto,
                Tiles = tilesListDto,
                Skills = skillListDto
            };
        }
    }
}
