// Copyright 2016-2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The amount of salary for the job.
    /// </summary>
    [DataContract]
    public class SalaryAmountDtoProperty
    {      
        /// <summary>
        /// The amount awarded per time period.
        /// </summary>
        [JsonProperty("rate")]
        public Amount2DtoProperty Rate { get; set; }

        /// <summary>
        /// The time period of the salary
        /// </summary>
        [JsonProperty("period")]
        public SalaryPeriod Period { get; set; }
    }
}