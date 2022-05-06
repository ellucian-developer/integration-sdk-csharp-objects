// Copyright 2019 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a phone number.
    /// </summary>
    [DataContract]
    public class PersonMatchRequestPhoneDtoProperty
    {
        /// <summary>
        /// The <see cref="PhoneType">type</see> of phone number
        /// </summary>
        [JsonProperty("type")]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The phone number
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }
    }
}