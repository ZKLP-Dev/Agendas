namespace Agendas.Models
{
    public class Professional
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Role { get; set; }
        public required string Rating { get; set; }
        public required string Avatar { get; set; }
    }
}
