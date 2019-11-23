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
                        Id = Guid.Parse("eca283c0-9446-410d-abd0-642322e337c3"),
                        InitialBalance = 0,
                        Name = "Cash",
                        TypeId = Guid.Parse("179e86ae-c358-48c4-bf6d-76af86ecf625"),
                        UserId = Guid.Parse("68b19f86-e52e-4b24-9003-06b6ecad4201")
                    },
                    new AccountVM()
                    {
                        Color = "#0000",
                        Description = "Account for Bancolombia debit card",
                        Id = Guid.Parse("39537aa5-2f5f-47df-8241-cfdbb2348168"),
                        InitialBalance = 0,
                        Name = "Bancolombia",
                        TypeId = Guid.Parse("179e86ae-c358-48c4-bf6d-76af86ecf625"),
                        UserId =  Guid.Parse("68b19f86-e52e-4b24-9003-06b6ecad4201")
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