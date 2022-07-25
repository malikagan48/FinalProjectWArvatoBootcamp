namespace FinalProject.Entities
{
    [Serializable]
    public class BelongsToCollection 
    { 
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Poster_Path { get; set; }

        public string? BackDrop_Path { get; set; }

    }
}
