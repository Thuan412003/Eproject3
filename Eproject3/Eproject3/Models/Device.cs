﻿using System;
using System.Collections.Generic;

namespace Eproject3.Models
{
    public partial class Device
    {
        public Device()
        {
            MaintainceDevices = new HashSet<MaintainceDevice>();
            Reports = new HashSet<Report>();
        }

        public string DevicesId { get; set; } = null!;
        public string DeviceName { get; set; } = null!;
        public string? DeviceType { get; set; }
        public string? SupplyFrom { get; set; }
        public string? Status { get; set; }
        public DateTime? DateMaintance { get; set; }
        public string? DeviceImg { get; set; }
        public int LabsId { get; set; }
        public int SupplierId { get; set; }

        public virtual Lab Labs { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
        public virtual ICollection<MaintainceDevice> MaintainceDevices { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
