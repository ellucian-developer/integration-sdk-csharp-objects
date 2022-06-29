// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Student named query
    /// </summary>
    [DataContract]
    public class StudentFilter
    {
        /// <summary>
        /// Student filter
        /// </summary>        
        //[JsonProperty("section")]
        [DataMember(Name = "student", EmitDefaultValue = false)]
        [FilterProperty("student")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Student { get; set; }
    }
}
