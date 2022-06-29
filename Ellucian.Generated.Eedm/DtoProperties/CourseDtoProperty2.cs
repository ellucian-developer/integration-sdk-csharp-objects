// Copyright 2015-2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Course DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CourseDtoProperty2
    {
        /// <summary>
        /// Id of the InstructionalPlatform
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The course titles details.
        /// </summary>

        [JsonProperty("titles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CoursesTitlesDtoProperty2> Titles { get; set; }

        /// <summary>
        /// A numbering scheme to distinguish different Courses
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// A subject for the Course
        /// </summary>
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SubjectDtoProperty Subject { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public CourseDtoProperty2()
        {
            Detail = new GuidObject2();
           
        }
    }
}