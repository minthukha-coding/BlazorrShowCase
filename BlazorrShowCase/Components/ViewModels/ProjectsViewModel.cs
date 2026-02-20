using BlazorrShowCase.Components.Models;
using BlazorrShowCase.Components.Services;

namespace BlazorrShowCase.Components.ViewModels
{

    public class ProjectsViewModel
    {
        private readonly IProjectService _service;
        public List<Project> Projects { get; private set; } = new();

        public ProjectsViewModel(IProjectService service)
        {
            _service = service;
        }

        public async Task LoadAsync()
        {
            Projects = await _service.GetAllAsync();
        }
    }
}
