using ProfileService.Models;
using Microsoft.EntityFrameworkCore;

namespace ProfileService.Services
{
    public class UserProfileService 
    {
        private readonly ProfileDbContext _context;

        public UserProfileService(ProfileDbContext context)
        {
            _context = context;
        }

        public async Task<List<AppUser>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<AppUser?> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FindAsync(email);
        }

        public async Task AddUserAsync(AppUser user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(AppUser user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(string email)
        {
            var user = await _context.Users.FindAsync(email);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}