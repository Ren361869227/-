namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Housing
    {
        [Key]
        public int FId { get; set; }

        public int? LID { get; set; }

        public int? FangHao { get; set; }

        public int? FMianji { get; set; }

        public bool? ZhaoShang { get; set; }

        public DateTime? FTimes { get; set; }
    }
}
