using Microsoft.EntityFrameworkCore;

namespace Member_Registration_Demo_Project.Models
{
    public class MemberDbContext : DbContext
    {
        public MemberDbContext(DbContextOptions<MemberDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<Hobby> Hobbies { get; set; }

        public DbSet<Society> Societies { get; set; }

        public DbSet<ClubMember> ClubMembers { get; set; }

    }
}
