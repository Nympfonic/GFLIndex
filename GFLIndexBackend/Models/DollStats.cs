namespace GFLIndexBackend.Models
{
    public class DollStats
    {
        public int Id { get; set; }
        public int? Health { get; set; }
        public int? AmmoConsumption { get; set; }
        public int? RationConsumption { get; set; }
        public int? Damage { get; set; }
        public int? Evasion { get; set; }
        public int? Accuracy { get; set; }
        public int? RateOfFire { get; set; }
        public int? MoveSpeed { get; set; }
        public int? Armor { get; set; }
        public string? CriticalRate { get; set; }
        public string? CriticalDamage { get; set; }
        public int? ArmorPenetration { get; set; }
        public int DollId { get; set; }
        public virtual Doll? Doll { get; set; }
    }
}