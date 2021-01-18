namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Department
    {
        [Key]
        public int BId { get; set; }

        [StringLength(20)]
        public string BName { get; set; }

        [StringLength(20)]
        public string BMiao { get; set; }

        public DateTime? BTimes { get; set; }
    }
}
