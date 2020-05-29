namespace EstateApp.Data.DatabaseContext.AuthenticationDbContext
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext>options)
        : base(options)
        {
            
        }
    }
}