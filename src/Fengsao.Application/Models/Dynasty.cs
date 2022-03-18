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
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}
