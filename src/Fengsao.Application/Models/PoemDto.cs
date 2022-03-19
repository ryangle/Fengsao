using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fengsao.Application.Models
{
    public class PoemDto
    {
        public string Title { get; set; } = null!;
        public string Text { get; set; } = null!;
        public string AuthorName { get; set; } = null!;
        public string DynastyName { get; set; } = null!;
    }
}
