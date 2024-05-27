using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TextEditor.Models;

namespace TextEditor.Data
{
    public class TextEditorDB : IdentityDbContext
    {
        public TextEditorDB(DbContextOptions<TextEditorDB> options)
            : base(options)
        {
        }
        public DbSet<Doc> Docs { get; set; }
    }
}
