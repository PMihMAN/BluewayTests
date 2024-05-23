using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BluewayTests;

public class ReadableBodyStreamAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        // For ASP.NET 3.1
        context.HttpContext.Request.EnableBuffering();
    }
}