namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Place
    {
        [Key]
        public int PId { get; set; }

        [StringLength(20)]
        public string PName { get; set; }

        public DateTime? PShi { get; set; }
    }
}
