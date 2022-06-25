using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nikan.Services.Identity.Admin.EntityFramework.Shared.DbContexts;
using Nikan.Services.Identity.STS.Identity.Helpers;

namespace Nikan.Services.Identity.STS.Identity.Configuration.Test
{
  public class StartupTest : Startup
  {
    public StartupTest(IWebHostEnvironment environment, IConfiguration configuration) : base(environment, configuration)
    {
    }

    public override void RegisterDbContexts(IServiceCollection services)
    {
      services.RegisterDbContextsStaging<AdminIdentityDbContext, IdentityServerConfigurationDbContext, IdentityServerPersistedGrantDbContext, IdentityServerDataProtectionDbContext>();
    }
  }
}







