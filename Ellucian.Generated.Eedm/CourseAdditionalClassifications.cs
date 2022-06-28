//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Additional classifications associated with the course.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CourseAdditionalClassifications
    {
        /// <summary>
        /// The CIP code associated with the course.
        /// </summary>

        [JsonProperty("cipCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 CipCode { get; set; }

    }
}
