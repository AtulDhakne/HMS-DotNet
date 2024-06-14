using HMS.Data;
using HMS.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HMS.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private MyDbContext _dbContext;

        public AdminController(RoleManager<IdentityRole> roleManager, MyDbContext context)
        {
            _roleManager = roleManager;
            _dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleStore rolestore)
        {
            var alreadyAdded = await _roleManager.RoleExistsAsync(rolestore.RoleName);

            if (!alreadyAdded)
            {
                await _roleManager.CreateAsync(new IdentityRole(rolestore.RoleName));
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
