//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The academic credentials the student has been awarded. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicCredentials_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The student who has been awarded an academic credential.
        /// </summary>

        [JsonProperty("student", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The student academic program associated with the academic credential.
        /// </summary>

        [JsonProperty("studentProgram", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 StudentProgram { get; set; }

        /// <summary>
        /// The academic level associated with the academic credential.
        /// </summary>

        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The academic credentials awarded to the student.
        /// </summary>

        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<StudentAcademicCredentialsCredentials> Credentials { get; set; }

        /// <summary>
        /// The disciplines associated with the awarded credentials.
        /// </summary>

        [JsonProperty("disciplines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Disciplines { get; set; }

        /// <summary>
        /// A list of academic recognitions the student has received.
        /// </summary>

        [JsonProperty("recognitions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Recognitions { get; set; }

        /// <summary>
        /// The date the student graduated from the program.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("graduatedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria", new string[] { "$eq", "$gte", "$lte" })]
        public DateTime? GraduatedOn { get; set; }

        /// <summary>
        /// The year the student graduated from the program.
        /// </summary>        
        [JsonProperty("graduationYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GraduationYear { get; set; }

        /// <summary>
        /// The title of the thesis (dissertation).
        /// </summary>

        [JsonProperty("thesisTitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThesisTitle { get; set; }

        /// <summary>
        /// The academic period in which the student graduated.
        /// </summary>

        [JsonProperty("graduationAcademicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 GraduationAcademicPeriod { get; set; }
    }
}