using System.Collections.Generic;

namespace Wallet.Data.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public virtual IEnumerable<Account> Accounts { get; set; }
    }
}