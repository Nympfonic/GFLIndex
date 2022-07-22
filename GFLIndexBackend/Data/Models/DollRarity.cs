namespace GFLIndexBackend.Data.Models
{
    public class DollRarity
    {
        public int Id { get; set; }
        public string? Rarity { get; set; }
        public ICollection<Doll>? Dolls { get; set; }
    }
}