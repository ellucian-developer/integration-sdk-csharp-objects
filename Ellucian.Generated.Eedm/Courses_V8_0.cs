// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Smallest unit of instruction that can lead to granting credits
    /// </summary>
    [DataContract]
    public class Courses_V8_0 :BaseModel2
    {
        /// <summary>
        /// Human-readable name
        /// </summary>
        [DataMember(Name = "title")]
        [FilterProperty("criteria")]
        public string Title { get; set; }

        /// <summary>
        /// Human-readable description
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Globally unique identifier for course subject
        /// </summary>
        [DataMember(Name = "subject")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Subject { get; set; }

        /// <summary>
        /// Collection of globally unique identifiers for course levels
        /// </summary>
        [DataMember(Name = "courseLevels")]
        public List<GuidObject2> CourseLevels { get; set; }

        /// <summary>
        /// Collection of globally unique identifiers for course instructional methods
        /// </summary>
        [DataMember(Name = "instructionalMethods")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(ArrayGuidObject2FilterConverter))]
        public List<GuidObject2> InstructionMethods { get; set; }

        /// <summary>
        /// A list of units of the educational institution (optionally, hierarchical) that own or are responsible for a course
        /// </summary>
        [DataMember(Name = "owningInstitutionUnits")]
        
        [JsonConverter(typeof(ArrayOwningInstitutionFilterConverter))]
         public List<OwningInstitutionUnit> OwningInstitutionUnits { get; set; }

        /// <summary>
        /// The starting date at which a Course may have Sections created and scheduled to be taken
        /// </summary>
        //[JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "schedulingStartOn")]
        [FilterProperty("criteria")]
        public DateTime EffectiveStartDate { get; set; }

        /// <summary>
        /// The ending date at which a Course may no longer have Sections created nor scheduled to be taken
        /// </summary>
        //[JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "schedulingEndOn", EmitDefaultValue=false)]
        [FilterProperty("criteria")]
        public DateTime? EffectiveEndDate { get; set; }

        /// <summary>
        /// A numbering scheme to distinguish different Courses
        /// </summary>
        [DataMember(Name = "number")]
        [FilterProperty("criteria")]
        public string Number { get; set; }

        /// <summary>
        /// Collection of globally unique identifiers for course academic levels
        /// </summary>
        [DataMember(Name = "academicLevels")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(ArrayGuidObject2FilterConverter))]
        public List<GuidObject2> AcademicLevels { get; set; }

        /// <summary>
        /// Collection of globally unique identifiers for course grade schemes
        /// </summary>
        [DataMember(Name = "gradeSchemes")]
        public List<GuidObject2> GradeSchemes { get; set; }

        /// <summary>
        /// Credit information for the course
        /// </summary>
        [DataMember(Name = "credits")]
        public List<Credit3> Credits { get; set; }

        /// <summary>
        /// Billing credit information for the course
        /// </summary>
        [DataMember(Name = "billing", EmitDefaultValue = false)]
        public BillingCreditDtoProperty Billing { get; set; }


        /// <summary>
        /// Constructor for Course
        /// </summary>
        public Courses_V8_0()
            : base()
        {
            Subject = new GuidObject2(null);
            CourseLevels = new List<GuidObject2>();
            InstructionMethods = new List<GuidObject2>();
            OwningInstitutionUnits = new List<OwningInstitutionUnit>();
            AcademicLevels = new List<GuidObject2>();
            GradeSchemes = new List<GuidObject2>();
            Credits = new List<Credit3>();
        }
    }
}