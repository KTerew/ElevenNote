using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElevenNote.Data.Entities
{
    public class NoteEntity
    {
        [Key]
        public int Id { get; set; } 

        [MaxLength(100,ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; } = String.Empty;

        [MaxLength(200,ErrorMessage = "Content cannot exceed 200 characters.")]
        public string Content { get; set; } = String.Empty;
        public DateTimeOffset CreatedUTC { get; set; }
        public DateTimeOffset? ModifiedUTC { get; set; }

        public string OwnerId { get; set; } = null!;

        [ForeignKey(nameof(OwnerId))]
        public virtual UserEntity Owner { get; set; } = null!;

        public int CategoryyEntityId { get; set; }

        [ForeignKey(nameof(CategoryyEntityId))]
        public virtual CategoryEntity Category { get; set; } = null!;
        
    }
}