namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class L_TuiZu
    {
        [Key]
        public int TId { get; set; }

        public int? ZId { get; set; }

        public int? YID { get; set; }

        public bool? TYaType { get; set; }

        public DateTime? TTuiTime { get; set; }

        public DateTime? THeBegin { get; set; }

        public DateTime? THeEnd { get; set; }

        public int? PID { get; set; }

        public bool? THeTong { get; set; }

        public bool? TTuiZu { get; set; }

        public DateTime? TCreatTime { get; set; }
    }
}
