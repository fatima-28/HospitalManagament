using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
//using Microsoft.Extensions.Identity.Core;

namespace HospitalManagementSystem.Utilities
{
    public class DbInitalizer : IDbInitalizer
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private AppDbContext _context;
        public DbInitalizer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            AppDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;


        }
        public void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count()>0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (!_roleManager.RoleExistsAsync(SiteRoles.Site_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(SiteRoles.Site_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SiteRoles.Site_Patient)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SiteRoles.Site_Doctor)).GetAwaiter().GetResult();
                _userManager.CreateAsync(new AppUser
                {
                    UserName="Ali",
                    Email="ali@gmail.com"

                },"Ali12345_").GetAwaiter().GetResult();
                var user = _context.AppUsers.FirstOrDefault(u => u.Email == "ali@gmail.com");
                if (user!=null)
                {
                    _userManager.AddToRoleAsync(user, SiteRoles.Site_Admin).GetAwaiter().GetResult();
                    
                }
            }


        }
     

    }
}
