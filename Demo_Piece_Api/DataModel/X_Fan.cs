namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class X_Fan
    {
        [Key]
        public int XID { get; set; }

        [StringLength(50)]
        public string Lou { get; set; }

        [StringLength(50)]
        public string Ceng { get; set; }

        [StringLength(50)]
        public string Fang { get; set; }
    }
}
