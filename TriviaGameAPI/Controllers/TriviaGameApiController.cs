using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TriviaGameAPI.DAL.Models;
using TriviaGameAPI.DAL.Repositories;

namespace TriviaGameAPI.Controllers
{
    [ApiController]
    [Route("/api")]
    public class TriviaGameApiController : ControllerBase
    {
        private readonly ILogger<TriviaGameApiController> _logger;
        private readonly TriviaGameDBContext _dbContext;

        public TriviaGameApiController(ILogger<TriviaGameApiController> logger, TriviaGameDBContext dBContext)
        {
            _logger = logger;
            _dbContext = dBContext;
        }

        [HttpGet(template: "healthcheck", Name = "GetHealthCheck")]
        public string HealthCheck()
        {
            return "OK";
        }

        [HttpGet(template: "Categories", Name = "GetCategories")]
        public Task<List<Category>> Categories()
        {
            return _dbContext.Categories.ToListAsync();
        }

        [HttpGet(template: "Questions/By_Category/{categoryId}", Name = "GetQuestions")]
        public Task<List<Question>> Questions(int categoryId)
        {
            return _dbContext.Question.Where(q => q.CategoryId == categoryId)
                    .ToListAsync();
        }

        [HttpGet(template: "Players/leaderboard/{daysPeriod}", Name = "GetRecentPlayedPlayers")]
        public Task<List<Player>> RecentPlayedPlayers(int daysPeriod)
        {
            if (daysPeriod <= 0)
                return Task.FromResult(new List<Player>());

            return _dbContext.Players.Where(p => p.LastGameDate >= DateTime.Now.AddDays(daysPeriod))
                .ToListAsync();
        }
    }
}
