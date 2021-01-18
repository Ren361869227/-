namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Tenant
    {
        [Key]
        public int TId { get; set; }

        [StringLength(20)]
        public string TName { get; set; }

        [StringLength(30)]
        public string TDian { get; set; }

        [StringLength(50)]
        public string TFang { get; set; }

        public int? AID { get; set; }

        public int? FKID { get; set; }
    }
}
