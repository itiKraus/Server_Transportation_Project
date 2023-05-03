using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class CarsTable
{
    public int CodeCar { get; set; }

    public string CompanyCar { get; set; } = null!;

    public int NumCar { get; set; }

    public int NumPlaces { get; set; }

    public int ProductionYear { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<OccasionalTravelTable> OccasionalTravelTables { get; set; } = new List<OccasionalTravelTable>();

    public virtual ICollection<RegularTravelTable> RegularTravelTables { get; set; } = new List<RegularTravelTable>();

    public virtual ICollection<VehicleRepairsTable> VehicleRepairsTables { get; set; } = new List<VehicleRepairsTable>();
}
