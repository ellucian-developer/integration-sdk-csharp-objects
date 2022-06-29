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
    /// The grading schemes that may be used to award a grade to a student taking this course. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GradeSchemesDtoProperty
    {

        /// <summary>
        /// The grading scheme that may be used to award a grade to a student taking this course.
        /// </summary>

        [JsonProperty("gradeScheme", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 GradeScheme { get; set; }

        /// <summary>
        /// An indicator of whether the grade scheme is used as the default for registration.
        /// </summary>

        [JsonProperty("usage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CoursesUsage? Usage { get; set; }
    }
}
