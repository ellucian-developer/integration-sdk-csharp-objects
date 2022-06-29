// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A type of email for a person.  Includes a standard type (e.g. 'personal', 'business') and an optional detail id.
    /// </summary>
    [DataContract]
    public class PersonEmailTypeDtoProperty
    {
        /// <summary>
        /// A mapping to a standard type for the email type.
        /// </summary>
        [JsonProperty("emailType")]
        public EmailTypeList? EmailType { get; set; }

        /// <summary>
        /// Globally unique identifier for email type
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}