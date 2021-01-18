namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class L_Shui
    {
        [Key]
        public int SId { get; set; }

        [Column(TypeName = "money")]
        public decimal? SShui { get; set; }

        [Column(TypeName = "money")]
        public decimal? SDian { get; set; }
    }
}
