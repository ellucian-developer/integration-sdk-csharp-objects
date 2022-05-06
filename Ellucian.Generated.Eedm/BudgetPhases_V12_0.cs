//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information on versions of working or final budgets. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BudgetPhases_V12_0 : CodeItem2
    {
        /// <summary>
        /// The budget code with which the budget phase is associated.
        /// </summary>
        [JsonProperty("budgetCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 BudgetCode { get; set; }

        /// <summary>
        /// The status of the budget phase.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OpenStatus Status { get; set; }

        /// <summary>
        /// The phase on which the budget phase is based.
        /// </summary>
        [JsonProperty("basePhase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 BasePhase { get; set; }

    }
}
