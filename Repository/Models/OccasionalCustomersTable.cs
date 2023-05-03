using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class OccasionalCustomersTable
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<OccasionalTravelTable> OccasionalTravelTables { get; set; } = new List<OccasionalTravelTable>();
}
