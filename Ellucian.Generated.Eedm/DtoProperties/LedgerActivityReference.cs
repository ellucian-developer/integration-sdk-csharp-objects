//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person, organization, or institution associated with the activity.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]

    public class LedgerActivityReference
    {
        /// <summary>
        /// The person, organization, or institution associated with the activity.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The organization associated with the activity.
        /// </summary>

        [JsonProperty("organization", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Organization { get; set; }

        /// <summary>
        /// The institution associated with the activity.
        /// </summary>

        [JsonProperty("institution", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Institution { get; set; }
    }
}