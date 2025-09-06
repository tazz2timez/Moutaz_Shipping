using System;
using System.Collections.Generic;

namespace Domains.Models;

public partial class TbSubscriptionPackage:baseTable
{

    public string PackageName { get; set; } = null!;

    public int ShippimentCount { get; set; }

    public double NumberOfKiloMeters { get; set; }

    public double TotalWeight { get; set; }

    public virtual ICollection<TbUserSubscription> TbUserSubscriptions { get; set; } = new List<TbUserSubscription>();
}
