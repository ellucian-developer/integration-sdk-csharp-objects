//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Budget details separated by line. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BudgetPhaseLineItems_V12_0 : BaseModel2
    {
        /// <summary>
        /// The budget phase to which the line item belongs.
        /// </summary>
        [JsonProperty("budgetPhase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 BudgetPhase { get; set; }

        /// <summary>
        /// The accounting string details of the line item.
        /// </summary>
        [JsonProperty("accountingStringComponentValues", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<GuidObject2> AccountingStringComponentValues { get; set; }

        /// <summary>
        /// The amount associated with the line item.
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty Amount { get; set; }

        /// <summary>
        /// The comment associated with the line item.
        /// </summary>
        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comment { get; set; }

    }
}