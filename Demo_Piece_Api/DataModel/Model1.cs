using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataModel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<D_Appointment> D_Appointment { get; set; }
        public virtual DbSet<D_DTpye> D_DTpye { get; set; }
        public virtual DbSet<D_Feedback> D_Feedback { get; set; }
        public virtual DbSet<D_Guan> D_Guan { get; set; }
        public virtual DbSet<D_Place> D_Place { get; set; }
        public virtual DbSet<D_Shen> D_Shen { get; set; }
        public virtual DbSet<D_Tenant> D_Tenant { get; set; }
        public virtual DbSet<D_Weixiu> D_Weixiu { get; set; }
        public virtual DbSet<L_Check> L_Check { get; set; }
        public virtual DbSet<L_ping> L_ping { get; set; }
        public virtual DbSet<L_Reminder> L_Reminder { get; set; }
        public virtual DbSet<L_Shou> L_Shou { get; set; }
        public virtual DbSet<L_ShouKuan> L_ShouKuan { get; set; }
        public virtual DbSet<L_Shui> L_Shui { get; set; }
        public virtual DbSet<L_TuiZu> L_TuiZu { get; set; }
        public virtual DbSet<L_Wu> L_Wu { get; set; }
        public virtual DbSet<R_Information> R_Information { get; set; }
        public virtual DbSet<R_Login> R_Login { get; set; }
        public virtual DbSet<S_Account> S_Account { get; set; }
        public virtual DbSet<S_Building> S_Building { get; set; }
        public virtual DbSet<S_Department> S_Department { get; set; }
        public virtual DbSet<S_Floor> S_Floor { get; set; }
        public virtual DbSet<S_Housing> S_Housing { get; set; }
        public virtual DbSet<S_Park> S_Park { get; set; }
        public virtual DbSet<S_Role> S_Role { get; set; }
        public virtual DbSet<S_Users> S_Users { get; set; }
        public virtual DbSet<X_Fan> X_Fan { get; set; }
        public virtual DbSet<X_Gne> X_Gne { get; set; }
        public virtual DbSet<X_Hang> X_Hang { get; set; }
        public virtual DbSet<X_He> X_He { get; set; }
        public virtual DbSet<X_Hetong> X_Hetong { get; set; }
        public virtual DbSet<X_Ya> X_Ya { get; set; }
        public virtual DbSet<X_ZU> X_ZU { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<D_Appointment>()
                .Property(e => e.ADi)
                .IsUnicode(false);

            modelBuilder.Entity<D_Appointment>()
                .Property(e => e.ATu)
                .IsUnicode(false);

            modelBuilder.Entity<D_DTpye>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<D_Feedback>()
                .Property(e => e.FKNei)
                .IsUnicode(false);

            modelBuilder.Entity<D_Guan>()
                .Property(e => e.WFang)
                .IsUnicode(false);

            modelBuilder.Entity<D_Guan>()
                .Property(e => e.WBei)
                .IsUnicode(false);

            modelBuilder.Entity<D_Place>()
                .Property(e => e.PName)
                .IsUnicode(false);

            modelBuilder.Entity<D_Tenant>()
                .Property(e => e.TName)
                .IsUnicode(false);

            modelBuilder.Entity<D_Tenant>()
                .Property(e => e.TDian)
                .IsUnicode(false);

            modelBuilder.Entity<D_Tenant>()
                .Property(e => e.TFang)
                .IsUnicode(false);

            modelBuilder.Entity<D_Weixiu>()
                .Property(e => e.WName)
                .IsUnicode(false);

            modelBuilder.Entity<L_ping>()
                .Property(e => e.PIng)
                .IsUnicode(false);

            modelBuilder.Entity<L_Shou>()
                .Property(e => e.STai)
                .IsUnicode(false);

            modelBuilder.Entity<L_Shui>()
                .Property(e => e.SShui)
                .HasPrecision(19, 4);

            modelBuilder.Entity<L_Shui>()
                .Property(e => e.SDian)
                .HasPrecision(19, 4);

            modelBuilder.Entity<L_Wu>()
                .Property(e => e.WTing)
                .HasPrecision(19, 4);

            modelBuilder.Entity<L_Wu>()
                .Property(e => e.WGong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<L_Wu>()
                .Property(e => e.WZu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<L_Wu>()
                .Property(e => e.WU)
                .HasPrecision(19, 4);

            modelBuilder.Entity<S_Account>()
                .Property(e => e.ZName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Building>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Building>()
                .Property(e => e.LDiQu)
                .IsUnicode(false);

            modelBuilder.Entity<S_Building>()
                .Property(e => e.LXiang)
                .IsUnicode(false);

            modelBuilder.Entity<S_Building>()
                .Property(e => e.LZhanDi)
                .IsUnicode(false);

            modelBuilder.Entity<S_Department>()
                .Property(e => e.BName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Department>()
                .Property(e => e.BMiao)
                .IsUnicode(false);

            modelBuilder.Entity<S_Floor>()
                .Property(e => e.LYName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Park>()
                .Property(e => e.YName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Role>()
                .Property(e => e.JName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Role>()
                .Property(e => e.JMiaoShu)
                .IsUnicode(false);

            modelBuilder.Entity<S_Users>()
                .Property(e => e.UName)
                .IsUnicode(false);

            modelBuilder.Entity<X_Fan>()
                .Property(e => e.Lou)
                .IsUnicode(false);

            modelBuilder.Entity<X_Fan>()
                .Property(e => e.Ceng)
                .IsUnicode(false);

            modelBuilder.Entity<X_Fan>()
                .Property(e => e.Fang)
                .IsUnicode(false);

            modelBuilder.Entity<X_Gne>()
                .Property(e => e.GName)
                .IsUnicode(false);

            modelBuilder.Entity<X_Hang>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<X_He>()
                .Property(e => e.Fangyuanxinxi)
                .IsUnicode(false);

            modelBuilder.Entity<X_Ya>()
                .Property(e => e.YA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<X_ZU>()
                .Property(e => e.ZName)
                .IsUnicode(false);

            modelBuilder.Entity<X_ZU>()
                .Property(e => e.Zhengjianhaoma)
                .IsUnicode(false);

            modelBuilder.Entity<X_ZU>()
                .Property(e => e.Hangyefenlei)
                .IsUnicode(false);

            modelBuilder.Entity<X_ZU>()
                .Property(e => e.Chuangjianshijian)
                .IsFixedLength();

            modelBuilder.Entity<X_ZU>()
                .Property(e => e.Kaihuyinhang)
                .IsUnicode(false);

            modelBuilder.Entity<X_ZU>()
                .Property(e => e.Zhanghao)
                .IsUnicode(false);

            modelBuilder.Entity<X_ZU>()
                .Property(e => e.Dianhua)
                .IsUnicode(false);

            modelBuilder.Entity<X_ZU>()
                .Property(e => e.Fapiaoleixing)
                .IsUnicode(false);
        }
    }
}
