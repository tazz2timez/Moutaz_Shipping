using System;
using System.Collections.Generic;

namespace Domains.Models;

public partial class TbPaymentMethod:baseTable
{

    public string? MethdAname {get;set;}

    public string? MethodEname {get;set;}

    public double? Commission {get;set;}

    public virtual ICollection<TbShippment> TbShippments { get; set; } = new List<TbShippment>();

}
