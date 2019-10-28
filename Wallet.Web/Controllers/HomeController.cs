using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.ObjectModel;
using Wallet.Services.ViewModels;
using Wallet.Web.ViewModels;

namespace Wallet.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DashboardVM dashboardVM = new DashboardVM()
            {
                Accounts = new Collection<AccountVM>()
                {
                    new AccountVM()
                    {
                        Color = "#0000",
                        Description = "Account for cash control",
                        Id = Guid.NewGuid(),
                        InitialBalance = 0,
                        Name = "Cash",
                        TypeId = Guid.NewGuid(),
                        UserId = Guid.NewGuid()
                    },
                    new AccountVM()
                    {
                        Color = "#0000",
                        Description = "Account for Bancolombia debit card",
                        Id = Guid.NewGuid(),
                        InitialBalance = 0,
                        Name = "Bancolombia",
                        TypeId = Guid.NewGuid(),
                        UserId = Guid.NewGuid()
                    },
                    new AccountVM()
                    {
                        Color = "#0000",
                        Description = "Account for Nequi control",
                        Id = Guid.NewGuid(),
                        InitialBalance = 0,
                        Name = "Nequi",
                        TypeId = Guid.NewGuid(),
                        UserId = Guid.NewGuid()
                    },
                }
            };

            return View(dashboardVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}