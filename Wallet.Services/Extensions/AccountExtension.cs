using System;
using Wallet.Data.Entities;
using Wallet.Services.ViewModels;

namespace Wallet.Services.Extensions
{
    public static class AccountExtension
    {
        public static void Map(this Account dbAccount, AccountCUDVM account, string modifiedBy)
        {
            dbAccount.Color = account.Color;
            dbAccount.Description = account.Description;
            dbAccount.Icon = account.Icon;
            dbAccount.InitialBalance = account.InitialBalance;
            dbAccount.LastMdifiedBy = modifiedBy;
            dbAccount.ModificationDate = DateTime.UtcNow;
            dbAccount.Name = account.Name;
            dbAccount.TypeId = account.TypeId;
        }
    }
}