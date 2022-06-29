//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The phone type, number and extension of the contact person. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorContactsPhones
    {

        /// <summary>
        /// The type of phone.
        /// </summary>

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The number assigned to the phone.
        /// </summary>

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// The extension used to connect to the phone when multiple phones share the same primary number.
        /// </summary>

        [JsonProperty("extension", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Extension { get; set; }

    }
}