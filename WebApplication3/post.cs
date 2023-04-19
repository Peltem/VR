using System.Text.RegularExpressions;

namespace WebApplication3
{
    public static class PostsController
    {
        private static Regex _matchHtmlTags = new Regex("<[^>]*>");
        public static void ConfigurePostsApi(this WebApplication app)
        {
            app.MapPost("/posts", Posts);
        }
        private static async Task<IResult> Posts(HttpContext context, HttpResponse response)
        {
            var form = context.Request.Form;
            //response.Redirect($"/posts/{form["action"]}/{form["id"]}", true, true);
            return Results.Redirect($"/posts/{form["action"]}/{form["id"]}", false, true);
        }
    }
}
