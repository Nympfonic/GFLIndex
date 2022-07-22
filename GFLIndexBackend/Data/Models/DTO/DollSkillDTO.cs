namespace GFLIndexBackend.Data.Models.DTO
{
    public class DollSkillDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? InitialCooldown { get; set; }
        public int? Cooldown { get; set; }
        public string? Description { get; set; }
    }
}