using CollectTrash.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollectTrash.Startup))]
namespace CollectTrash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var Employee = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var User = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!Employee.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                Employee.Create(role);
            }

            //if (!User.
            //{
            //    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
            //    role.Name = "Customer";
            //    User.Create(role);
            //}
        }
    }
}
