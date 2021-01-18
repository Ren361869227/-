namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class L_Wu
    {
        [Key]
        public int WId { get; set; }

        [Column(TypeName = "money")]
        public decimal? WTing { get; set; }

        [Column(TypeName = "money")]
        public decimal? WGong { get; set; }

        [Column(TypeName = "money")]
        public decimal? WZu { get; set; }

        [Column(TypeName = "money")]
        public decimal? WU { get; set; }
    }
}
