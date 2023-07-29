using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Shopping.IdentityServer.ModelDb.Context
{
	public class MySQLContext : IdentityDbContext<ApplicationUser>
	{
		public MySQLContext()
		{

		}
		public MySQLContext(DbContextOptions<MySQLContext> options)
			: base(options) { }
	}
}
