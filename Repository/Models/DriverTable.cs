using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class DriverTable
{
    public int DriverCode { get; set; }

    public string DriverName { get; set; } = null!;

    public string DriverId { get; set; } = null!;

    public string? DriverTel { get; set; }

    public string LicenseType { get; set; } = null!;

    public virtual ICollection<OccasionalTravelTable> OccasionalTravelTables { get; set; } = new List<OccasionalTravelTable>();

    public virtual ICollection<RegularTravelTable> RegularTravelTables { get; set; } = new List<RegularTravelTable>();
}
