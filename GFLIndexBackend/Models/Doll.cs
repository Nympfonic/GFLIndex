using System.ComponentModel.DataAnnotations.Schema;

namespace GFLIndexBackend.Models
{
    public class Doll
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        [ForeignKey("DollStats")]
        public virtual DollStats? Stats { get; set; }
        public virtual ICollection<DollSkill>? Skills { get; set; }
        [ForeignKey("DollTiles")]
        public virtual DollTiles? Tiles { get; set; }
    }
}
