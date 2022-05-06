//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The salary or wages earned.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ExternalEmploymentsCompensation
    {
        /// <summary>
        /// The amount per time period.
        /// </summary>

        [JsonProperty("rate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty Rate { get; set; }

        /// <summary>
        /// The time period of the salary.
        /// </summary>

        [JsonProperty("period", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Period { get; set; }
    }
}
