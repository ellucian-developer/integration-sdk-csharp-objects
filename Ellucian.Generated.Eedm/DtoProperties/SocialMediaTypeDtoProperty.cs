// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The social media account at which the unit can be contacted.
    /// </summary>
    [DataContract]
    public class SocialMediaTypeDtoProperty
    {
        /// <summary>
        /// A type of social media account (e.g. 'skype', 'facebook').
        /// </summary>
        [JsonProperty("socialMediaType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SocialMediaTypeCategory? Category { get; set; }

        /// <summary>
        /// The global identifier for the Detail.
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}