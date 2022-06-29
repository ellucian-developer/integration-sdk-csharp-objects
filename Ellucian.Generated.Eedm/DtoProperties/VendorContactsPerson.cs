//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person who is the vendor contact.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorContactsPerson
    {

        /// <summary>
        /// The detail of the person who is the contact.
        /// </summary>

        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The name of the person who is the contact.
        /// </summary>

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

    }
}