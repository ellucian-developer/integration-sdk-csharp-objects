// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a email addresses for Person Matching.
    /// </summary>
    [DataContract]
    public class PersonMatchingRequestEmailDtoProperty
    {
        /// <summary>
        /// The type of email
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// An email address for the person.
        /// </summary>
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
    }
}