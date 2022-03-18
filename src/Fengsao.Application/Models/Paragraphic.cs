namespace Fengsao.Application.Models;

public class Paragraphic
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int ParentId { get; set; }
    public int BookId { get; set; }
}
