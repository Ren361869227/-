namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Users
    {
        [Key]
        public int UId { get; set; }

        [StringLength(20)]
        public string UName { get; set; }

        public bool? Sex { get; set; }

        public int? UTel { get; set; }

        public DateTime? UTimes { get; set; }
    }
}
