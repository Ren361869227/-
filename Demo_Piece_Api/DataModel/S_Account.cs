namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Account
    {
        [Key]
        public int ZId { get; set; }

        [StringLength(20)]
        public string ZName { get; set; }

        public int? ZTel { get; set; }

        public int? ZLId { get; set; }

        public int? JId { get; set; }

        public int? BId { get; set; }

        public int? YID { get; set; }

        public int? LId { get; set; }

        public bool? ZQi { get; set; }
    }
}
