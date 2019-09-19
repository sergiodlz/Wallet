using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallet.Data.Entities;
using Wallet.Services.ActionFilters;
using Wallet.Services.Core;
using Wallet.Services.ViewModels;

namespace Wallet.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IEntityService<Record> _recordService;
        private readonly IEntityService<Account> _accountService;
        private readonly IMapper _mapper;

        public RecordController(
            IEntityService<Record> recordService,
            IEntityService<Account> accountService,
            IMapper mapper)
        {
            _recordService = recordService;
            _accountService = accountService;
            _mapper = mapper;
        }

        // GET: api/Record
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Guid.TryParse(User.Claims.FirstOrDefault(p => p.Type.Equals("Id")).Value, out Guid id);
            var accounts = (await _accountService.FindByConditionAsync(a => a.UserId.Equals(id))).Select(a => a.Id);
            var records = await _recordService.FindByConditionAndIncludeAsync(
                r => accounts.Contains(r.AccountId), 
                r => r.SubCategory, 
                r => r.Type,
                r => r.RecordLabels);

            var recordVMs = _mapper.Map<IEnumerable<RecordVM>>(records);
            return Ok(recordVMs);
        }

        // GET: api/Record/5
        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidateEntityExistsAsync<Record>))]
        public async Task<IActionResult> Get(Guid id)
        {
            var record = await _recordService.GetByIdAndIncludeAsync(id, r => r.SubCategory, r => r.Type, r => r.Account);
            var recordVM = _mapper.Map<RecordVM>(record);
            return Ok(recordVM);
        }

        // POST: api/Record
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Post([FromBody] RecordVM recordVM)
        {
            Record record = _mapper.Map<Record>(recordVM);
            var result = _mapper.Map<RecordVM>(await _recordService.CreateAsync(record));
            return Ok(result);
        }

        // PUT: api/Record/5
        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateEntityExistsAsync<Record>))]
        public async Task<IActionResult> Put(Guid id, [FromBody] RecordVM recordVM)
        {
            var newRecord = _mapper.Map<Record>(recordVM);
            await _recordService.UpdateAsync(newRecord);

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateEntityExistsAsync<Record>))]
        public async Task<IActionResult> Disable(Guid id)
        {
            var record = HttpContext.Items["entity"] as Record;
            await _recordService.DisableAsync(record);

            return NoContent();
        }
    }
}