// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The methods, styles, or formats in which the course is taught (for example, 'Lecture', 'Lab'). 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructionalMethodDetail
    {
        /// <summary>
        /// The method, style, or format in which the course is taught (for example, 'Lecture', 'Lab').
        /// </summary>
        [JsonProperty("instructionalMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 InstructionalMethod { get; set; }

        /// <summary>
        /// The delivery method used for instruction.
        /// </summary>
        [JsonProperty("instructionalDeliveryMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 InstructionalDeliveryMethod { get; set; }
    }
}