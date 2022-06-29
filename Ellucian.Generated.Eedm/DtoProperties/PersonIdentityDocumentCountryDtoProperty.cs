// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Country property for Identity Documents on Person
    /// </summary>
    [DataContract]
    public class PersonIdentityDocumentCountryDtoProperty
    {
        /// <summary>
        /// The ISO 639-3 alpha-3 languague code
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IsoCode? Code { get; set; }

        /// <summary>
        /// The code of a region within the country
        /// </summary>
        [JsonProperty("region", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AddressRegion Region { get; set; }
    }
}
