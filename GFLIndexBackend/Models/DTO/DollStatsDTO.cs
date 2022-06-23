namespace GFLIndexBackend.Models.DTO
{
    public class DollStatsDTO
    {
        public int Id { get; set; }
        public int? BaseHealth { get; set; }
        public int? BaseAmmoConsumption { get; set; }
        public int? BaseRationConsumption { get; set; }
        public int? BaseDamage { get; set; }
        public int? BaseEvasion { get; set; }
        public int? BaseAccuracy { get; set; }
        public int? BaseRateOfFire { get; set; }
        public int? MoveSpeed { get; set; }
        public int? Armor { get; set; }
        public string? CriticalRate { get; set; }
        public string? CriticalDamage { get; set; }
        public int? ArmorPenetration { get; set; }
    }
}