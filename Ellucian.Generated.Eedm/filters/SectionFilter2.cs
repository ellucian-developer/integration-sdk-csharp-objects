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
    public class SectionFilter2 : BaseModel2
    {

        /// <summary>
        /// Named Query
        /// </summary>
        [DataMember(Name = "subject")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 SubjectName { get; set; }

        /// <summary>
        /// Section number
        /// </summary>
        [DataMember(Name = "number")]
        [FilterProperty("criteria")]
        public string Number { get; set; }

        /// <summary>
        /// Identifier of a section (Section Name)
        /// </summary>
        [DataMember(Name = "code")]
        [FilterProperty("criteria")]
        public string Code { get; set; }

        /// <summary>
        /// Title of section
        /// </summary>
        [DataMember(Name = "title")]
        [FilterProperty("criteria")]
        public string Title { get; set; }

        /// <summary>
        /// Section start date
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// Section end date
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// A technology platform used to manage the administration of an InstructionalEvent.
        /// </summary>
        [DataMember(Name = "instructionalPlatform", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 InstructionalPlatform { get; set; }

        /// <summary>
        /// Academic Time Period or Term
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// Course being offered
        /// </summary>
        [DataMember(Name = "course")]
        [FilterProperty("criteria")]
        public GuidObject2 Course { get; set; }

        /// <summary>
        /// The site where the section is held
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// A list of academic levels at which this section is offered
        /// </summary>
        [DataMember(Name = "academicLevels", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<GuidObject2> AcademicLevels { get; set; }

        /// <summary>
        /// The current status of the section
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SectionStatusDtoProperty Status { get; set; }

        /// <summary>
        /// Information about the organizations who own this section
        /// </summary>
        [DataMember(Name = "owningInstitutionUnits", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<OwningInstitutionUnit> OwningInstitutionUnits { get; set; }


        /// <summary>
        /// Section constructor
        /// </summary>
        public SectionFilter2() : base()
        {
            AcademicLevels = new List<GuidObject2>();
            OwningInstitutionUnits = new List<OwningInstitutionUnit>();
        }
    }
}
