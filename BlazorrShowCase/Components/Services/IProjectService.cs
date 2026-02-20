using BlazorrShowCase.Components.Models;

namespace BlazorrShowCase.Components.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetHighlightedAsync();
        Task<List<Project>> GetAllAsync();
    }
}
