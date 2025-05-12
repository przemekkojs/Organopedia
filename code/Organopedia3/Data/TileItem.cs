namespace Organopedia3.Data
{
    public record TileItem
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImagePath { get; set; } = "";
        public string Route { get; set; } = "";
        public string Param { get; set; } = "";
    }
}
