using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class RegularCustomerTable
{
    public int RegularCustomerCode { get; set; }

    public string InstutitionName { get; set; } = null!;

    public string HP { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<RegularTravelTable> RegularTravelTables { get; set; } = new List<RegularTravelTable>();
}
