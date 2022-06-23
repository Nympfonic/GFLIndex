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
            return new()
            {
                Id = doll.Id,
                Name = doll.Name,
                Image = doll.Image,
                Rarity = doll.Rarity == null ? null : new DollRarityDTO { Id = doll.Rarity.Id, Rarity = doll.Rarity.Rarity },
                Type = doll.Type == null ? null : new DollTypeDTO { Id = doll.Type.Id, Name = doll.Type.Name },
                Stats = doll.Stats as ICollection<DollStatsDTO>,
                Tiles = doll.Tiles as ICollection<DollTilesDTO>,
                Skills = doll.Skills as ICollection<DollSkillDTO>
            };
        }
    }
}
