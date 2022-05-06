//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The contacts associated with a vendor. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorContact
    {
        /// <summary>
        /// The detail of the person who is the contact.
        /// </summary>

        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The name, phone, and email of the person who is the vendor contact.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VendorPersonContact Person { get; set; }

    }
}