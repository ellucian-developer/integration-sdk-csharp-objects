//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Various academic periods related to a student's progression in a program. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicProgramsAcademicPeriods
    {
        /// <summary>
        /// The starting academic period of student's enrollment in the program
        /// </summary>

        [JsonProperty("starting", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Starting { get; set; }

        /// <summary>
        /// The academic period in which the student is expected to graduate.
        /// </summary>

        [JsonProperty("expectedGraduation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ExpectedGraduation { get; set; }

        /// <summary>
        /// The academic period in which the student actually graduated.
        /// </summary>

        [JsonProperty("actualGraduation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 ActualGraduation { get; set; }
    }
}

