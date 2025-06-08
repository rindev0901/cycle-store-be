using cycle_store_be.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Supabase;

namespace cycle_store_be.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly Client _supabaseClient;
        public AccountController([FromServices] Client supabaseClient) 
        {
            _supabaseClient = supabaseClient;
        }

        [HttpGet]
        [Route("profiles")]
        public async Task<IActionResult> GetListAccounts()
        {
            var accountResponse = await _supabaseClient
                                    .From<AccountEntity>()
                                    .Select("*, users(*)")
                                    .Get();

            var listAccounts = accountResponse.Models
                                    .ToList();

            return StatusCode(200, listAccounts);
        }
    }
}
