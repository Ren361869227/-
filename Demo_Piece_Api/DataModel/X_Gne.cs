namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class X_Gne
    {
        [Key]
        public int GId { get; set; }

        [StringLength(20)]
        public string GName { get; set; }
    }
}
