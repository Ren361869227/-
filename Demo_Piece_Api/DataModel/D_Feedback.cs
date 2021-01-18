namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Feedback
    {
        [Key]
        public int FKId { get; set; }

        [StringLength(100)]
        public string FKNei { get; set; }

        public DateTime? FKShi { get; set; }

        public int? XId { get; set; }

        public int? TID { get; set; }
    }
}
