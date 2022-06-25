using Nikan.Services.Identity.STS.Identity.Configuration.Interfaces;
using Skoruba.IdentityServer4.Shared.Configuration.Configuration.Identity;

namespace Nikan.Services.Identity.STS.Identity.Configuration
{
  public class RootConfiguration : IRootConfiguration
  {
    public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
    public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
  }
}







