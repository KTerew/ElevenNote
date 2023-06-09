namespace ElevenNote.Models.NoteModels
{
    public class NoteListItemVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedUTC { get; set; }
    }
}