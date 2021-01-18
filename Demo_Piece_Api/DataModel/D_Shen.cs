namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Shen
    {
        [Key]
        public int SId { get; set; }

        public int? TID { get; set; }

        public int? AID { get; set; }

        public int? XID { get; set; }
    }
}
