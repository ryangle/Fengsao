using Fengsao.Application.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;

namespace Fengsao.Application.Services;

public class FengsaoService
{
    private readonly ILogger _logger;
    public FengsaoService(ILogger<FengsaoService> logger)
    {
        _logger = logger;
    }

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
        var dynasty = fengsaoContext.Dynasty.FirstOrDefault(x => x.Name == dynastyName);
        if (dynasty != null)
        {
            author.DynastyId = dynasty.Id;
        }
        AddAuthor(author);
        return author;
    }
    public List<Author> GetAuthors(int page = 0, int pageSize = 100)
    {
        _logger?.LogDebug($"GetAuthors {page},{pageSize}");
        if (page < 0 || pageSize <= 0)
        {
            return new List<Author>();
        }
        using FengsaoContext fengsaoContext = new FengsaoContext();
        var authors = fengsaoContext.Authors.Skip(page * pageSize).Take(pageSize).ToList();
        return authors ?? new List<Author>();
    }
    public Author GetAuthor(string authorName)
    {
        _logger?.LogDebug($"GetAuthor {authorName}");
        if (string.IsNullOrEmpty(authorName))
        {
            return new Author();
        }
        using FengsaoContext fengsaoContext = new FengsaoContext();
        var author = fengsaoContext.Authors.Where(a => a.Name == authorName).FirstOrDefault();
        return author ?? new Author();
    }
    public Dynasty AddDynasty(Dynasty dynasty)
    {
        using FengsaoContext fengsaoContext = new FengsaoContext();
        var exist = fengsaoContext.Dynasty.Any(x => x.Name == dynasty.Name);
        if (!exist)
        {
            fengsaoContext.Dynasty.Add(dynasty);
            fengsaoContext.SaveChanges();
        }
        return dynasty;
    }
    public List<DynastyDto> GetDynastys()
    {
        using FengsaoContext fengsaoContext = new FengsaoContext();
        var dynastyDtos = fengsaoContext.Dynasty.Select(d => new DynastyDto
        {
            Id = d.Id,
            Name = d.Name,
            Period = $"{Instant.FromUnixTimeSeconds(d.Start).ToString("yyyy g", null)}-{Instant.FromUnixTimeSeconds(d.End).ToString("yyyy g", null)}"
        }).ToList();

        return dynastyDtos;
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

        var result = fengsaoContext.Textuals
            .Where(t => t.Id == r)
            .Join(fengsaoContext.Authors, t => t.AuthorId, a => a.Id, (t, a) => new
            {
                Text = t.Text,
                Title = t.Title,
                AuthorName = a.Name,
                DynastyId = a.DynastyId
            })
            .Join(fengsaoContext.Dynasty, a => a.DynastyId, d => d.Id, (a, d) => new PoemDto
            {
                Text = a.Text,
                Title = a.Title,
                AuthorName = a.AuthorName,
                DynastyName = d.Name
            }).First();

        return result ?? new PoemDto();
    }
}
