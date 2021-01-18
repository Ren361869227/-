namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class X_Hetong
    {
        public int ID { get; set; }

        public int? TId { get; set; }

        public int? GId { get; set; }

        public int? Hetongbianhao { get; set; }

        public int? WId { get; set; }

        public int? YId { get; set; }
    }
}
