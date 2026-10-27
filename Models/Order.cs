using System;
using System.Collections.Generic;

namespace csharp_DBCourseWork_sem5.Models;

public partial class Order
{
    public int Id { get; set; }

    public string OrderNumber { get; set; } = null!;

    public DateOnly OrderDate { get; set; }

    public decimal Amount { get; set; }

    public int Quantity { get; set; }

    public int CustomerId { get; set; }

    public int EmployeeId { get; set; }

    public int CopyOfTheBookId { get; set; }

    public virtual BookCopy CopyOfTheBook { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
