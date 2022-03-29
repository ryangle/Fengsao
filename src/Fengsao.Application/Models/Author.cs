using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fengsao.Application.Models;

/// <summary>
/// 作者
/// </summary>
public class Author
{
    public int Id { get; set; }
    public int DynastyId { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public int Gender { get; set; }
    public DateTime Birth { get; set; }
    public DateTime Death { get; set; }

}
