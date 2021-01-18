namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class R_Information
    {
        [Key]
        public int IId { get; set; }

        public int? IName { get; set; }

        [StringLength(30)]
        public string Img { get; set; }

        public int? IPwd { get; set; }

        [StringLength(50)]
        public string IPwwd { get; set; }
    }
}
