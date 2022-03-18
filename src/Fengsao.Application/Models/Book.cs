using System;

namespace Fengsao.Application.Models;

public class Book
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public DateTime CreationTime { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
}
