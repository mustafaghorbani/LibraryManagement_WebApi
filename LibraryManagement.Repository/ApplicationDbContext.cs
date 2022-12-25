
using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Helpers;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BookTransaction> BookTransactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Book>().HasKey(x => x.Id);
            modelBuilder.Entity<Book>().HasIndex(x => x.ISBN).IsUnique(true);
            modelBuilder.Entity<Book>().Property(x => x.Title).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Book>().Property(x => x.Description).HasMaxLength(50);


            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Member>().HasKey(x => x.Id);
            modelBuilder.Entity<Member>().HasIndex(x => x.MemberId).IsUnique(true);
            modelBuilder.Entity<Member>().Property(x => x.MemberName).IsRequired().HasMaxLength(80);


            modelBuilder.Entity<BookTransaction>().ToTable("BookTransaction");
            modelBuilder.Entity<BookTransaction>().HasKey(x => x.Id);
            modelBuilder.Entity<BookTransaction>().HasOne(x => x.Book).WithMany(x => x.BookTransactions).HasForeignKey(x => x.ISBN).HasPrincipalKey(x => x.ISBN);
            modelBuilder.Entity<BookTransaction>().HasOne(x => x.Member).WithMany(x => x.BookTransactions).HasForeignKey(x => x.MemberId).HasPrincipalKey(x => x.MemberId);


            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var sampleBooks = new List<Book>()
            {
                new Book(){Id = Guid.NewGuid(),Title ="A Heart That Works",ISBN="978-0-393-04002-9",Author="Rob Delaney",Description="",CreatedBy="Mustafa"},
                new Book(){Id = Guid.NewGuid(),Title="Afterlives",ISBN="978-0-393-04012-9 ",Author="Abdulrazak Gurnah",Description="",CreatedBy="Mustafa" },
                new Book(){Id = Guid.NewGuid(),Title="Ancestor Trouble",ISBN="978-0-393-04022-9",Author="Maud Newton",Description="",CreatedBy="Mustafa"},
                new Book(){Id = Guid.NewGuid(),Title="Animal Joy",ISBN="978-0-393-04032-9",Author="Nuar Alsadir",Description="",CreatedBy="Mustafa"},
                new Book(){Id = Guid.NewGuid(),Title="Babel",ISBN="978-0-393-04052-9",Author="R.F. Kuang",Description="",CreatedBy="Mustafa"},
            };


            var sampleMembers = new List<Member>()
            {
                new Member(){Id = Guid.NewGuid(),MemberName="Ali Koc",CreatedBy="Mustafa",IsActive=true},
                new Member(){Id = Guid.NewGuid(),MemberName="Sara yilmaz",CreatedBy="Mustafa",IsActive=true},
                new Member(){Id = Guid.NewGuid(),MemberName="Yilmaz Goney",CreatedBy="Mustafa",IsActive=true},
            };

            var sampleBookTransactions = new List<BookTransaction>()
            {
                new BookTransaction(){Id = Guid.NewGuid(),ISBN="978-0-393-04002-9",MemberId=sampleMembers[0].MemberId,DueTo=CommonHelper.AddBusinessDays(DateTime.Now,30)},
                new BookTransaction(){Id = Guid.NewGuid(),ISBN="978-0-393-04022-9",MemberId=sampleMembers[1].MemberId,DueTo=CommonHelper.AddBusinessDays(DateTime.Now,30)},
                new BookTransaction(){Id = Guid.NewGuid(),ISBN="978-0-393-04052-9",MemberId=sampleMembers[2].MemberId,DueTo=CommonHelper.AddBusinessDays(DateTime.Now,30)}
            };

            modelBuilder.Entity<Book>().HasData(sampleBooks);
            modelBuilder.Entity<Member>().HasData(sampleMembers);
            modelBuilder.Entity<BookTransaction>().HasData(sampleBookTransactions);
        }
    }
}
