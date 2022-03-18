using Fengsao.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Fengsao.Application
{
    public class FengsaoContext : DbContext
    {
        public DbSet<Author> Authors { get; set; } = null!;

        public DbSet<Book> Books { get; set; } = null!;

        public DbSet<Dynasty> Dynastys { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        public DbSet<Paragraphic> Paragraphics { get; set; } = null!;

        public DbSet<Tag> Tags { get; set; } = null!;

        public DbSet<Textual> Textuals { get; set; } = null!;
        public DbSet<TextureTag> TextureTags { get; set; } = null!;

        public FengsaoContext()
            : this(new DbContextOptionsBuilder<FengsaoContext>().UseSqlite("Data Source=./fengsao.db").Options)
        {
        }

        public FengsaoContext(DbContextOptions<FengsaoContext> options)
            : base(options)
        {
        }
    }
}
