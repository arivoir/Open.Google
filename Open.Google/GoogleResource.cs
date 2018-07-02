using System.Runtime.Serialization;

namespace Open.Google
{
    [DataContract]
    public class GoogleResource
    {
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public string Kind { get; set; }
        [DataMember(Name = "etag", EmitDefaultValue = false)]
        public string ETag { get; set; }
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
    }
}
