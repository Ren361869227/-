namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class L_Reminder
    {
        [Key]
        public int RId { get; set; }

        public int? TId { get; set; }

        public int? WId { get; set; }

        public int? SId { get; set; }

        public bool? RFaSong { get; set; }

        public int? SIDD { get; set; }
    }
}
