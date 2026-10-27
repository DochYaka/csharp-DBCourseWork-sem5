using System;
using System.Collections.Generic;

namespace csharp_DBCourseWork_sem5.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Edition { get; set; }

    public int Year { get; set; }

    public string? Annotation { get; set; }

    public decimal PurchasePrice { get; set; }

    public decimal SalePrice { get; set; }

    public virtual ICollection<BookCopy> BookCopies { get; set; } = new List<BookCopy>();

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

    public virtual ICollection<Publisher> PublishingHouses { get; set; } = new List<Publisher>();
}
