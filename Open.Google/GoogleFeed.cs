using System.Collections.Generic;

namespace Open.Google
{
    public class GoogleFeed<T>
    {
        public GoogleFeed()
        {
            TotalResults = 0;
            StartIndex = 0;
            ItemsPerPage = 0;
            Items = new List<T>();
        }

        public GoogleFeed(string icon, Author author, int totalResults, int startIndex, int itemsPerPage, List<T> items)
        {
            Icon = icon;
            Author = author;
            TotalResults = totalResults;
            StartIndex = startIndex;
            ItemsPerPage = itemsPerPage;
            Items = items;
        }

        public string Icon { get; private set; }
        public Author Author { get; private set; }
        public int TotalResults { get; private set; }
        public int StartIndex { get; private set; }
        public int ItemsPerPage { get; private set; }
        public List<T> Items { get; private set; }
    }
}
