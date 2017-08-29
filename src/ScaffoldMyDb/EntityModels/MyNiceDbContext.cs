using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaffoldMyDb.EntityModels
{
    public partial class MyNiceDbContext : DbContext
    {
        public virtual DbSet<UPPERCASE_TABLE> UPPERCASE_TABLE { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(local);Database=MyNiceDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UPPERCASE_TABLE>(entity =>
            {
                entity.HasKey(e => e.UPPERCASE_COLUMN);

                entity.Property(e => e.UPPERCASE_COLUMN).ValueGeneratedNever();
            });
        }
    }
}
