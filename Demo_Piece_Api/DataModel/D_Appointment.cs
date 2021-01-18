namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Appointment
    {
        [Key]
        public int AId { get; set; }

        [StringLength(30)]
        public string ADi { get; set; }

        [StringLength(50)]
        public string ATu { get; set; }

        public DateTime? Aong { get; set; }

        public DateTime? AShi { get; set; }

        public bool? ATai { get; set; }

        public int? XId { get; set; }

        public int? XXId { get; set; }
    }
}
