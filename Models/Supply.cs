using System;
using System.Collections.Generic;

namespace csharp_DBCourseWork_sem5.Models;

public partial class Supply
{
    public int Id { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public int Quantity { get; set; }

    public int SupplierId { get; set; }

    public int CopyOfTheBookId { get; set; }

    public virtual BookCopy CopyOfTheBook { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
