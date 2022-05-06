//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The grade options associated with the section registration. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionRegistrationsGradeOptionsGrades
    {
        /// <summary>
        /// The grade that may be awarded to the student by the instructor.
        /// /grade-definitions/{id}
        /// </summary>

        [JsonProperty("grade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Grade { get; set; }

        /// <summary>
        /// The grade value.
        /// </summary>

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// The incomplete grade details associated with the grade.
        /// </summary>

        [JsonProperty("incompleteGradeDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IncompleteGradeDetailsDtoProperty IncompleteGradeDetails { get; set; }

        /// <summary>
        /// An indicator whether the last date of attendance is required for the grade.
        /// </summary>

        [JsonProperty("lastDateOfAttendanceRequiredness", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RequiredNotRequired LastDateOfAttendanceRequiredness { get; set; }
    }
}