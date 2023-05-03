using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class OccasionalTravelTable
{
    public int OccasionalTravelCode { get; set; }

    public DateTime Date { get; set; }

    public int Customercode { get; set; }

    public int Price { get; set; }

    public int DriverCode { get; set; }

    public int CarCode { get; set; }

    public string Target { get; set; } = null!;

    public string CollectionPoint { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual CarsTable CarCodeNavigation { get; set; } = null!;

    public virtual OccasionalCustomersTable CustomercodeNavigation { get; set; } = null!;

    public virtual DriverTable DriverCodeNavigation { get; set; } = null!;
}
