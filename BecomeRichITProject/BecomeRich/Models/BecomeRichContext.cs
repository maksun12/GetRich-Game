namespace BecomeRich
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BecomeRichContext : DbContext
    {
        public BecomeRichContext()
            : base("name=BecomeRichContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Towns)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Friend>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Question1)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.A)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.B)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.C)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.D)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Answear)
                .IsUnicode(false);

            modelBuilder.Entity<Town>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Town>()
                .HasMany(e => e.Friends)
                .WithOptional(e => e.Town)
                .HasForeignKey(e => e.HomeTownId);

            modelBuilder.Entity<Town>()
                .HasMany(e => e.Players)
                .WithOptional(e => e.Town)
                .HasForeignKey(e => e.HomeTownId);
        }
    }
}
