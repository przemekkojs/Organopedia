namespace Organopedia3.Data
{
    public record class MediaItem
    {
        public string Source { get; set; } = "";
        public bool IsVideo { get; set; } = false;
    }
}
