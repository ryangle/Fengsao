using Fengsao.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fengsao.Application.Services;

public class FengsaoService
{
    public Author AddAuthor(Author author)
    {
        using FengsaoContext fengsaoContext = new FengsaoContext();
        fengsaoContext.Authors.Add(author);
        fengsaoContext.SaveChanges();
        return author;
    }
    public Author AddAuthor(Author author, string dynastyName)
    {
        using FengsaoContext fengsaoContext = new FengsaoContext();
        var dynasty = fengsaoContext.Dynastys.FirstOrDefault(x => x.Name == dynastyName);
        if (dynasty != null)
        {
            author.DynastyId = dynasty.Id;
        }
        AddAuthor(author);
        return author;
    }

    public Dynasty AddDynasty(Dynasty dynasty)
    {
        using FengsaoContext fengsaoContext = new FengsaoContext();
        var exist = fengsaoContext.Dynastys.Any(x => x.Name == dynasty.Name);
        if (!exist)
        {
            fengsaoContext.Dynastys.Add(dynasty);
            fengsaoContext.SaveChanges();
        }
        return dynasty;
    }
    public Textual AddTextual(Textual textual, string authorName)
    {
        using FengsaoContext fengsaoContext = new FengsaoContext();
        var author = fengsaoContext.Authors.FirstOrDefault(x => x.Name == authorName);
        if (author != null)
        {
            textual.AuthorId = author.Id;
        }
        fengsaoContext.Textuals.Add(textual);
        fengsaoContext.SaveChanges();
        return textual;
    }
    public PoemDto GetRandomTextual()
    {
        using FengsaoContext fengsaoContext = new FengsaoContext();
        var count = fengsaoContext.Textuals.Count();
        Random random = new Random();
        var r = random.Next(count - 1);

        var result = fengsaoContext.Textuals.Where(t => t.Id == r).Join(fengsaoContext.Authors, t => t.AuthorId, a => a.Id, (t, a) => new PoemDto
        {
            Text = t.Text,
            Title = t.Title,
            AuthorName = a.Name
        }).First();
        return result ?? new PoemDto();
    }
}
