namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Guan
    {
        [Key]
        public int GId { get; set; }

        public int? ZId { get; set; }

        [StringLength(50)]
        public string WFang { get; set; }

        public int? FId { get; set; }

        public bool? GTai { get; set; }

        public int? WID { get; set; }

        [StringLength(50)]
        public string WBei { get; set; }
    }
}
