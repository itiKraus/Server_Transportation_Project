using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class StationTable
{
    public int Id { get; set; }

    public int TravelCode { get; set; }

    public string StationAddress { get; set; } = null!;

    public string X { get; set; } = null!;

    public string Y { get; set; } = null!;

    public int IndexStation { get; set; }

    public virtual ICollection<RegularTravelTable> RegularTravelTables { get; set; } = new List<RegularTravelTable>();
}
