// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The social media account at which the unit can be contacted.
    /// </summary>
    [DataContract]
    public class PersonSocialMediaType
    {
        /// <summary>
        /// Social Media Type category.
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