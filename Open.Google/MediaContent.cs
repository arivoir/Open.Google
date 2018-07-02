using System.Xml.Linq;

namespace Open.Google
{
    public class MediaContent
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Type { get; set; }

        public static MediaContent Parse(XElement element)
        {
            var url = element.Attribute("url");
            var width = element.Attribute("width");
            var height = element.Attribute("height");
            var type = element.Attribute("type");

            return new MediaContent
            {
                Url = url.Value,
                Width = width == null ? 0 : int.Parse(width.Value),
                Height = height == null ? 0 : int.Parse(height.Value),
                Type = type.Value,
            };
        }
    }
}
