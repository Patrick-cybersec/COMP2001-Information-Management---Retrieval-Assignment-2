using Microsoft.AspNetCore.Mvc;
using ProfileService.Services;
using ProfileService.Models; 

namespace ProfileService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserProfileService _userProfileService; 

        public UsersController(UserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userProfileService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] AppUser user)
        {
            await _userProfileService.AddUserAsync(user);
            return CreatedAtAction(nameof(GetUserByEmail), new { email = user.Email }, user);
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var user = await _userProfileService.GetUserByEmailAsync(email);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPut("{email}")]
        public async Task<IActionResult> UpdateUser(string email, [FromBody] AppUser updatedUser)
        {
            if (email != updatedUser.Email)
                return BadRequest();

            await _userProfileService.UpdateUserAsync(updatedUser);
            return NoContent();
        }

        [HttpDelete("{email}")]
        public async Task<IActionResult> DeleteUser(string email)
        {
            await _userProfileService.DeleteUserAsync(email);
            return NoContent();
        }
    }
}