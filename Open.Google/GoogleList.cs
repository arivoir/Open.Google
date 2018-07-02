using System.Runtime.Serialization;

namespace Open.Google
{
    [DataContract]
    public class GoogleList<T>
    {
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public string Kind { get; set; }
        [DataMember(Name = "etag", EmitDefaultValue = false)]
        public string ETag { get; set; }
        [DataMember(Name = "nextPageToken", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }
        [DataMember(Name = "pageInfo", EmitDefaultValue = false)]
        public PageInfo PageInfo { get; set; }
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public T[] Items { get; set; }
    }

    [DataContract]
    public class PageInfo
    {
        [DataMember(Name = "totalResults", EmitDefaultValue = false)]
        public int TotalResults { get; set; }
        [DataMember(Name = "resultsPerPage", EmitDefaultValue = false)]
        public int ResultsPerPage { get; set; }

        public int StartIndex { get; set; }
    }
}
