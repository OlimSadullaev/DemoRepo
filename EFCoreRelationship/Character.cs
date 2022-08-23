namespace EFCoreRelationship
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string RgpClass { get; set; } = string.Empty;

        public User User { get; set; }

        public int UserId { get; set; }
    }
}
