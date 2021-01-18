namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Role
    {
        [Key]
        public int JId { get; set; }

        [StringLength(20)]
        public string JName { get; set; }

        [StringLength(20)]
        public string JMiaoShu { get; set; }

        public DateTime? JTimes { get; set; }
    }
}
