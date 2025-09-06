using System;
using System.Collections.Generic;

namespace Domains.Models;

public partial class TbCountry:baseTable
{

    public string? CountryAname { get; set; }

    public string? CountryEname { get; set; }

    public virtual ICollection<TbCity> TbCities { get; set; } = new List<TbCity>();
}
