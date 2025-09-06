using System;
using System.Collections.Generic;

namespace Domains.Models;

public partial class TbUserSubscription:baseTable
{

    public Guid UserId { get; set; }

    public Guid PackageId { get; set; }

    public DateTime SubscriptionDate { get; set; }

    public virtual TbSubscriptionPackage TbPackage { get; set; } = null!;


}
