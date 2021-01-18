namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Building
    {
        [Key]
        public int LID { get; set; }

        [StringLength(20)]
        public string LName { get; set; }

        public int? YID { get; set; }

        [StringLength(20)]
        public string LDiQu { get; set; }

        [StringLength(20)]
        public string LXiang { get; set; }

        [StringLength(20)]
        public string LZhanDi { get; set; }

        public int? LZongFang { get; set; }

        public int? LKeZhao { get; set; }

        public DateTime? LTimes { get; set; }
    }
}
