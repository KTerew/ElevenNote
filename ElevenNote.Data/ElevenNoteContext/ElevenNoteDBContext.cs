using ElevenNote.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Data.ElevenNoteContext
{
    public class ElevenNoteDBContext : IdentityDbContext<UserEntity>
    {
        public ElevenNoteDBContext(DbContextOptions options) :base(options) { }

        public DbSet<NoteEntity> Notes { get; set; }
        public DbSet<CategoryEntity> Catergory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CategoryEntity>().HasData(
                new CategoryEntity
                {
                    Id = 1,
                    Name = "Happy People"
                },
                new CategoryEntity
                {
                    Id = 2,
                    Name = "Sad People"
                },
                new CategoryEntity
                {
                    Id = 3,
                    Name = "Music"
                },
                new CategoryEntity
                {
                    Id = 4,
                    Name = "Art"
                },
                new CategoryEntity
                {
                    Id = 5,
                    Name = "Video Games"
                }
            );
        }
    }
}