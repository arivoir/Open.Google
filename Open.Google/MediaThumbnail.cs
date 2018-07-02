using System.Xml.Linq;

namespace Open.Google
{
    public class MediaThumbnail
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public static MediaThumbnail Parse(XElement element)
        {
            var url = element.Attribute("url");
            var width = element.Attribute("width");
            var height = element.Attribute("height");

            return new MediaThumbnail
            {
                Url = url.Value,
                Width = int.Parse(width.Value),
                Height = int.Parse(height.Value),
            };
        }
    }
}
