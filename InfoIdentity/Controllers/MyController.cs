using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InfoIdentity.Controllers
{
    public class MyController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        private readonly SignInManager<IdentityUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public MyController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }


        public MyController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public MyController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
