namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebsiteKhoaCoKhiDbContext : DbContext
    {
        public WebsiteKhoaCoKhiDbContext()
            : base("name=WebsiteKhoaCoKhiDbContext")
        {
        }

        public virtual DbSet<AdminAccount> AdminAccounts { get; set; }
        public virtual DbSet<CategoryNew> CategoryNews { get; set; }
        public virtual DbSet<New> News { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<SubMenu> SubMenus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminAccount>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<AdminAccount>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<AdminAccount>()
                .Property(e => e.phoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AdminAccount>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryNew>()
                .HasMany(e => e.News)
                .WithOptional(e => e.CategoryNew)
                .HasForeignKey(e => e.categoryId);

            modelBuilder.Entity<CategoryNew>()
                .HasMany(e => e.Notices)
                .WithOptional(e => e.CategoryNew)
                .HasForeignKey(e => e.categoryId);

            modelBuilder.Entity<New>()
                .Property(e => e.images)
                .IsUnicode(false);

            modelBuilder.Entity<New>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<New>()
                .Property(e => e.modifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<Notice>()
                .Property(e => e.images)
                .IsUnicode(false);

            modelBuilder.Entity<Notice>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<Notice>()
                .Property(e => e.modifyBy)
                .IsUnicode(false);
            modelBuilder.Entity<Menu>().Property(e => e.link).IsUnicode(false);

            //modelBuilder.Entity<Menu>()
            //    .HasMany(e => e.SubMenus)
            //    .WithOptional(e => e.Menu)
            //    .HasForeignKey(e => e.typeMenu);
        }
    }
}
