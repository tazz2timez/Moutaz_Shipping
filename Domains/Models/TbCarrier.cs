using System;
using System.Collections.Generic;

namespace Domains.Models;

public partial class TbCarrier:baseTable
{

    public string CarrierName { get; set; } = null!;

    public virtual ICollection<TbShippmentStatus> TbShippmentStatuses { get; set; } = new List<TbShippmentStatus>();
}
