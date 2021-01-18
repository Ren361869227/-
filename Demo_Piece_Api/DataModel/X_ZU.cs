namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class X_ZU
    {
        public int ID { get; set; }

        public int? ZId { get; set; }

        [StringLength(20)]
        public string ZName { get; set; }

        public string Zhengjianhaoma { get; set; }

        [StringLength(50)]
        public string Hangyefenlei { get; set; }

        [StringLength(10)]
        public string Chuangjianshijian { get; set; }

        [StringLength(50)]
        public string Kaihuyinhang { get; set; }

        [StringLength(50)]
        public string Zhanghao { get; set; }

        [StringLength(50)]
        public string Dianhua { get; set; }

        [StringLength(50)]
        public string Fapiaoleixing { get; set; }

        public DateTime? Chengliriqi { get; set; }
    }
}
