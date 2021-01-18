namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class X_He
    {
        public int ID { get; set; }

        public int? Hetongid { get; set; }

        public int? ZID { get; set; }

        [StringLength(50)]
        public string Fangyuanxinxi { get; set; }

        public DateTime? Qizuriqi { get; set; }

        public DateTime? Jiesuriqi { get; set; }

        public int? GID { get; set; }

        public int? Fy { get; set; }

        public DateTime? Chuangjianriqi { get; set; }
    }
}
