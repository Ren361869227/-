namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_DTpye
    {
        [Key]
        public int FId { get; set; }

        [StringLength(20)]
        public string FName { get; set; }

        public DateTime? FShi { get; set; }
    }
}
