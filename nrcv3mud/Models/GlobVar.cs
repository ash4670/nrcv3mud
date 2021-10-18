using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace nrcv3mud.Models
{
    [Table("glob_vars")]
    public partial class GlobVar
    {
        [Column("yearstart", TypeName = "date")]
        public DateTime? Yearstart { get; set; }
        [Column("yearend", TypeName = "date")]
        public DateTime? Yearend { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}
