namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class L_ping
    {
        [Key]
        public int PId { get; set; }

        [StringLength(100)]
        public string PIng { get; set; }
    }
}
