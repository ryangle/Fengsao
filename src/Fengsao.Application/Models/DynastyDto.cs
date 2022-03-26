using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fengsao.Application.Models;

public class DynastyDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Period { get; set; } = null!;
}
