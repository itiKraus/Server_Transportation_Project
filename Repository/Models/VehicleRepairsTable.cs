using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class VehicleRepairsTable
{
    public int ActionCode { get; set; }

    public DateTime EnterDate { get; set; }

    public DateTime ExitDate { get; set; }

    public int CarCode { get; set; }

    public int Price { get; set; }

    public int GarageCode { get; set; }

    public virtual CarsTable CarCodeNavigation { get; set; } = null!;

    public virtual GarageTable GarageCodeNavigation { get; set; } = null!;
}
