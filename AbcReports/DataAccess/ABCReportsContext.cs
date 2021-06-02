using Microsoft.EntityFrameworkCore;

#nullable disable

/// <summary>
/// Disclaimer: most of this code is generated automatically.
/// </summary>
namespace AbcReports
{
    public partial class ABCReportsContext : DbContext
    {
        public ABCReportsContext()
        {
        }

        public ABCReportsContext(DbContextOptions<ABCReportsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountTransaction> AccountTransactions { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=ABCReports;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(x => x.AccountId);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                //entity
                //    .HasOne(x => x.AccountType)
                //    .WithMany(x => x.Accounts);
            });

            modelBuilder.Entity<AccountTransaction>(entity =>
            {
                entity.HasKey(x => x.TransactionId);

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(x => x.AccountTypeId);

                entity.Property(e => e.AccountTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasKey(x => x.ReportId);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity
                    .HasOne(p => p.Account)
                    .WithMany(b => b.Reports);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(x => x.UserId);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
