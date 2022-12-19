
using LibraryManagement.Domain.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Repository
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext() :base()
        //{

        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BookTransaction> BookTransactions { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder
        //        .UseLazyLoadingProxies()
        //        .UseSqlServer(connectionString: _connectionString);


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Book>().HasKey(x => x.Id);
            modelBuilder.Entity<Book>().HasIndex(x => x.ISBN).IsUnique(true);
            modelBuilder.Entity<Book>().Property(x => x.Title).IsRequired().HasMaxLength(50);


            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Member>().HasKey(x => x.Id);
            modelBuilder.Entity<Member>().HasIndex(x => x.MemberId).IsUnique(true);
            modelBuilder.Entity<Member>().Property(x => x.MemberName).IsRequired().HasMaxLength(80);


            modelBuilder.Entity<BookTransaction>().ToTable("BookTransaction");
            modelBuilder.Entity<BookTransaction>().HasKey(x => new { x.MemberId, x.ISBN });
            modelBuilder.Entity<BookTransaction>().HasOne(x => x.Book).WithMany(x => x.BookTransactions).HasForeignKey(x => x.ISBN).HasPrincipalKey(x => x.ISBN);
            modelBuilder.Entity<BookTransaction>().HasOne(x => x.Member).WithMany(x => x.BookTransactions).HasForeignKey(x => x.MemberId).HasPrincipalKey(x => x.MemberId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
