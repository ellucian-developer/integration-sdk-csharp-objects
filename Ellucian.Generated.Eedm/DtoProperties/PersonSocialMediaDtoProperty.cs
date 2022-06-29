// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The languagues the person has certain degree of proficiency in.
    /// </summary>
    [DataContract]
    public class PersonSocialMediaDtoProperty
    {
        /// <summary>
        /// The Type of the Social Media account
        /// </summary>
        [JsonProperty("type")]
        public PersonSocialMediaType Type { get; set; }

        /// <summary>
        /// Social Media preference indicator.  Only one social media type should be set to primary for a person.
        /// </summary>
        [JsonProperty("preference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonPreference? Preference { get; set; }

        /// <summary>
        /// Handle or Address for this particular Social Media type
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}