//Copyright 2017-2019 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Decisions made on admission applications. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AdmissionDecisions_V11_1_0 : BaseModel2
    {
        /// <summary>
        /// The admission application on which this decision was made.
        /// </summary>       
        [JsonProperty("application")]
        [FilterProperty("criteria")]
        public GuidObject2 Application { get; set; }

        /// <summary>
        /// The type of decision on the admission application.
        /// </summary>     
        [JsonProperty("decisionType")]
        public GuidObject2 DecisionType { get; set; }

        /// <summary>
        /// The date of the decision on the admission application.
        /// </summary> 
        [JsonProperty("decidedOn")]
        [FilterProperty("criteria", new string[] { "$eq", "$gte", "$lte" })]
        public DateTimeOffset DecidedOn { get; set; }

    }
}         