using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Wallet.Services.ViewModels
{
    public class TokenRequest
    {
        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }

        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}