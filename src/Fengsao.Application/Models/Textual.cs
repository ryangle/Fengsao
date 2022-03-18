using System;

namespace Fengsao.Application.Models;

public class Textual
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public int GenreId { get; set; }
    public int ParagraphicId { get; set; }
    public DateTime CreationTime { get; set; }
    public string Title { get; set; } = null!;
    public string Text { get; set; } = null!;
    public string? Annotation { get; set; }
    public string? Context { get; set; }
}
