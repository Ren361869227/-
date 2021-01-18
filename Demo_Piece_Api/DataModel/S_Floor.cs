namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Floor
    {
        [Key]
        public int LuID { get; set; }

        [StringLength(50)]
        public string LYName { get; set; }

        public int? YId { get; set; }
    }
}
