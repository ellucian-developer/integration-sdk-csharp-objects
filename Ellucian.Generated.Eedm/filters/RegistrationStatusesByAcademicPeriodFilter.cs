// Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// RegistrationStatusesByAcademicPeriodFilter named query.
    /// </summary>
    public class RegistrationStatusesByAcademicPeriodFilter
    {
        /// <summary>
        /// AcademicPeriod
        /// </summary>        
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        [FilterProperty("registrationStatusesByAcademicPeriod")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The status of this person's registration in the section.
        /// </summary>
        [JsonProperty("statuses")]
        [FilterProperty("registrationStatusesByAcademicPeriod")]
        public List<SectionRegistrationStatusFilterProperty> Statuses { get; set; }

    }

    /// <summary>
    /// Section Registration status
    /// </summary>
    [DataContract]
    public class SectionRegistrationStatusFilterProperty
    {
        /// <summary>
        /// Additional details about the status.
        /// </summary>
        [DataMember(Name = "detail")]
        public GuidObject2 Detail { get; set; }
    }
}