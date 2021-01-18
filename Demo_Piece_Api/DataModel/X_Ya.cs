namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class X_Ya
    {
        [Key]
        public int YId { get; set; }

        [Column(TypeName = "money")]
        public decimal? YA { get; set; }
    }
}
