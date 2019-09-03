using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wallet.Data.Entities;
using Wallet.Services.ActionFilters;
using Wallet.Services.Core;
using Wallet.Services.Extensions;

namespace Wallet.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IEntityService<Account> _accountService;
        private readonly IEntityService<Record> _recordService;

        public AccountController(ILogger<AccountController> logger,
            IEntityService<Account> accountService,
            IEntityService<Record> recordService)
        {
            _logger = logger;
            _accountService = accountService;
            _recordService = recordService;
        }

        // GET: api/Account
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Guid.TryParse(User.Claims.FirstOrDefault(p => p.Type.Equals("Id")).Value, out Guid id);
            var accounts = await _accountService.FindByConditionAndIncludeAsync(a => a.UserId.Equals(id), a => a.Type);
            return Ok(accounts);
        }

        // GET: api/Account/5
        [HttpGet("{id}", Name = "Get")]
        [ServiceFilter(typeof(ValidateEntityExistsAsync<Account>))]
        public async Task<IActionResult> Get(Guid id)
        {
            var account = HttpContext.Items["entity"] as Account;
            account.Records = await _recordService.FindByConditionAndIncludeAsync(r => r.AccountId.Equals(id), r => r.SubCategory, r => r.Type);
            return Ok(account);
        }

        // POST: api/Account
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Post([FromBody] Account account)
        {
            return Ok(await _accountService.CreateAsync(account));
        }

        // PUT: api/Account/5
        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateEntityExistsAsync<Account>))]
        public async Task<IActionResult> Put(Guid id, [FromBody] Account accountVM)
        {
            var account = HttpContext.Items["entity"] as Account;
            account.Map(accountVM, User.Identity.Name);
            await _accountService.UpdateAsync(account);

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateEntityExistsAsync<Account>))]
        public async Task<IActionResult> Delete(Guid id)
        {
            var account = HttpContext.Items["entity"] as Account;
            await _accountService.DisableAsync(account);

            return NoContent();
        }
    }
}
