// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The withholding frequency associated with the deduction type
    /// </summary>
    [DataContract]
    public class DeductionTypeWithholdingFrequencyDtoProperty
    {
        /// <summary>
        /// The number of cycles per year.
        /// </summary>
        [JsonProperty("cyclesPerYear")]
        public decimal CyclesPerYear { get; set; }

    }
}