using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fengsao.Application.Models;

public class Dynasty
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public long Start { get; set; }
    public long End { get; set; }
}
