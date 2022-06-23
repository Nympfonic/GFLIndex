namespace GFLIndexBackend.Models
{
    public class DollSkill
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? InitialCooldown { get; set; }
        public int? Cooldown { get; set; }
        public string? Description { get; set; }
        public int DollId { get; set; }
        public Doll? Doll { get; set; }
    }
}