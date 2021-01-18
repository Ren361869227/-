namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Park
    {
        [Key]
        public int YID { get; set; }

        [StringLength(20)]
        public string YName { get; set; }

        public int? YZongLou { get; set; }

        public double? YFangYuan { get; set; }

        public double? YKeZhao { get; set; }

        public DateTime? YTimes { get; set; }
    }
}
