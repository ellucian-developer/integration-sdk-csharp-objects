// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Section Registration Interval DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionRegistrationIntervalDtoProperty
    {
        /// <summary>
        /// Registration interval unit
        /// </summary>
        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Include)]
        public SectionWaitlistRegistrationIntervalUnit? Unit { get; set; }

        /// <summary>
        /// Registration interval value
        /// </summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Value { get; set; }
    }
}
