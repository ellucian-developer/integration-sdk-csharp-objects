//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The assignment of a student to institution provided housing. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HousingAssignmentAdditionalChargeProperty
    {
        /// <summary>
        /// The accounting code assiciated with the additional charge.
        /// </summary>
        [JsonProperty("accountingCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AccountingCode { get; set; }

        /// <summary>
        /// The override rate for the room assignment.
        /// </summary>
        [JsonProperty("charge", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingAssignmentRateChargeProperty HousingAssignmentRate { get; set; }
    }
}
