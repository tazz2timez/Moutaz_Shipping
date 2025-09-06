﻿using System;
using System.Collections.Generic;

namespace Domains.Models;

public partial class TbShippment:baseTable
{
    public DateTime ShippingDate { get; set; }

    public Guid SenderId { get; set; }

    public Guid ReceiverId { get; set; }

    public Guid UserId { get; set; }

    public Guid ShippingTypeId { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public double Weight { get; set; }

    public double Length { get; set; }

    public decimal PackageValue { get; set; }

    public decimal ShippingRate { get; set; }

    public Guid? PaymentMethodId { get; set; }

    public Guid? UserSubscriptionId { get; set; }

    public double? TrackingNumber { get; set; }

    public Guid? ReferenceId { get; set; }

    public virtual TbPaymentMethod? TbPaymentMethod { get; set; }

    public virtual TbUserReceiver TbReceiver { get; set; } = null!;

    public virtual TbUserSender TbSender { get; set; } = null!;

    public virtual TbShippingType TbShippingType { get; set; } = null!;

    public virtual ICollection<TbShippmentStatus> TbShippmentStatuses { get; set; } = new List<TbShippmentStatus>();
}
