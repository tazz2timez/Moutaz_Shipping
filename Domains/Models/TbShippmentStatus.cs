using System;
using System.Collections.Generic;

namespace Domains.Models;

public partial class TbShippmentStatus:baseTable
{
    public Guid? ShippmentId { get; set; }

    public string? Notes { get; set; }

    public Guid CarrierId { get; set; }

    public virtual TbCarrier TbCarrier { get; set; } = null!;

    public virtual TbShippment? TbShippment { get; set; }

}
