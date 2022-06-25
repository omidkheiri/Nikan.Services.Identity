using Nikan.Services.Identity.Admin.Api.ExceptionHandling;

namespace Nikan.Services.Identity.Admin.Api.Resources
{
  public class ApiErrorResources : IApiErrorResources
  {
    public virtual ApiError CannotSetId()
    {
      return new ApiError
      {
        Code = nameof(CannotSetId),
        Description = ApiErrorResource.CannotSetId
      };
    }
  }
}







