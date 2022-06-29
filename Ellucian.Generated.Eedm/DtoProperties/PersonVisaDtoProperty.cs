// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The visa status of the person with regards to the country where a given institution is located.
    /// </summary>
    [DataContract]
    public class PersonVisaDtoProperty
    {
        /// <summary>
        /// A global category of visa types.
        /// </summary>
        [JsonProperty("category")]
        public VisaTypeCategory Category { get; set; }

        /// <summary>
        /// A custom visa type
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The last known status of a visa
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VisaStatus? Status { get; set; }

        /// <summary>
        /// The start date of the visa
        /// </summary>
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The end date of the visa
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }
    }
}