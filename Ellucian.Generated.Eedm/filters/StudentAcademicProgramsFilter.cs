// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// This is an instance of a course, offered once
    /// </summary>
    [DataContract]
    public class StudentAcademicProgramsFilter : BaseModel2
    {
        /// <summary>
        /// Academic Program
        /// </summary>
        [JsonProperty("program", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicProgram { get; set; }

        /// <summary>
        /// Named Query
        /// </summary>
        [DataMember(Name = "student")]
        [FilterProperty("criteria")]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// Section number
        /// </summary>
        [DataMember(Name = "site")]
        [FilterProperty("criteria")]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// Section number
        /// </summary>
        [DataMember(Name = "academicLevel")]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// Section start date
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        [JsonProperty("startOn", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string StartOn { get; set; }

        /// <summary>
        /// Section end date
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        [JsonProperty("endOn", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string EndOn { get; set; }

        /// <summary>
        /// Identifier of a section(Section Name)
        /// </summary>
        [DataMember(Name = "enrollmentStatus")]
        public EnrollmentStatusDetail EnrollmentStatus { get; set; }

        /// <summary>
        /// Title of section
        /// </summary>
        [DataMember(Name = "actualGraduation")]
        [FilterProperty("criteria")]
        public GuidObject2 ActualGraduation { get; set; }

        /// <summary>
        /// Title of section
        /// </summary>
        [DataMember(Name = "academicPeriods")]
        //[FilterProperty("criteria")]
        public StudentAcademicProgramsAcademicPeriods AcademicPeriods { get; set; }

        /// <summary>
        /// Section end date
        /// </summary>
        [DataMember(Name = "graduatedOn", EmitDefaultValue = false)]
        [JsonProperty("graduatedOn", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string GraduatedOn { get; set; }

        /// <summary>
        /// A list of academic levels at which this section is offered
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(ArrayGuidObject2FilterConverter))]
        public List<GuidObject2> Credentials { get; set; }                  

        /// <summary>
        /// StudentAcademicProgramsFilter constructor
        /// </summary>
        public StudentAcademicProgramsFilter() : base()
        {
            Credentials = new List<GuidObject2>();
        }
    }
}