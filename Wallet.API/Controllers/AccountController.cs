using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wallet.Data.Entities;
using Wallet.Services.ActionFilters;
using Wallet.Services.Core;
using Wallet.Services.Extensions;
using Wallet.Services.ViewModels;

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
        private readonly IMapper _mapper;

        public AccountController(ILogger<AccountController> logger,
            IEntityService<Account> accountService,
            IEntityService<Record> recordService,
            IMapper mapper)
        {
            _logger = logger;
            _accountService = accountService;
            _recordService = recordService;
            _mapper = mapper;
        }

        // GET: api/Account
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Guid.TryParse(User.Claims.FirstOrDefault(p => p.Type.Equals("Id")).Value, out Guid id);
            var accounts = await _accountService.FindByConditionAndIncludeAsync(a => a.UserId.Equals(id), a => a.Type);
            IEnumerable<AccountVM> accountVMs = _mapper.Map<IEnumerable<AccountVM>>(accounts);
            return Ok(accountVMs);
        }

        // GET: api/Account/5
        [HttpGet("{id}", Name = "Get")]
        [ServiceFilter(typeof(ValidateEntityExistsAsync<Account>))]
        public async Task<IActionResult> Get(Guid id)
        {
            var account = HttpContext.Items["entity"] as Account;
            account.Records = await _recordService.FindByConditionAndIncludeAsync(r => r.AccountId.Equals(id), r => r.SubCategory, r => r.Type);
            AccountVM accountVM = _mapper.Map<AccountVM>(account);
            return Ok(accountVM);
        }

        // POST: api/Account
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Post([FromBody] AccountCreateVM accountVM)
        {
            Account account = _mapper.Map<Account>(accountVM);
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
