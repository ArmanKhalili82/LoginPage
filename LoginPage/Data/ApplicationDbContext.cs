using Microsoft.EntityFrameworkCore;
using static LoginPage.Pages.Index;

namespace LoginPage.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(@"Server =.;Database =Login;Encrypt =False;Integrated Security=True");

        public DbSet<RegisterAccountForm> Login { get; set; }
    }
}
