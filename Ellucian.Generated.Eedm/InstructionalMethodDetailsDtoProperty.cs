// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Instructional Methods Details DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructionalMethodDetailsDtoProperty
    {
        /// <summary>
        /// The methods, styles, or formats in which the section of a course is taught (for example, 'Lecture', 'Lab').
        /// </summary>
        [JsonProperty("instructionalMethod")]
        public GuidObject2 InstructionalMethod { get; set; }

        /// <summary>
        /// The contact hours that may be assigned ot the section
        /// </summary>
        [JsonProperty("contactHours", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public QuantityIntervalDtoProperty ContactHours { get; set; }

        /// <summary>
        /// The lab hours that may be assigned to the section
        /// </summary>
        [JsonProperty("labHours", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public QuantityIntervalDtoProperty LabHours { get; set; }

        /// <summary>
        /// The lecture hours that may be assigned to the section. n
        /// </summary>
        [JsonProperty("lectureHours", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public QuantityIntervalDtoProperty LectureHours { get; set; }

    }
}