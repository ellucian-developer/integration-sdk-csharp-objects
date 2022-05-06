//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The grades eligible to be displayed on the student's transcript. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTranscriptGradesOptions_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The grading options associated with the student transcript grade.
        /// </summary>
        [JsonProperty("grades", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentTranscriptGradesOptionsGradesDtoProperty> Grades { get; set; }

        /// <summary>
        /// The grading scheme used to award the student their grade.
        /// </summary>
        [JsonProperty("gradeScheme", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentTranscriptGradesOptionsGradeSchemeDtoProperty GradeScheme { get; set; }        
    }
}