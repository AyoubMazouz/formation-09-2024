using formation.Interfaces;
using formation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace formation.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            var users = await _userService.List();
            return View(users);
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var user = await _userService.FindById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                await _userService.Save(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/SignIn
        public IActionResult SignIn()
        {
            return View();
        }

        // POST: User/SignIn
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> SignIn(string username, string password)
        //{
        //    var user = await _userService.SignInUser(username, password);
        //    if (user == null)
        //    {
        //        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //        return View();
        //    }
        //    // Handle successful sign-in (e.g., set authentication cookie)
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
