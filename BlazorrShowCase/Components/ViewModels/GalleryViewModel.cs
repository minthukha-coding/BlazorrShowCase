using BlazorrShowCase.Components.Models;

namespace BlazorrShowCase.Components.ViewModels
{

    public class GalleryViewModel
    {
        public List<GalleryImage> Images { get; } = Enumerable.Range(1, 8)
            .Select(i => new GalleryImage { ImageUrl = $"https://picsum.photos/300/300?g={i}" })
            .ToList();
    }
}
