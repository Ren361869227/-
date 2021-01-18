namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class L_Check
    {
        [Key]
        public int CId { get; set; }

        public int? ZID { get; set; }

        public int? XID { get; set; }

        public int? WID { get; set; }

        public int? SID { get; set; }

        public int? PId { get; set; }
    }
}
