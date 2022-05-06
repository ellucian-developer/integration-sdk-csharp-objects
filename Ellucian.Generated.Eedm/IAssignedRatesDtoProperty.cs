// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm.Interfaces
{
    /// <summary>
    /// Information about rate for student meal plans
    /// </summary>
    public interface IAssignedRatesDtoProperty
    {
        /// <summary>
        /// The number of periods for the rate.
        /// </summary>
        [JsonProperty("numberOfPeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        int? NumberOfPeriods { get; set; }

    }
}
