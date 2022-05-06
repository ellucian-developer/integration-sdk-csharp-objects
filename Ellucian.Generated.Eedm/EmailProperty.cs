// Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The email type and address of the contact person.
    /// </summary>
    [DataContract]
    public class EmailProperty
    {
        /// <summary>
        /// The type of email.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 EmailType { get; set; }

        /// <summary>
        /// Globally unique identifier for email type
        /// </summary>
        [JsonProperty("address")]
        public string EmailAddress { get; set; }
    }
}