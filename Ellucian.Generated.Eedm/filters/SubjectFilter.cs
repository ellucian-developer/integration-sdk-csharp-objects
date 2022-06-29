// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Subject named query
    /// </summary>
    public class SubjectFilter
    {
        /// <summary>
        /// subject
        /// </summary>        
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        [FilterProperty("subject")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 SubjectName { get; set; }
    }
}
