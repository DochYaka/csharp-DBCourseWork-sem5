using System;
using System.Collections.Generic;

namespace csharp_DBCourseWork_sem5.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public DateOnly DateBirthday { get; set; }

    public string HouseNumber { get; set; } = null!;

    public int? CityId { get; set; }

    public int? StreetId { get; set; }

    public int WorkExperience { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Street? Street { get; set; }

    public virtual ICollection<WorkBook> WorkBooks { get; set; } = new List<WorkBook>();
}
