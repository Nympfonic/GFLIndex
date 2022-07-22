namespace GFLIndexBackend.Data.Models
{
    public class DollMod
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public int? DollRarityId { get; set; }
        public virtual DollRarity? Rarity { get; set; }
        public int? DollTypeId { get; set; }
        public virtual DollType? Type { get; set; }
        public virtual ICollection<DollStats>? Stats { get; set; }
        public virtual ICollection<DollTiles>? Tiles { get; set; }
        public virtual ICollection<DollSkill>? Skills { get; set; }
        public int DollId { get; set; }
        public virtual Doll? Doll { get; set; }
    }
}