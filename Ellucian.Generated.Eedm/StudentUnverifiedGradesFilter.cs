// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Student Unverified Grades filters
    /// </summary>
    [DataContract]
    public class StudentUnverifiedGradesFilter
    {
        /// <summary>
        /// The section associated with the grade.
        /// </summary>        
        //[JsonProperty("section")]
        [DataMember(Name = "section", EmitDefaultValue = false)]
        [FilterProperty("section")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Section { get; set; }
    }
}
