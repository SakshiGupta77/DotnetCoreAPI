using Custom_MiddelWare_Contacts.Repository;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
namespace Custom_MiddelWare_Contacts.MiddleWare
{
    public class UserKeyValidator
    {

        private readonly RequestDelegate _next;
        private IContactsRepository ContactsRepo { get; set; }
        public UserKeyValidator(RequestDelegate next)
        {
            _next = next;
            ContactsRepo = new ContactsRepository();
        }
        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.Keys.Contains("user-key"))
            {
                context.Response.StatusCode = 400; //Bad Request                
                await context.Response.WriteAsync("User Key is missing");
                return;
            }
            else
            {
                if(!ContactsRepo.CheckValidUserKey(context.Request.Headers["user-key"]))
                {
                    context.Response.StatusCode = 401; //UnAuthorized
                    await context.Response.WriteAsync("Invalid User Key");
                    return;
                }
            }

            await _next.Invoke(context);
        }
    }
    // public static class RequestCultureMiddlewareExtensions
    // {
    //     public static IApplicationBuilder SecurityKeyForContact(this IApplicationBuilder builder)
    //     {
    //       builder.UseMiddleware<UserKeyValidator>();
    //         return builder;
    //     }
    // }
}