using BlazorrShowCase.Components.Models;

namespace BlazorrShowCase.Components.Services
{

    public class MockProjectService : IProjectService
    {
        private static readonly List<Project> Projects = new()
    {
        new Project { Title = "Clean Water Initiative", Description = "Providing access to safe drinking water.", ImageUrl = "https://picsum.photos/400/250?1" },
        new Project { Title = "Education for All", Description = "Supporting education in rural areas.", ImageUrl = "https://picsum.photos/400/250?2" },
        new Project { Title = "Healthcare Outreach", Description = "Mobile clinics and basic healthcare.", ImageUrl = "https://picsum.photos/400/250?3" },
        new Project { Title = "Women Empowerment", Description = "Skill development programs.", ImageUrl = "https://picsum.photos/400/250?4" }
    };

        public Task<List<Project>> GetHighlightedAsync() =>
            Task.FromResult(Projects.Take(3).ToList());

        public Task<List<Project>> GetAllAsync() =>
            Task.FromResult(Projects);
    }
}
