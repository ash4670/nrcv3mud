﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv3mud.Models
{
    [Keyless]
    public partial class ItemsIn
    {
        [Required]
        [Column("STOCK_CODE")]
        [StringLength(2)]
        public string StockCode { get; set; }
        [Required]
        [Column("ITEM_CODE")]
        [StringLength(5)]
        public string ItemCode { get; set; }
        [Column("TOT_IN")]
        public double? TotIn { get; set; }
    }
}
