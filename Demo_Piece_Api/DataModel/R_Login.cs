namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class R_Login
    {
        [Key]
        public int LId { get; set; }

        [StringLength(30)]
        public string LName { get; set; }

        [StringLength(30)]
        public string LPwd { get; set; }
    }
}
