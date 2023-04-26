using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class TestEmployee
{
    public int EmpId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? DeptId { get; set; }

    public decimal? Salary { get; set; }
}
