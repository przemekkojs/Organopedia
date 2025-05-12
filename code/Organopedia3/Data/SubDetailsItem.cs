namespace Organopedia3.Data
{
    public record SubDetailsItem
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<MediaItem> MediaItems { get; set; } = [];
    }
}
