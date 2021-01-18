namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class L_Shou
    {
        [Key]
        public int SId { get; set; }

        [StringLength(30)]
        public string STai { get; set; }

        public DateTime? SHi { get; set; }
    }
}
