// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credential DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonMatchRequestAlternativeCredentials
    {
        /// <summary>
        /// The type of alternative credential.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The value of the alternative credential.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

    }
}
