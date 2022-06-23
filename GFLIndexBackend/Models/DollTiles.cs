namespace GFLIndexBackend.Models
{
    public class DollTiles
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public byte[]? TileImage { get; set; }
        public virtual Doll? Doll { get; set; }
    }
}