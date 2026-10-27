using System;
using System.Collections.Generic;

namespace csharp_DBCourseWork_sem5.Models;

public partial class BookCopy
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public decimal CopyPurchasePrice { get; set; }

    public int? Quantity { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();
}
