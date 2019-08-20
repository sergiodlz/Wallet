using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Wallet.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        [Authorize(Policy = "AdministratorOnly")]
        [HttpGet, Route("test")]
        public IActionResult Test()
        {
            var userName = User.Identity.Name;
            return Ok($"Super secret content, I hope you've got clearance for this {userName}...");
        }
    }
}