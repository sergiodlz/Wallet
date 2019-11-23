using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Wallet.Services.ViewModels;

namespace Wallet.Web.Controllers
{
    public class RecordController : Controller
    {
        public RecordController()
        {
        }

        public IActionResult Index()
        {
            List<RecordVM> records = new List<RecordVM>()
            {
                new RecordVM()
                {
                    AccountId = Guid.Parse("39537aa5-2f5f-47df-8241-cfdbb2348168"),
                    Account = "Bancolombia",
                    Amount = 250000,
                    Date = DateTime.Parse("2019-09-19T13:19:00"),
                    Description = "Luz",
                    Id = Guid.NewGuid(),
                    SubCategory = "SubCategory Test",
                    SubCategoryId = Guid.Parse("6b673b39-4d34-41e9-8409-d260b566f389"),
                    Type = "Expense",
                    TypeId = Guid.Parse("1503f1a2-aeb3-42aa-a804-805320abb501")
                },
                new RecordVM()
                {
                    AccountId = Guid.Parse("39537aa5-2f5f-47df-8241-cfdbb2348168"),
                    Account = "Bancolombia",
                    Amount = 1000000,
                    Date = DateTime.Parse("2019-09-19T13:19:00"),
                    Description = "Arriendo",
                    Id = Guid.NewGuid(),
                    SubCategory = "SubCategory Test",
                    SubCategoryId = Guid.Parse("6b673b39-4d34-41e9-8409-d260b566f389"),
                    Type = "Expense",
                    TypeId = Guid.Parse("1503f1a2-aeb3-42aa-a804-805320abb501")
                },
                new RecordVM()
                {
                    AccountId = Guid.Parse("39537aa5-2f5f-47df-8241-cfdbb2348168"),
                    Account = "Bancolombia",
                    Amount = 90000,
                    Date = DateTime.Parse("2019-09-19T13:19:00"),
                    Description = "Agua",
                    Id = Guid.NewGuid(),
                    SubCategory = "SubCategory Test",
                    SubCategoryId = Guid.Parse("6b673b39-4d34-41e9-8409-d260b566f389"),
                    Type = "Expense",
                    TypeId = Guid.Parse("1503f1a2-aeb3-42aa-a804-805320abb501")
                },
                new RecordVM()
                {
                    AccountId = Guid.Parse("39537aa5-2f5f-47df-8241-cfdbb2348168"),
                    Account = "Bancolombia",
                    Amount = 24000,
                    Date = DateTime.Parse("2019-09-19T13:19:00"),
                    Description = "Gas",
                    Id = Guid.NewGuid(),
                    SubCategory = "SubCategory Test",
                    SubCategoryId = Guid.Parse("6b673b39-4d34-41e9-8409-d260b566f389"),
                    Type = "Expense",
                    TypeId = Guid.Parse("1503f1a2-aeb3-42aa-a804-805320abb501")
                }
            };

            return View(records);
        }
    }
}