using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class RegularTravelTable
{
    public int CodeTravel { get; set; }

    public string CollectionPoint { get; set; } = null!;

    public string Target { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DriverCode { get; set; }

    public int CodeCar { get; set; }

    public int CodeCustoner { get; set; }

    public int TravelTimesCode { get; set; }

    public int TravelStsationCode { get; set; }

    public virtual CarsTable CodeCarNavigation { get; set; } = null!;

    public virtual RegularCustomerTable CodeCustonerNavigation { get; set; } = null!;

    public virtual DriverTable DriverCodeNavigation { get; set; } = null!;

    public virtual StationTable TravelStsationCodeNavigation { get; set; } = null!;

    public virtual TravelTimeSystem TravelTimesCodeNavigation { get; set; } = null!;
}
