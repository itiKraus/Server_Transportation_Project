using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class GarageTable
{
    public int GarageCode { get; set; }

    public string GarageName { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<VehicleRepairsTable> VehicleRepairsTables { get; set; } = new List<VehicleRepairsTable>();
}
