// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The current veteran status of the person.
    /// </summary>
    [DataContract]
    public class PersonVeteranStatusDtoProperty
    {
        /// <summary>
        /// The name of a higher level veteran status category to which the status belongs.
        /// </summary>
        [JsonProperty("category")]
        public VeteranStatusesCategory? VeteranStatusCategory { get; set; }

        /// <summary>
        /// Globally unique identifier for veteran status code.
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}