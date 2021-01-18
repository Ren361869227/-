namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class L_ShouKuan
    {
        [Key]
        public int SId { get; set; }

        [StringLength(50)]
        public string SName { get; set; }
    }
}
