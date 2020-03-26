using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebApplication1.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateUserAndRoles();
        }
        public void CreateUserAndRoles() 
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (!roleManager.RoleExists("Superadmin")) 
            {
                var role = new IdentityRole("SuperAdmin");
                roleManager.Create(role);
                var user = new ApplicationUser();
                user.UserName = "Admin@gmail.com";
                user.Email = "Admin@gmail.com";
                string pwd = "Admin123";
          }
        }
    }
}
