namespace GFLIndexBackend.Data.Models
{
    public class DollType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Doll>? Dolls { get; set; }
    }
}