using BlazorrShowCase.Components.Models;
using BlazorrShowCase.Components.Services;

namespace BlazorrShowCase.Components.ViewModels
{

    public class HomeViewModel
    {
        private readonly IProjectService _service;
        public List<Project> Highlighted { get; private set; } = new();

        public HomeViewModel(IProjectService service)
        {
            _service = service;
        }

        public async Task LoadAsync()
        {
            Highlighted = await _service.GetHighlightedAsync();
        }
    }
}
