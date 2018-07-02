using System.Xml.Linq;

namespace Open.Google
{
    public class Author
    {
        public string Name { get; set; }
        public string Uri { get; set; }

        public static Author Parse(XElement element)
        {
            var name = element.Element(XName.Get("name", Namespaces.AtomNS));
            var uri = element.Element(XName.Get("uri", Namespaces.AtomNS));

            return new Author
            {
                Name = name.Value,
                Uri = uri.Value,
            };
        }
    }
}
