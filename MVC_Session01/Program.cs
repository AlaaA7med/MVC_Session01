namespace MVC_Session01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Services

            builder.Services.AddControllersWithViews(); 

            var app = builder.Build();

            // MiddleWare

            //----------------------
            //app.MapGet("/", () => "Hello World!");
            ////app.MapPost("/", () => "Hello World!");

            ////app.MapGet("/Login", () => "U R Signed in! ");
            //app.MapGet("/Login", SignIn);
            //----------------------
            app.UseStaticFiles();

            // MVC 

            app.MapControllerRoute(
                name:"default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );


            app.Run();
        }
        public static string SignIn()
        {
            return "U R Signed in! ";
        }
    }
}
