//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The default incomplete final grade and the extension date associated with the student's grade. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentUnverifiedGradesIncompleteGradeDtoProperty
    {
        /// <summary>
        /// The date after which the default final grade may be applied.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("extensionDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? ExtensionDate { get; set; }

        /// <summary>
        /// The default final grade that is being submitted.
        /// </summary>
        [JsonProperty("finalGrade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 FinalGrade { get; set; }
    }
}