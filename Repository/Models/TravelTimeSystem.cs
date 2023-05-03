using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class TravelTimeSystem
{
    public int Id { get; set; }

    public int TravelCode { get; set; }

    public int DayWeek { get; set; }

    public string LeavingTime { get; set; } = null!;

    public virtual ICollection<RegularTravelTable> RegularTravelTables { get; set; } = new List<RegularTravelTable>();
}
