using System;
using System.Collections.Generic;

namespace Domains.Models;

public partial class TbSetting
{
    public Guid Id { get; set; }

    public double? KiloMeterRate { get; set; }

    public double? KilooGramRate { get; set; }
}
