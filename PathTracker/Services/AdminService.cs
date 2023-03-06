using Microsoft.AspNetCore.Authorization;
using PathTracker.Data;
using PathTracker.Models;

namespace PathTracker.Services
{
    [Authorize]
    public class AdminService
    {
        private readonly ApplicationDbContext _dbContext;

        public AdminService(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }   
        public async Task<bool> AddCoursePath(CoursePath coursePath)
        {
            coursePath.Id = 0;
            _dbContext.Add(coursePath);
            return true;
        }
    }
}
