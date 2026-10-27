using System;
using System.Collections.Generic;

namespace csharp_DBCourseWork_sem5.Models;

public partial class Specialty
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<WorkBook> WorkBooks { get; set; } = new List<WorkBook>();
}
