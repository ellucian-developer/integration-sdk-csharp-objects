//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The default pay period work hours for positions associated with the pay class.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PayClassHoursPerPeriodDtoProperty
    {
        /// <summary>
        /// The default work hours in the specified time period.
        /// </summary>
        [JsonProperty("hours")]
        public decimal Hours { get; set; }

        /// <summary>
        /// The default time period (e.g. day, week, month, etc.).
        /// </summary>
        [JsonProperty("period", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PayClassesPeriod Period { get; set; }

    }
}