namespace ElevenNote.Models.NoteModels
{
    public class NoteDetailVM
    {
        public int Id { get; set; } 

        public string Title { get; set; } = String.Empty;

        public string Content { get; set; } = String.Empty;

        public DateTimeOffset CreatedUTC { get; set; }
        
        public DateTimeOffset? ModifiedUTC { get; set; }

        public string OwnerId { get; set; } = null!;

        public string OwnerName { get; set; } = String.Empty;

        public int CategoryyEntityId { get; set; }

        public string CategoryName { get; set; } = String.Empty;
    }
}