using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Repository;


namespace LibraryManagement.Repository.Repositories
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
