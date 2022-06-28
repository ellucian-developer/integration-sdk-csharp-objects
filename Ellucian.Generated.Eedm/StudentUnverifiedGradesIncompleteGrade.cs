//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The grade and/or last attendance details. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentUnverifiedGradesIncompleteGrade
    {
        /// <summary>
        /// The default final grade.
        /// </summary>
        [JsonProperty("finalGrade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 FinalGrade { get; set; }

        /// <summary>
        /// The date after which the default final grade may be applied.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("extensionDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? ExtensionDate { get; set; }

    }
}
