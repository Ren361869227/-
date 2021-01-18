namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Weixiu
    {
        [Key]
        public int WId { get; set; }

        [StringLength(20)]
        public string WName { get; set; }
    }
}
